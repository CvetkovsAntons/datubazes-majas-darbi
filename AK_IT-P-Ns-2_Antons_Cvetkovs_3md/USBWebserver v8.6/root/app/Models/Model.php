<?php
// Modeles klase
// No sis klases tiek mantoti visi objekti

namespace Models;

abstract class Model extends Database
{
	protected $table; // tabulas nosaukums
	protected $primary_key; // pirmara atslega
	protected $columns; // kolonas saraksts

	public final function primaryKey() { return $this->primary_key; } // funkcija, kas atgriez piramro atslegu
	public final function columns($only_name = true) { return $only_name ? array_keys($this->columns) : $this->columns; } // funkcija, kas atgriez visu kolonnu nosaukumus

	private function validateData(array $data)
	{
		foreach ($data as $key => $value) {
			if (!in_array($key, $this->columns())) {
				throw new \Exception($key . ' is not a valid column');
			}

			if (!$value) {
				throw new \Exception($key . ' value is invalid');
			}

			if (strlen($value) > $this->columns[$key]['length']) {
				throw new \Exception($key . ' value is too long');
			}

			if (isset($this->columns[$key]['max']) && $value > $this->columns[$key]['max']) {
				throw new \Exception($key . ' max value is ' . $this->columns[$key]['max']);
			}

			if (isset($this->columns[$key]['min']) && $value < $this->columns[$key]['min']) {
				throw new \Exception($key . ' min value is ' . $this->columns[$key]['min']);
			}

			$data[$key] = "'" . mysql_real_escape_string(trim($value)) . "'";
		}

		return $data;
	}

	public final function create(array $data) // funkcija, kas pievieno jaunu ierakstu tabula
	{
		$data = $this->validateData($data);

		$columns = implode(', ', array_keys($this->columns));
		$values  = implode(', ', $data);

		$sql = "INSERT INTO $this->table ($columns) VALUES ($values)";
		if (!mysql_query($sql)) throw new \Exception(mysql_error());

		return true;
	}

	public final function find($column, $value) // funkcija, kas mekle ierakstu ar kolonnas vertibu
	{
		$this->validateData([$column => $value]);
		$value = "'" . mysql_real_escape_string(trim($value)) . "'";
		$sql = "SELECT * FROM $this->table WHERE $column = $value";
		$result = mysql_query($sql);
		$data = mysql_fetch_assoc($result);
		mysql_free_result($result);
		return $data;
	}
}