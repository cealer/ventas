create database dbVentas
go
USE [dbVentas]
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarEmpleado]
(
	@Original_IdEmpleado int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Empleadoo] WHERE (([IdEmpleado] = @Original_IdEmpleado))
GO
/****** Object:  StoredProcedure [dbo].[pAgregarClientes]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pAgregarClientes]
(
	@Nombres nvarchar(50),
	@Apellidos nvarchar(50),
	@DNI nvarchar(8),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Cliente] ([Nombres], [Apellidos], [DNI], [Direccion], [Telefono]) VALUES (@Nombres, @Apellidos, @DNI, @Direccion, @Telefono)
GO
/****** Object:  StoredProcedure [dbo].[pAgregarDetalle]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pAgregarDetalle]
(
	@IdVenta int,
	@IdProducto int,
	@Cantidad int,
	@Precio numeric(10, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Detalles] ([IdVenta], [IdProducto], [Cantidad], [Precio]) VALUES (@IdVenta, @IdProducto, @Cantidad, @Precio)
GO
/****** Object:  StoredProcedure [dbo].[pAgregarProducto]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pAgregarProducto]
(
	@Descripcion nvarchar(150),
	@Precio numeric(10, 2),
	@Marca nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Producto] ([Descripcion], [Precio], [Marca]) VALUES (@Descripcion, @Precio, @Marca)
GO
/****** Object:  StoredProcedure [dbo].[pAgregarVenta]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pAgregarVenta]
(
	@IdCliente int,
	@IdEmpleado int,
	@Documento nvarchar(7),
	@Serie nvarchar(3),
	@Nro nvarchar(5),
	@Subtotal numeric(10, 2),
	@IGV numeric(5, 2),
	@Total numeric(10, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Ventas] ([IdCliente], [IdEmpleado], [Documento], [Serie], [Nro], [Subtotal], [IGV], [Total]) VALUES (@IdCliente, @IdEmpleado, @Documento, @Serie, @Nro, @Subtotal, @IGV, @Total)
GO
/****** Object:  StoredProcedure [dbo].[pBorrarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBorrarCliente]
(
	@Original_IdCliente int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Cliente] WHERE (([IdCliente] = @Original_IdCliente))
GO
/****** Object:  StoredProcedure [dbo].[pBorrarClientes]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBorrarClientes]
(
	@Original_IdCliente int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Cliente] WHERE (([IdCliente] = @Original_IdCliente))
GO
/****** Object:  StoredProcedure [dbo].[pBorrarProducto]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBorrarProducto]
(
	@Original_IdProducto int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Producto] WHERE (([IdProducto] = @Original_IdProducto))
GO
/****** Object:  StoredProcedure [dbo].[pBuscarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBuscarCliente]
(
	@nom nvarchar(50),
	@ape nvarchar(50),
	@dni nvarchar(8)
)
AS
	SET NOCOUNT ON;
SELECT IdCliente, Nombres, Apellidos, DNI, Direccion, Telefono FROM dbo.Cliente where Nombres like @nom + '%' and Apellidos like @ape + '%' and DNI like @dni + '%'
GO
/****** Object:  StoredProcedure [dbo].[pBuscarEmpleados]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBuscarEmpleados]
(
	@nom nvarchar(50),
	@ape nvarchar(50),
	@dni nvarchar(8)
)
AS
	SET NOCOUNT ON;
SELECT IdEmpleado, Nombre, Apellidos, DNI, Direccion, Telefono FROM dbo.Empleadoo
where Nombre like @nom+ '%' and Apellidos like @ape + '%' and dni like @dni + '%'
GO
/****** Object:  StoredProcedure [dbo].[pBuscarProducto]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBuscarProducto]
(
	@des nvarchar(150),
	@mar nvarchar(150)
)
AS
	SET NOCOUNT ON;
SELECT IdProducto, Descripcion, Precio, Marca FROM dbo.Producto where Descripcion like @des + '%' and Marca like @mar + '%'
GO
/****** Object:  StoredProcedure [dbo].[pBuscarVenta]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pBuscarVenta]
(
	@doc nvarchar(7),
	@serie nvarchar(3),
	@num nvarchar(5)
)
AS
	SET NOCOUNT ON;
SELECT IdVentas, IdCliente, IdEmpleado, Documento, Serie, Nro, Subtotal, IGV, Total FROM dbo.Ventas where Documento like @doc + '%' and Serie like @serie + '%' and Nro like @num + '%'
GO
/****** Object:  StoredProcedure [dbo].[pEliminarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pEliminarCliente]
(
	@Original_IdCliente int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Cliente] WHERE (([IdCliente] = @Original_IdCliente))
GO
/****** Object:  StoredProcedure [dbo].[pGenerarNro]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pGenerarNro](
@doc nvarchar(8)
)
AS
Begin
declare @nr int;
set @nr=(select COUNT(*) from Ventas  where Documento = @doc);
if(@nr>0) begin
select (select Ventas.Nro From Ventas where Documento = @doc)+1;
End
else begin
select 1
end
end

GO
/****** Object:  StoredProcedure [dbo].[pGenerarSerie]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pGenerarSerie](
@doc nvarchar(8)
)
AS
Begin
declare @nr int;
set @nr=(select COUNT(*) from Ventas  where Documento = @doc);
if(@nr>0) begin

select Ventas.Serie From Ventas where Documento = @doc;

End
else begin
select 1
end
end
GO
/****** Object:  StoredProcedure [dbo].[pGuardarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pGuardarCliente]
(
	@Nombres nvarchar(50),
	@Apellidos nvarchar(50),
	@DNI nvarchar(8),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Cliente] ([Nombres], [Apellidos], [DNI], [Direccion], [Telefono]) VALUES (@Nombres, @Apellidos, @DNI, @Direccion, @Telefono)
GO
/****** Object:  StoredProcedure [dbo].[pInsertarClientes]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pInsertarClientes]
(
	@Nombres nvarchar(50),
	@Apellidos nvarchar(50),
	@DNI nvarchar(8),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Cliente
                      (Nombres, Apellidos, DNI, Direccion, Telefono)
VALUES     (@Nombres,@Apellidos,@DNI,@Direccion,@Telefono)
GO
/****** Object:  StoredProcedure [dbo].[pListarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pListarCliente]
(
	@nom nvarchar(50),
	@ape nvarchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     IdCliente, Nombres, Apellidos, DNI, Direccion, Telefono
FROM         Cliente
WHERE     (Nombres LIKE @nom + '%') AND (Apellidos LIKE @ape + '%')
GO
/****** Object:  StoredProcedure [dbo].[pMaxIdVenta]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pMaxIdVenta]
AS
BEGIN
SELECT IdVentas from Ventas where IdVentas = (select MAX(IdVentas) from Ventas);
END;
GO
/****** Object:  StoredProcedure [dbo].[pModificarCliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pModificarCliente]
(
	@Nombres nvarchar(50),
	@Apellidos nvarchar(50),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25),
	@Original_IdCliente int
)
AS
	SET NOCOUNT OFF;
UPDATE    Cliente
SET              Nombres = @Nombres, Apellidos = @Apellidos, Direccion = @Direccion, Telefono = @Telefono
WHERE     (IdCliente = @Original_IdCliente)
GO
/****** Object:  StoredProcedure [dbo].[pModificarEmpleado]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pModificarEmpleado]
(
	@Nombre nvarchar(50),
	@Apellidos nvarchar(50),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25),
	@Original_IdEmpleado int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Empleadoo] SET [Nombre] = @Nombre, [Apellidos] = @Apellidos, [Direccion] = @Direccion, [Telefono] = @Telefono WHERE (([IdEmpleado] = @Original_IdEmpleado))
GO
/****** Object:  StoredProcedure [dbo].[pModificarProducto]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pModificarProducto]
(
	@Descripcion nvarchar(150),
	@Precio numeric(10, 2),
	@Marca nvarchar(50),
	@Original_IdProducto int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Producto] SET [Descripcion] = @Descripcion, [Precio] = @Precio, [Marca] = @Marca WHERE (([IdProducto] = @Original_IdProducto))
GO
/****** Object:  StoredProcedure [dbo].[ProcedimientoAgregarEmpleados]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcedimientoAgregarEmpleados]
(
	@Nombre nvarchar(50),
	@Apellidos nvarchar(50),
	@DNI nvarchar(8),
	@Direccion nvarchar(50),
	@Telefono nvarchar(25)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Empleadoo] ([Nombre], [Apellidos], [DNI], [Direccion], [Telefono]) VALUES (@Nombre, @Apellidos, @DNI, @Direccion, @Telefono)
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 05/06/2015 09:32:23 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[DNI] [nvarchar](8) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](25) NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleGato]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleGato](
	[idGato] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](8, 2) NULL,
 CONSTRAINT [PK_DetalleGato] PRIMARY KEY CLUSTERED 
(
	[idGato] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalles]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles](
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_Detalles] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC,
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleadoo]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleadoo](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[DNI] [nvarchar](8) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](25) NULL,
 CONSTRAINT [PK_Empleadoo] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gato]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gato](
	[idGato] [int] IDENTITY(1,1) NOT NULL,
	[Idventas] [int] NULL,
 CONSTRAINT [PK_Gato] PRIMARY KEY CLUSTERED 
(
	[idGato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](150) NOT NULL,
	[Precio] [numeric](10, 2) NOT NULL,
	[Marca] [nvarchar](50) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 05/06/2015 09:32:24 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVentas] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Documento] [nvarchar](7) NOT NULL,
	[Serie] [nvarchar](3) NOT NULL,
	[Nro] [nvarchar](5) NOT NULL,
	[Subtotal] [numeric](10, 2) NOT NULL,
	[IGV] [numeric](5, 2) NOT NULL,
	[Total] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[IdVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DetalleGato]  WITH CHECK ADD  CONSTRAINT [FK_DetalleGato_Gato] FOREIGN KEY([idGato])
REFERENCES [dbo].[Gato] ([idGato])
GO
ALTER TABLE [dbo].[DetalleGato] CHECK CONSTRAINT [FK_DetalleGato_Gato]
GO
ALTER TABLE [dbo].[DetalleGato]  WITH CHECK ADD  CONSTRAINT [FK_DetalleGato_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleGato] CHECK CONSTRAINT [FK_DetalleGato_Producto]
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Detalles] CHECK CONSTRAINT [FK_Detalles_Producto]
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Ventas] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVentas])
GO
ALTER TABLE [dbo].[Detalles] CHECK CONSTRAINT [FK_Detalles_Ventas]
GO
ALTER TABLE [dbo].[Gato]  WITH CHECK ADD  CONSTRAINT [FK_Gato_Ventas] FOREIGN KEY([Idventas])
REFERENCES [dbo].[Ventas] ([IdVentas])
GO
ALTER TABLE [dbo].[Gato] CHECK CONSTRAINT [FK_Gato_Ventas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Cliente]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleadoo] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleadoo] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleadoo]
GO
