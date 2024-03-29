USE [SistemaDeInventario]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[codcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombrecat] [varchar](15) NOT NULL,
	[Descrpcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[codcliente] [int] IDENTITY(1,1) NOT NULL,
	[cedulacl] [varchar](15) NOT NULL,
	[nombrescli] [varchar](30) NOT NULL,
	[apellidos] [varchar](20) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [varchar](11) NOT NULL,
	[correo_cli] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[codempleado] [int] IDENTITY(1,1) NOT NULL,
	[cedulaempleado] [varchar](15) NOT NULL,
	[nombre_emple] [varchar](30) NOT NULL,
	[apellidoemple] [varchar](30) NOT NULL,
	[telefonoempl] [varchar](11) NOT NULL,
	[direccionempl] [varchar](50) NOT NULL,
	[correoemple] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[fechaFactura] [datetime] NOT NULL,
	[codcliente] [int] NULL,
	[codempleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[codproducto] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](100) NOT NULL,
	[precio] [int] NOT NULL,
	[existencia] [int] NOT NULL,
	[codcategoria] [int] NULL,
	[codproveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[codproveedor] [int] IDENTITY(1,1) NOT NULL,
	[ruc] [varchar](20) NOT NULL,
	[nombreprov] [varchar](50) NOT NULL,
	[telefono] [varchar](11) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[correoprov] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[codventa] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[codproducto] [int] NULL,
	[idFactura] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (3, N'Alim. Animales', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (4, N'Frutas', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (5, N'Carne / Aves', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (6, N'Lácteos', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (7, N'Pastas', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (8, N'Panaderias', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (9, N'Granos básicos', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (10, N'Embutidos', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (11, N'Aceites', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (13, N'Detergentes', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (14, N'Botanas', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (15, N'Café', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (16, N'Bebidas', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (17, N'Condimentos', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (18, N'Mariscos', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (19, N'Leche en polvo', N'')
INSERT [dbo].[Categoria] ([codcategoria], [nombrecat], [Descrpcion]) VALUES (20, N'Otros productos', N'')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (3, N'1213467n', N'Esther ', N'Duarte', N'UNO 3 c al oeste', N'85411756', N'esther@gmail.com')
INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (4, N'2810809620004F', N'Aura Lila', N'Medina Rios', N'Pueblo San Jacinto, Cost.E. De Ig. Catolica', N'22222810', N'aura.lila@pranks.com')
INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (8, N'454656456', N'Gladys Mercedes', N'Guadamuz Pacheco', N'Igl.Subt.3C.S. 1C.O.', N'813281', N'gladys.mercedes@yahoo.com')
INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (9, N'2810809720007E', N'Adriana Mercedes', N'Castillo Toval', N'2810809720007E', N'82528108', N'adriana@outlook.com')
INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (11, N'2810810740016K', N'Rafael', N'Nadal', N'Rpto. Mario Quant,Coleg. Ruben Dario 4C.O. 1 C.N.', N'89201934', N'rafa@nadal.com')
INSERT [dbo].[Clientes] ([codcliente], [cedulacl], [nombrescli], [apellidos], [direccion], [telefono], [correo_cli]) VALUES (12, N'121210797LLO9', N'María José', N'Urbina', N'Frente escuela Tierno Galván', N'82186835', N'mj@gmail.com')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([codempleado], [cedulaempleado], [nombre_emple], [apellidoemple], [telefonoempl], [direccionempl], [correoemple]) VALUES (3, N'2810902650019M', N'Julio', N'Centeno', N'84428109', N'Bo. Sutiava, Coleg. Calasanz   C. Este', N'julio.cesar@outlook.com')
INSERT [dbo].[Empleados] ([codempleado], [cedulaempleado], [nombre_emple], [apellidoemple], [telefonoempl], [direccionempl], [correoemple]) VALUES (4, N'2810902720000D', N'Martha Alejandra', N'Garcia Santana', N'86328109', N'Bo. Sutiava, Frente Al Colegio Calasanz', N'martha.alejandra@gmail.com')
INSERT [dbo].[Empleados] ([codempleado], [cedulaempleado], [nombre_emple], [apellidoemple], [telefonoempl], [direccionempl], [correoemple]) VALUES (5, N'2810902760007P', N'Luis Francisco', N'Barrera Loaisiga', N'84328109', N'Bo. San Sebastian, Teatrogonzalez 2 C. Sur', N'luis.francisco@gmail.com')
INSERT [dbo].[Empleados] ([codempleado], [cedulaempleado], [nombre_emple], [apellidoemple], [telefonoempl], [direccionempl], [correoemple]) VALUES (6, N'2810903140008J', N'Rosa Victoria', N'Salgado Reyes', N'82928109', N'Cmca. Tecuaname, Cost. Norte C/S.', N'salgado.reyes@outlook.com')
INSERT [dbo].[Empleados] ([codempleado], [cedulaempleado], [nombre_emple], [apellidoemple], [telefonoempl], [direccionempl], [correoemple]) VALUES (8, N'2810902730007F', N'Karla Patricia', N'Berrios Muñoz', N'86428109', N'Cmca. Troilo, C.De Salud 2Km.E.', N'karla@yahoo.com')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([idFactura], [fechaFactura], [codcliente], [codempleado]) VALUES (5, CAST(N'2019-08-19 00:00:00.000' AS DateTime), 9, 4)
INSERT [dbo].[Factura] ([idFactura], [fechaFactura], [codcliente], [codempleado]) VALUES (6, CAST(N'2019-08-01 00:00:00.000' AS DateTime), 11, 8)
INSERT [dbo].[Factura] ([idFactura], [fechaFactura], [codcliente], [codempleado]) VALUES (7, CAST(N'2019-08-04 00:00:00.000' AS DateTime), 4, 6)
SET IDENTITY_INSERT [dbo].[Factura] OFF
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([codproducto], [producto], [precio], [existencia], [codcategoria], [codproveedor]) VALUES (2, N'Arroz', 15, 595, 9, 1)
INSERT [dbo].[Productos] ([codproducto], [producto], [precio], [existencia], [codcategoria], [codproveedor]) VALUES (3, N'Frijoles', 18, 985, 9, 1)
INSERT [dbo].[Productos] ([codproducto], [producto], [precio], [existencia], [codcategoria], [codproveedor]) VALUES (4, N'Leche ', 15, 120, 19, 4)
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([codproveedor], [ruc], [nombreprov], [telefono], [direccion], [correoprov]) VALUES (1, N'002191087100iL', N'Miscelanea La Bendición', N'22778810', N'Km 14 carretera a Masaya', N'labendicion@gmail.com')
INSERT [dbo].[Proveedores] ([codproveedor], [ruc], [nombreprov], [telefono], [direccion], [correoprov]) VALUES (4, N'00108096099OL', N'Fábrica Lala', N'22449029', N'Km 15 carretera Panamericana', N'info@lala.com')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (1, 100, 15, 2, 1)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (2, 100, 15, 2, 1)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (3, 200, 15, 2, 1)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (4, 14, 15, 4, 2)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (5, 2, 15, 3, 7)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (6, 5, 13, 2, 5)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (7, 3, 13, 3, 6)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (8, 10, 13, 3, 5)
INSERT [dbo].[Ventas] ([codventa], [cantidad], [precio], [codproducto], [idFactura]) VALUES (9, 10, 120, 4, 7)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([codcliente])
REFERENCES [dbo].[Clientes] ([codcliente])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([codempleado])
REFERENCES [dbo].[Empleados] ([codempleado])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([codcategoria])
REFERENCES [dbo].[Categoria] ([codcategoria])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([codproveedor])
REFERENCES [dbo].[Proveedores] ([codproveedor])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([codproducto])
REFERENCES [dbo].[Productos] ([codproducto])
GO
/****** Object:  StoredProcedure [dbo].[agregarcategoria]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarcategoria]
@b int, @codcategoria int, @nombrecat varchar (15), @Descrpcion varchar (50)
AS
BEGIN
	SET NOCOUNT ON;
	if @b=1
		INSERT INTO categoria  VALUES (@nombrecat, @Descrpcion);
	if @b=2
		SELECT * FROM Categoria
		
	if @b=3
		DELETE FROM Categoria WHERE codcategoria=@codcategoria;

	if @b=4
		UPDATE Categoria SET nombrecat=@nombrecat, Descrpcion=@Descrpcion where codcategoria=@codcategoria;
	
	if @b=5
	select * from Categoria
	WHERE nombrecat LIKE '%' + @nombrecat + '%';
   
END 


GO
/****** Object:  StoredProcedure [dbo].[Agregarcliente]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Agregarcliente]
@b int, @codcliente  int, @cedulacl varchar (14), @nombrescli varchar (50), @apellidos varchar (50),  @direccion varchar (50), @telefono varchar (10), @correo_cli varchar (80)
AS
BEGIN
 SET NOCOUNT ON;
	IF @b=1
		INSERT INTO Clientes VALUES (@cedulacl, @nombrescli, @apellidos, @direccion,  @telefono, @correo_cli);
	
	IF @b=2
		SELECT * FROM Clientes
		
	IF @b=3
		DELETE FROM Clientes WHERE codcliente=@codcliente;

	IF @b=4
	UPDATE Clientes SET cedulacl=@cedulacl, nombrescli=@nombrescli, apellidos=@apellidos, telefono=@telefono, direccion=@direccion where codcliente = @codcliente;
	
	if @B=5
	select * from Clientes
	Where  nombrescli like '%' + @nombrescli + '%' OR apellidos LIKE '%' + @apellidos + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[agregarempleados]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarempleados]
@b int, @codempleado int, @cedulaempleado varchar (15), @nombre_emple varchar (30), @apellidoemple varchar (30), @telefonoempl varchar (11), @direccionempl varchar (50), @correoemple varchar (50)
as
begin
	SET NOCOUNT ON;
	if @b=1
		INSERT INTO Empleados VALUES (@cedulaempleado, @nombre_emple, @apellidoemple, @telefonoempl, @direccionempl, @correoemple);
	if @b=2
		SELECT * FROM Empleados
		
	if @b=3
		DELETE FROM Empleados WHERE codempleado=@codempleado;

	if @b=4
		UPDATE Empleados SET cedulaempleado=@cedulaempleado, nombre_emple=@nombre_emple, apellidoemple=@apellidoemple, telefonoempl=@telefonoempl, direccionempl=@direccionempl, correoemple=@correoemple where codempleado=@codempleado;
	
	if @b=5
	select * from Empleados
	WHERE nombre_emple LIKE '%' + @nombre_emple + '%' OR apellidoemple LIKE '%' + @apellidoemple + '%';
   
END 

GO
/****** Object:  StoredProcedure [dbo].[agregarfacturas]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarfacturas]
@b int, @idFactura int, @fechafactura datetime, @codcliente int, @codempleado int
as
begin
	SET NOCOUNT ON;
	if @b=1
		INSERT INTO Factura VALUES (@fechafactura, @codcliente, @codempleado);
	if @b=2
		SELECT * FROM Factura

	if @b=3
		select * from Factura
		where idFactura = @idFactura;

END

GO
/****** Object:  StoredProcedure [dbo].[agregarproductos]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarproductos]
@b int, @codproducto int, @producto varchar(100), @precio int, @existencia int, @codcategoria int,
@codproveedor int
AS
BEGIN
	SET NOCOUNT ON;
	IF @b=1
		insert into Productos VALUES (@producto, @precio, @existencia,@codcategoria,@codproveedor);

	if @b=2
		select * from Productos;
	
	if @b=3
		delete from Productos where codproducto=@codproducto;

	if @b=4
	UPDATE Productos  SET producto=@producto, precio = @precio, existencia=@existencia where codproducto=@codproducto;

	if @b=5
	select * from Productos
	where producto LIKE '%' + @producto + '%';

end
GO
/****** Object:  StoredProcedure [dbo].[agregarproveedor]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[agregarproveedor]
@b int, @codproveedor  int, @ruc varchar (20), @nombreprov varchar (50), @telefono varchar (11), @direccion varchar (50), @correoprov varchar (50)
AS
BEGIN
 SET NOCOUNT ON;
	IF @b=1
		INSERT INTO Proveedores VALUES (@ruc, @nombreprov, @telefono, @direccion, @correoprov);
	IF @b=2
		SELECT * FROM Proveedores
		
	IF @b=3
		DELETE FROM Proveedores WHERE codproveedor=@codproveedor;
	IF @b=4
	UPDATE Proveedores SET ruc=@ruc, nombreprov=@nombreprov, telefono=@telefono, direccion=@direccion where codproveedor=@codproveedor;
	if @B=5
	select * from Proveedores
	Where nombreprov LIKE '%' + @nombreprov + '%';
END


GO
/****** Object:  StoredProcedure [dbo].[agregarventas]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarventas]
@b int, @codventa int, @cantidad int, @precio int, @codproducto int, @idFactura int
as
begin
	set nocount on;
	if @b=1
		insert into Ventas values (@cantidad, @precio, @codproducto, @idFactura);

		UPDATE Productos SET existencia = existencia - @cantidad
		WHERE codproducto = @codproducto;

	if @b=2
		select * from Ventas
	if @b=3
		select * from Ventas
		where codventa = @codventa;

end
GO
/****** Object:  StoredProcedure [dbo].[RespaldoBD_Inventario]    Script Date: 21/08/2019 2:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RespaldoBD_Inventario]
as
begin
	SET NOCOUNT ON;
	BACKUP DATABASE [SistemaDeInventario]
	TO DISK = N'C:\respaldo\rSistemaDeInventario.bak'
	with checksum;

end



GO
