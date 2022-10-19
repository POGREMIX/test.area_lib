  SELECT p.Name, c.Name
  FROM [dbo].[Product] p
  LEFT JOIN [dbo].[Category] c ON p.CategoryId=c.Id
  UNION
  SELECT p.Name, c.Name
  FROM [dbo].[Category] c
  LEFT JOIN [dbo].[Product] p ON c.productId=p.id