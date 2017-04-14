<?php

$usr = $_POST['sensorValue'];

$host="localhost";
$user="root";
$pass="welcome";
$db="sensor_data";


$connection= mysql_connect($host,$user,$pass) or die("unable...........");

mysql_select_db($db) or die("unable...........");


 mysql_query("INSERT INTO web_health(light_record) VALUES('$usr')");
 		
 			if(mysql_affected_rows() == 1){
				echo 'done';
			}
			else{
				echo 'fails';
			}
mysql_close($connection);
?>
