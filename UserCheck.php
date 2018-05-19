<?php
$servername = "localhost";
$server_username = "root";
$server_password = "30147813";
$dbName = "rpg_game";


$u_email = $_POST["emailPost"]; //"test email";
$u_password = $_POST["passwordPost"]; //"123456";


$conn = new mysqli($servername, $server_username, $server_password, $dbName);

if(!$conn){
    die("Connection Failed.". mysqli_connect_error());
}
    $sql = "SELECT password FROM users WHERE email = '".$u_email."' ";
    $result = mysqli_query($conn, $sql);

    if( mysqli_num_rows($result)>0) {
        while ($row = mysqli_fetch_assoc($result)) {
            if ($row['password'] == $u_password) {
                 echo "Correct";
               // echo $row;
            } else {
                 echo "Incorrect";
                 //echo "passowrd is = ". $row['password'];
            }
        }
    }else {
        echo "User Not Found";
        //echo "passowrd is = ". $row['password'];
    }


?>