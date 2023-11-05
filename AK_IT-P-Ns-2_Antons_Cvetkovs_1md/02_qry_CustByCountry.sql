SELECT COUNT(CustomerID) AS CountOfCustomers, Country
FROM customers
GROUP BY Country
ORDER BY Country;