SELECT COUNT(QuantityPerUnit) AS CountOfProductsInBottles
FROM products
WHERE QuantityPerUnit LIKE '%bottle%';