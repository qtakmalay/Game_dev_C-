<?php
$servername = "localhost";
$server_username = "root";
$server_password = "30147813";
$dbName = "rpg_game";

$class =  $_POST["classPost"];   //"Lucas Test AC";
$type = $_POST["typePost"]; //"test email";
$hairColor = $_POST["hairColorPost"]; //"123456";
$bodyShape = "thin";
$fatThickness = "thick";

$conn = new mysqli($servername, $server_username, $server_password, $dbName);


if(!$conn){
    die("Connection Failed.". mysqli_connect_error());
}
else {
    $sql = "INSERT INTO rpg_game.character (class, typeChar, hairColor, bodyShape, fatThickness) 
           VALUES ('" . $class . "','" . $type . "','" . $hairColor . "', '" . $bodyShape . "', '" . $fatThickness . "')";
    $result = mysqli_query($conn, $sql);
    echo $class;
}
if(!result) echo "ERROR";
?>