<?php
// Databazes klase.
// Klases funkcija ir pievienoties datubazei.
// No sis klases tiek mantota klase Model.
namespace Models;

include('config/database.php');

abstract class Database
{
	public function __construct()
	{
		$db = mysql_connect(DB_HOST, DB_USERNAME, DB_PASSWORD) or die("Could not connect database");
		mysql_select_db(DB_NAME, $db) or die("Could not select database");
	}
}