CREATE TABLE IF NOT EXISTS CustomersBackup AS (
    SELECT *
    FROM customers
    WHERE Country = 'Spain'
);