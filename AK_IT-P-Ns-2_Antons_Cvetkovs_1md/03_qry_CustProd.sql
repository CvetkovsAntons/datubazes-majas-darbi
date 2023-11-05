SELECT ProductName
FROM products AS p
JOIN orderdetails AS od ON p.ProductID = od.ProductID
JOIN orders AS o ON od.OrderID = o.OrderID
WHERE o.CustomerID = 'FRANK';