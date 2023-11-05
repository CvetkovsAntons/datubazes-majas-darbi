SELECT ProductName, (UnitsOnOrder - UnitsInStock) AS DifferenceInUnits
FROM products
WHERE UnitsInStock < UnitsOnOrder;