<?php
use Controllers\MasinasController;

$model = MasinasController::model();
$primary_key = $model->primaryKey();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
	try {
		foreach ($_POST as $key => $value) {
			if (!in_array($key, $model->columns())) unset($_POST[$key]);
		}
		$model->create($_POST);
	} catch (\Exception $e) {
		$error_post = $e->getMessage();
	}
}

if ($_SERVER['REQUEST_METHOD'] == 'GET' && isset($_GET['button']) && $_GET['button'] === 'Search' && isset($_GET[$primary_key])) {
	try {
		$car = $model->find($primary_key, $_GET[$primary_key]);
	} catch (\Exception $e) {
		$error_get = $e->getMessage();
	}
}
?>

<div class="container">
	<div class="row mt-3 mb-3 align-self-stretch">
		<div class="col-6">
			<div class="card h-100">
				<div class="card-body">
					<h5 class="card-title">Add car to DB</h5>
					<form name="form" method="POST">
						<?php foreach (MasinasController::model()->columns() as $value): ?>
							<div class="row mb-3">
								<div class="col-3"><label for="<?= $value; ?>"><?= $value; ?></label></div>
								<div class="col-9">
									<input type="text" id="<?= $value; ?>" name="<?= $value; ?>" class="w-100">
								</div>
							</div>
						<?php endforeach; ?>
						<input class="btn btn-primary w-100" name="button" type="submit" value="Create">
					</form>
					<?php if (isset($error_post)): ?>
						<p><b>Error: </b><?= $error_post; ?></p>
					<?php endif; ?>
				</div>
			</div>
		</div>
		<div class="col-6">
			<div class="card h-100">
				<div class="card-body">
					<h5 class="card-title">Search car by number</h5>
					<form name="form" method="GET" class="mb-3">
						<div class="row mb-3">
							<div class="col-3"><label for="<?= $primary_key; ?>"><?= $primary_key; ?></label></div>
							<div class="col-9">
								<input type="text" id="<?= $primary_key; ?>" name="<?= $primary_key; ?>" class="w-100">
							</div>
						</div>
						<input class="btn btn-primary w-100" name="button" type="submit" value="Search">
					</form>
					<?php if (isset($error_get)): ?>
						<p><b>Error: </b><?= $error_get; ?></p>
					<?php endif; ?>
					<?php if (isset($car)): ?>
						<?php foreach ($car as $key => $value): ?>
							<div class="row mb-3">
								<div class="col-3"><label for="<?= $key; ?>"><?= $key; ?></label></div>
								<div class="col-9"><input id="<?= $key; ?>" value="<?= $value; ?>" readonly></div>
							</div>
						<?php endforeach; ?>
					<?php endif; ?>
				</div>
			</div>
		</div>
	</div>
</div>