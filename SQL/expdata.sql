INSERT dbo.Category(Id, Name, ProductId) VALUES ('d15da86d-2e7c-4054-8682-c120908c71b1', N'еда', 'c09c035e-fbba-4cd9-9794-69f3d573e0b1')
INSERT dbo.Category(Id, Name, ProductId) VALUES ('ab4bcf8d-ab4b-411b-a197-6fa4b9605f20', N'сладости', 'c09c035e-fbba-4cd9-9794-69f3d573e0b1')
INSERT dbo.Category(Id, Name, ProductId) VALUES ('99b4d662-0ccc-46bf-b1ec-618a7941688a', N'транспорт', NULL)
INSERT dbo.Category(Id, Name, ProductId) VALUES ('7925a980-15f0-41ab-80c5-c14a7dc1955f', N'электроника', '38d2a575-3403-4403-a8eb-5742c0699ac9')
GO

INSERT dbo.Product(Id, Name, CategoryId) VALUES ('436ee07d-07fd-4d3f-bcf3-328a9e13a224', N'яблоко', 'd15da86d-2e7c-4054-8682-c120908c71b1')
INSERT dbo.Product(Id, Name, CategoryId) VALUES ('def33251-994c-4d67-acd4-66f85984c9d0', N'мясо', 'd15da86d-2e7c-4054-8682-c120908c71b1')
INSERT dbo.Product(Id, Name, CategoryId) VALUES ('bca14989-dd8b-4b51-8130-95641e0925d5', N'кекс', 'ab4bcf8d-ab4b-411b-a197-6fa4b9605f20')
INSERT dbo.Product(Id, Name, CategoryId) VALUES ('c09c035e-fbba-4cd9-9794-69f3d573e0b1', N'торт', 'ab4bcf8d-ab4b-411b-a197-6fa4b9605f20')
INSERT dbo.Product(Id, Name, CategoryId) VALUES ('33eecd0e-d560-4ad6-ab11-1d5b3e22c6b1', N'ТВ', NULL)
INSERT dbo.Product(Id, Name, CategoryId) VALUES ('38d2a575-3403-4403-a8eb-5742c0699ac9', N'наушники', '7925a980-15f0-41ab-80c5-c14a7dc1955f')
GO