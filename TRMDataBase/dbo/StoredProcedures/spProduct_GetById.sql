﻿CREATE PROCEDURE [dbo].[spProduct_GetById]
@Id int 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	FROM DBO.Product
	WHERE Id = @Id;
END