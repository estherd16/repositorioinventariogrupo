USE [SistemaDeInventario]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 31/07/2019 2:20 p.m. ******/
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
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([idFactura])
REFERENCES [dbo].[Factura] ([idFactura])
GO
/****** Object:  StoredProcedure [dbo].[agregarcategoria]    Script Date: 31/07/2019 2:20 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Agregarcliente]    Script Date: 31/07/2019 2:20 p.m. ******/
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
	UPDATE Clientes SET cedulacl=@cedulacl, nombrescli=@nombrescli, apellidos=@apellidos, @telefono=@telefono, @direccion=@direccion where codcliente = @codcliente;
	
	if @B=5
	select * from Clientes
	Where codcliente like '%' + @codcliente + '%' OR + cedulacl like '%' + @cedulacl + '%'  OR + nombrescli like '%' + @nombrescli + '%' OR apellidos LIKE '%' + @apellidos + '%';
END

GO
/****** Object:  StoredProcedure [dbo].[agregarempleados]    Script Date: 31/07/2019 2:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------
create procedure [dbo].[agregarempleados]
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
		UPDATE Empleados SET cedulaempleado=@cedulaempleado, nombre_emple=@nombre_emple, apellidoemple=@apellidoemple, telefonoempl=@telefonoempl, direccionempl=@direccionempl where codempleado=@codempleado;
	
	if @b=5
	select * from Empleados
	WHERE codempleado LIKE '%' + @codempleado + '%' OR cedulaempleado LIKE '%' + @cedulaempleado + '%' 
	OR nombre_emple LIKE '%' + @nombre_emple + '%' OR apellidoemple LIKE '%' + @apellidoemple + '%';
   
END 

GO
/****** Object:  StoredProcedure [dbo].[agregarfacturas]    Script Date: 31/07/2019 2:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------
create procedure [dbo].[agregarfacturas]
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
		where idFactura LIKE '%' + @idFactura + '%' OR fechafactura LIKE '%' + @fechafactura + '%' OR codempleado LIKE '%' + @codempleado +'%';

END 

GO
/****** Object:  StoredProcedure [dbo].[agregarproductos]    Script Date: 31/07/2019 2:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------- 
create procedure [dbo].[agregarproductos]
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
	UPDATE Productos  SET producto=@producto, existencia=@existencia where codproducto=@codproducto;

	if @b=5
	select * from Productos
	where codproducto LIKE '%' + @codproducto + '%' OR producto LIKE '%' + @producto + '%';

end

GO
/****** Object:  StoredProcedure [dbo].[agregarproveedor]    Script Date: 31/07/2019 2:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------
create  procedure [dbo].[agregarproveedor]
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
	Where codproveedor like '%' + @codproveedor + '%' OR ruc LIKE '%' + @ruc +'%' OR nombreprov LIKE '%' + @nombreprov + '%';
END

GO
/****** Object:  StoredProcedure [dbo].[agregarventas]    Script Date: 31/07/2019 2:20 p.m. ******/
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
		where codventa LIKE '%' + @codventa + '%';

end
GO
