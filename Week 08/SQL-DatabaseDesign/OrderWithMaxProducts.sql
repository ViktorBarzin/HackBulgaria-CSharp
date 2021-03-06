/****** Select the order having the maximum total number of products  ******/
SELECT TOP 1 count(*) as NumberOfProducts, o.Id as OrderId
FROM HackCompany.dbo.OrderProductJoin op, HackCompany.dbo.[Order] o
WHERE o.Id=op.OrderId
GROUP BY o.Id
ORDER BY NumberOfProducts DESC
