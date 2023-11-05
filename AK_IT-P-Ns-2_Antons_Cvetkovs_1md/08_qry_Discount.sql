UPDATE orderdetails AS od
SET od.Discount = 0.5
WHERE od.ProductID IN (
    SELECT DISTINCT p.ProductID
    FROM products AS p
    WHERE p.SupplierID IN (
        SELECT s.SupplierID
        FROM suppliers AS s
        WHERE s.CompanyName = 'Tokyo Traders'
    )
);