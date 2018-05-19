<?php
    $servername = "localhost";
    $server_username = "root";
    $server_password = "30147813";
    $dbName = "rpg_game";

    $username =  $_POST["usernamePost"];   //"Lucas Test AC";
    $email = $_POST["emailPost"]; //"test email";
    $password = $_POST["passwordPost"]; //"123456";
    $passwordVerification = $_POST["passwordPost"];

    $conn = new mysqli($servername, $server_username, $server_password, $dbName);

    if(!$conn){
        die("Connection Failed.". mysqli_connect_error());
    } elseif ($password != $passwordVerification){
        die("Password is not verified .". mysqli_connect_error());
    }
    else {
        $sql = "INSERT INTO users (username, email, password) 
           VALUES ('" . $username . "','" . $email . "','" . $password . "')";
        $result = mysqli_query($conn, $sql);
    }
    if(!result) echo "ERROR";
    else echo "OK!";

?>