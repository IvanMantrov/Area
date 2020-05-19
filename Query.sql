SELECT Products.Name, Categories.Name
FROM Products LEFT JOIN  Category ON Products.ID=Categories.ProductId 
ORDER BY Products.Name;
