/****** Delete all products with no orders  ******/
DELETE FROM HackCompany.dbo.Product
WHERE HackCompany.dbo.Product.Id NOT IN (SELECT opj.ProductId FROM HackCompany.dbo.OrderProductJoin opj)

