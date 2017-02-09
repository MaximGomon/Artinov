--
-- Скрипт сгенерирован Devart dbForge Studio for SQL Server, Версия 5.4.211.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/sql/studio
-- Дата скрипта: 09.02.2017 20:03:51
-- Версия сервера: 12.00.2000
-- Версия клиента: 
--

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('cb49047f-8876-4e47-b4ac-429062eec6bb', N'Lake fish', '8e0ae88c-33d1-4b59-ae8e-c5fe3189c69e')
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('45e70775-ff0e-468c-ae11-4e687eb57bec', N'Sea fish', '8e0ae88c-33d1-4b59-ae8e-c5fe3189c69e')
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('641e2db6-8b01-414a-a00d-4f2cc1781e5c', N'Lastochka', 'e319cf1a-1f64-4841-8d72-dd89e5837f8f')
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('c796ef36-90c2-43b7-a75a-536c4c99a993', N'Korop', 'cb49047f-8876-4e47-b4ac-429062eec6bb')
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('2f4fceda-e8bc-4528-a352-6a7abce33911', N'Vorona', 'e319cf1a-1f64-4841-8d72-dd89e5837f8f')
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('8e0ae88c-33d1-4b59-ae8e-c5fe3189c69e', N'Fish', NULL)
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('e319cf1a-1f64-4841-8d72-dd89e5837f8f', N'Birds', NULL)
INSERT AnimalDb.dbo.AnimalTypes(Id, Name, Parent_Id) VALUES ('e84564bb-eae7-4fe9-a977-e19c0c65de28', N'Shark', '45e70775-ff0e-468c-ae11-4e687eb57bec')
GO