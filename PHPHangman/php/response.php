<?php

/* Author: Troy Dildine
 * Date: 12/18/14
 * Project: PHP Hangman
 */

//Returns data in the form of a JSON object to the AJAX requester
header('Content-type: application/json');
//This will automatically load any needed class if the PHP filename is in the form <class>.php
function __autoload($class_name)
{
    include $class_name . '.php';
}

//Begins the session to store the active game
session_start();

//Creates a new game if necessary and loads the player's record from the stored cookie
if(!isset($_SESSION['hangmanGame']))
{
    $_SESSION['hangmanGame'] = new hangman();
    $_SESSION['hangmanGame']->loadRecord();
}

//Creates a new array that will be used to pass JSON objects to the AJAX requester
$outputting=array();
//Performs the guess operation if it's valid
if(isset($_POST['guess']))
{
    $outputting = $_SESSION['hangmanGame']->playGame($_POST['guess']);
}
//If no guess exists, this will run the function with a null value to trigger things like a new game
else
{
    $outputting = $_SESSION['hangmanGame']->playGame(null);
}
//Encodes the returned array as JSON for sending to the AJAX requester
echo json_encode($outputting);