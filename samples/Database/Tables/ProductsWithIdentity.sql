﻿CREATE TABLE ProductsWithIdentity (
	ProductId INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	Name VARCHAR(100),
	Cost INT
);