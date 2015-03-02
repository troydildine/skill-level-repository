/* Author: Troy Dildine
 * Date: 12/18/14
 * Project: PHP Hangman
 */

$(function () {
    //Runs when the document loads
    $(document).ready(function () {
        defaultPage();
    });
    //Runs when a user clicks a link in the #letters div
    $("#letters a").on("click", function (e) {
        //Grabs the text of the link and uses it to run the playGame function.
        var txt = $(e.target).text().toLowerCase();
        playGame(txt);
    });
    //Used to register the event when a user clicks "Play Again"
    $("#reset").on("click", function () {
        defaultPage();
    });
});

function defaultPage() {
    //Resets each letter's link back to normal
    //This works because they are the only links on the page during the pageload
    $("a").each(function (i) {
        $(this).removeClass("rightguess wrongguess");
    });
    //This will cause everything to reset and a new game to start
    playGame(null);
    //These are the default appearances of the screen. These fill in the various tags present in the skeleton homepage.
    $("#instructions").text("Welcome to PHP Hangman!");
    $("#personimage").attr("src", "images/hangman_0.png");
    $("#personimage").attr("alt", "0 incorrect guesses");
    $("#guesses").text("You have 9 guesses remaining!");
}

function playGame(guess) {
    //This is needed in order to pass the information in JSON format.
    var sendGuess = {guess: guess};
    //This runs a POST request using AJAX from jQuery.
    $.ajax({
        url: "php/response.php",
        type: "post",
        //This sends the guess to the PHP script in JSON format.
        data: sendGuess,
        dataType: 'json',
        //This AJAX request gets an array called "data" back from the PHP script.
        success: function (data) {
            //This appends the current guess to the data array for use by the UpdateScreen function.
            data['guess'] = guess;
            updateScreen(data);
        },
        //Displays a verbose error message if something happens
        error: function (xhr, status, error) {
            var err = JSON.parse(xhr.responseText);
            alert(err.Message);
        }
    });
}

function updateScreen(input) {
    // True if the PHP script finds a cookie - indicates past user
    if(input.returning === true)
    {
        //Sets the contents of the #instructions div to a welcome message.
        $("#instructions").text("Welcome back to PHP Hangman!");
    }
    if (input.gameWon == true) // Game is won
    {
        document.title = "PHP HANGMAN | YOU'VE WON!";
        //Disables all of the letter links, and turns them green
        $("#letters a").removeClass("wrongguess");
        $("#letters a").addClass("rightguess");
        $("#guesses").text("YOU HAVE WON!!!");
        //Displays the user's record and allows them to choose to play again.
        $("#word").html("The correct answer was " + input.word + "<br/>Your record is " + input.losses +
        " losses and " + input.wins + " wins for a record of " + input.record + "%<br/>");
        $("#reset").html("<a href='#'>PLAY AGAIN</a>");
    }
    else // Game is not won
    {
        //=== operator is needed to ensure that remainingGuesses is actually set
        if (input.gameWon == false && input.remainingGuesses === 0) // Game is lost
        {
            document.title = "PHP Hangman | YOU'VE LOST!";
            //Disables all of the letter links, and turns them red
            $("#letters a").removeClass("rightguess");
            $("#letters a").addClass("wrongguess");
            $("#personimage").attr("src", "images/hangman_9.png");
            $("#personimage").attr("alt", "9 incorrect guesses");
            $("#guesses").text("YOU ARE HANGED!");
            //Displays the user's record and allows them to choose to play again.
            $("#word").html("The correct answer was " + input.word + "<br/>Your record is " + input.losses +
                " losses and " + input.wins + " wins for a record of " + input.record + "%<br/>");
            $("#reset").html("<a href='#'>PLAY AGAIN</a>");
        }
        else // Game is not over
        {
            if (input.guess) // Not a null guess
            {
                //input is the array passed by the AJAX request - in turn sent by the PHP script
                //correctGuess reflects whether the guessed letter was found in the word
                if (input.correctGuess) { //Guess is correct - turns link green and disables it
                    $("#" + input.guess).addClass("rightguess");
                }
                else { //Guess is incorrect - turns link red and disables it
                    $("#" + input.guess).addClass("wrongguess");
                }
            }
            //Updates the image and alt text to reflect number of incorrect guesses
            $("#personimage").attr("src", "images/hangman_" + input.incorrectGuesses + ".png");
            $("#personimage").attr("alt", input.incorrectGuesses + " incorrect guesses");
            //Updates other data about the game
            $("#guesses").text("You have " + input.remainingGuesses + " guesses remaining!");
            $("#word").html(input.wordDisplay);
            //Shows nothing in the #reset div - this is only used to show the "Play Again" link
            //This link is not needed here - the game isn't over
            $("#reset").text("");
        }
    }
}