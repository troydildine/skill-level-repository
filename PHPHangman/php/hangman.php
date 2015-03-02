<?php

/* Author: Troy Dildine
 * Date: 12/18/14
 * Project: PHP Hangman
 */

class hangman
{
    const GUESSES = 9;
    const WORDLIST = "../txt/wordlist.txt";

    //Used to store letters the user has already guessed
    var $letters = array();
    //Used to store the active word the user is trying to guess
    var $word = "";
    //Used to store the word, with letters ommitted if the user has not yet guessed them
    var $wordDisplay = array();
    //Used to store a list of every word from the word list
    var $words = array();
    //Used to keep track of how many more guesses the player can use
    var $remainingGuesses;
    //Used to track whether the game has been won
    var $gameWon = false;
    var $wins = 0;
    var $losses = 0;

    function loadRecord()
    {
        //If there is a win record cookie, it will be loaded
        if (isset($_COOKIE['wins']))
        {
            $this->wins = $_COOKIE['wins'];
        } else
        {
            $this->wins = 0;
        }
        //If there is a loss record cookie, it will be loaded
        if (isset($_COOKIE['losses']))
        {
            $this->losses = $_COOKIE['losses'];
        } else
        {
            $this->losses = 0;
        }
    }

    function playGame($input)
    {
        //This creates a new game if the game has not been started or is over
        if (!isset($this->word) || $this->word == "" || $this->gameWon == true || $this->remainingGuesses == 0)
        {
            $this->newGame();
        }
        if (strlen($input) > 0) //There is a guess
        {
            $correctGuess = $this->guessLetter($input);
        }
        //Creates an array to pass values to the AJAX requester
        $output = array();
        //This check is needed because the dummy "null" methods will otherwise cause problems
        //This value is only set if the user has made a real guess
        if (isset($correctGuess))
        {
            $output['correctGuess'] = $correctGuess;
        }
        $output['remainingGuesses'] = $this->remainingGuesses;
        //This calculates the number of incorrect guesses for ues in displaying the images.
        $output['incorrectGuesses'] = self::GUESSES - $this->remainingGuesses;
        $output['gameWon'] = $this->gameWon;
        //This creates a string for display purposes, with more spacing for readability
        $output['wordDisplay'] = $this->getWord();
        $output['wins'] = $this->wins;
        $output['losses'] = $this->losses;
        //This prevents a divide by zero error in case the values are both not set yet
        if ($this->wins > 0 || $this->losses > 0)
        {
            $output['record'] = ($this->wins / ($this->wins + $this->losses)) * 100;
            //Flags that the user is a returning user and should be greeted with a welcome back message.
            $output['returning'] = true;
        }
        //The game is over, and the AJAX requester will need the word for display purposes
        if ($this->remainingGuesses == 0 || $this->gameWon == true)
        {
            $output['word'] = $this->word;
        }
        //Returns all of this information as an array for passing to the AJAX requester
        return $output;
    }

    //Resets all of the information back to normal for a new game.
    function newGame()
    {
        $this->letters = array();
        $this->chooseWord();
        $this->gameWon = false;
        $this->remainingGuesses = self::GUESSES;
    }

    //Loads the words from the text file if necessary and then chooses one and creates a string with blank lines
    function chooseWord()
    {
        $this->loadWords();
        $this->word = trim($this->words[rand(0, count($this->words) - 1)]);
        $this->wordDisplay = array();
        //This is used to display the word to the user for guessing
        foreach (str_split($this->word) as $i)
        {
            $this->wordDisplay[] = '_';
        }
    }

    function loadWords()
    {
        if (count($this->words) == 0)
        {
            $wordsFile = fopen(self::WORDLIST, "r") or die("ERROR! Word list file could not be read!");
            //Splits every word in the word list for use in an array
            $this->words = explode("\n", strtolower(fread($wordsFile, filesize(self::WORDLIST))));
        }
    }

    //This function is used to process guesses made by users
    function guessLetter($letter)
    {
        if ($this->gameWon || $this->remainingGuesses == 0) // Game is already over, and guess is invalid
            return;
        if (is_string($letter) && (strlen($letter) == 1)) //Valid one-letter guess
        {
            $letter = strtolower($letter); //Only uses lowercase letters
            if (!in_array($letter, $this->letters)) //Guess is unique, and valid
            {
                $this->letters[] = $letter; //Adds letter to array as having been guessed
                $lastPos = 0;
                $positions = array();
                //This statement finds all of the instances of the guessed letter in the word
                while (($lastPos = strpos($this->word, $letter, $lastPos)) !== false)
                {
                    $positions[] = $lastPos;
                    $lastPos = $lastPos + strlen($letter);
                }
                //At least one instance of the letter exists in the word
                if (count($positions) > 0) //Guess is correct
                {
                    //Replaces all of the lines with the guesses letter where it is valid and correct
                    foreach ($positions as $value)
                    {
                        $this->wordDisplay[$value] = $letter;
                    }
                    //Determines whether any lines still exist in the output and declares a winner if not
                    $result = array_search('_', $this->wordDisplay);
                    if ($result !== false) //Game is not won
                    {

                    } else //Game is won
                    {
                        $this->gameWon = true;
                        $this->addWin();
                    }
                    return true;
                } else //Guess is incorrect
                {
                    $this->remainingGuesses--;
                    if ($this->remainingGuesses === 0)
                    {
                        $this->addLoss();
                    }
                    return false;
                }
            } else //Guess is not unique, is not valid
            {
                return;
            }
        } else //Invalid guess
        {
            return;
        }
    }

    //Updates the cookies and the field variable with accurate record information.
    function addWin()
    {
        $this->wins += 1;
        setcookie("wins", $this->wins, time() + (86400 * 90));
    }

    //Updates the cookies and the field variable with accurate record information.
    function addLoss()
    {
        $this->losses += 1;
        setcookie("losses", $this->losses, time() + (86400 * 90));
    }

    function getWord() //Used to display the word with underscores in places the letter has not been guessed
    {
        $wordOutput = "";
        foreach ($this->wordDisplay as $i)
        {
            $wordOutput .= $i;
            $wordOutput .= ' &nbsp;';
        }
        return trim($wordOutput);
    }
}
