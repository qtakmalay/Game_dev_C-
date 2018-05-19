<?php
    $servername = "localhost";
    $username = "root";
    $password = "30147813";
    $dbName = "rpg_game";

    $conn = new mysqli($servername, $username, $password, $dbName);

    if(!$conn){
        die("Connection Failed.". mysqli_connect_error());
    }

    $sql = "SELECT ID, Name, Type, Cost FROM items";
    $result = mysqli_query($conn, $sql);

    if(mysqli_num_rows($result) > 0){
        while($row = mysqli_fetch_assoc($result)){
            echo "ID:".$row['ID']. "|Name:". $row['Name']. "|Type:".$row['Type']. "|Cost:". $row['Cost']. ";";
        }
    }
?>