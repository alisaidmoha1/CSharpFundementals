SELECT * FROM Transactions T LEFT JOIN Customers C
ON T.CustomerId = C.Id

SELECT T.ProductId, T.Quantity, C.Name 
FROM Transactions T LEFT JOIN Customers C
ON T.CustomerId = C.Id

SELECT A.Email, B.Email, A.Name
FROM Customers A, Customers B
Where  A.Id <> B.Id
AND A.Name = B.Name
ORDER BY A.Name

SELECT P.Name, T.Id, T.Quantity
FROM Products P LEFT Join Transactions T
ON P.Id = T.ProductId
WHERE T.Quantity >1