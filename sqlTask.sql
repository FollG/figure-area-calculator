use sqlTest;

GO

SELECT Products.[Name], Category.[Name]
	FROM Products
		LEFT JOIN ProductCategories
			ON Products.ID = ProductCategories.ProductId 
		LEFT JOIN Category
			ON Category.ID = ProductCategories.CategoryId 
