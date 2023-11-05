SELECT DISTINCT ProductName
FROM products AS p
JOIN orderdetails AS od ON p.ProductID = od.ProductID
JOIN orders AS o ON od.OrderID = o.OrderID
WHERE o.ShipCountry = 'Germany' AND YEAR(o.ShippedDate) = 1997 AND MONTH(o.ShippedDate) BETWEEN 6 AND 8;