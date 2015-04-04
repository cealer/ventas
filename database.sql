CREATE DATABASE dbVentas
GO
USE [dbVentas]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/03/2015 09:40:54 a.m. ******/
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
/****** Object:  Table [dbo].[Detalles]    Script Date: 28/03/2015 09:40:54 a.m. ******/
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
/****** Object:  Table [dbo].[Empleadoo]    Script Date: 28/03/2015 09:40:54 a.m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 28/03/2015 09:40:54 a.m. ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 28/03/2015 09:40:54 a.m. ******/
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
