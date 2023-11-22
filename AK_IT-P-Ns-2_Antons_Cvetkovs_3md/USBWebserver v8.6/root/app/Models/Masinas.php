<?php
// Masinas modele, seit tiek ievaditi tabulas nosaukums, primara atslega un visas kolonnas
namespace Models;

class Masinas extends Model
{
	public function __construct()
	{
		$this->table = 'masinas';
		$this->primary_key = 'numurs';
		$this->columns = [
			'numurs' => ['length' => 6],
			'marka' => ['length' => 15],
			'krasa' => ['length' => 15],
			'izlaisanas_gads' => ['length' => 4, 'max' => 2023, 'min' => 1886] // prima masina tika konstrueta 1886 gada :)
		];
		parent::__construct();
	}
}