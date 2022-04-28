INSERT INTO tblDiscount VALUES
('Indirim5',5)
GO
INSERT INTO tblCategori VALUES
('Teknoloji','Aciklama Yok')
GO
INSERT INTO tblBrand VALUES
('Samsung')
GO
INSERT INTO tblProduct VALUES
(7,1564.60,NULL,NULL,'Samsun S9',1,1)
GO
INSERT INTO tblShoppingCart VALUES
(1564.60,1,12.30,1)
GO
INSERT INTO tblUser VALUES
('Ahmet','5462138465','ahmetyoruk@hotmail.com','123456',1)
GO
INSERT INTO tblComment VALUES
('Yorumum','Bu nasil yorumm....',3,'2021-12-31 23:59:59',1,1)
GO
INSERT INTO tblFeature VALUES
('Suya dayanikli', '1 metreye kadar suya dayanaklidir.')
GO
INSERT INTO tblRelationsipProductFeature VALUES
(1,1)
GO
INSERT INTO tblRelationshipProductShoppingCart VALUES
(1,1)
GO