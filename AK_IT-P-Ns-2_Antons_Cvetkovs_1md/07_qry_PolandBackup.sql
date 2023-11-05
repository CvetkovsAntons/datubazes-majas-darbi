INSERT INTO customersbackup (
    SELECT *
    FROM customers
    WHERE Country = 'Poland'
);