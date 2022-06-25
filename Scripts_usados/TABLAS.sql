CREATE TABLE [dbo].[Cuadros]
(
	[Id_Cuadro] VARCHAR(50) NULL,
	[Tipo_Cuadro] VARCHAR(50) NULL,
	[Precio_Cuadro] VARCHAR(50) NULL,
	[Modelo_Bicicleta] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Llantas]
(
	[Id_Llanta] VARCHAR(50) NULL, 
	[Tipo_Llanta] VARCHAR(50) NULL, 
	[Precio_Llanta] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Horquillas]
(
	[Id_Horquilla] VARCHAR(50) NULL, 
	[Tipo_Horquilla] VARCHAR(50) NULL, 
	[Precio_Horquilla] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Componentes]
(
	[Id_Componente] VARCHAR(50) NULL, 
	[Tipo_Componente] VARCHAR(50) NULL, 
	[Precio_Componente] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Colores]
(
	[Id_Color] VARCHAR(50) NULL, 
	[Tipo_Color] VARCHAR(50) NULL, 
	[Precio_Color] VARCHAR(50) NULL
)


CREATE TABLE [dbo].[Login]
(
	[Id_Login]VARCHAR(50) NULL, 
	[Login] VARCHAR(50) NULL, 
	[Password] VARCHAR(50) NULL, 
	[Nombre] VARCHAR(50) NULL, 
	[Tipo_Login] VARCHAR(50) NULL, 
	[Apellidos] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Clientes]
(
	[Id_DNI] VARCHAR(50) NULL, 
	[Nombre] VARCHAR(50) NULL, 
	[Apellido1] VARCHAR(50) NULL, 
	[Apellido2] VARCHAR(50) NULL, 
	[Direccion] VARCHAR(50) NULL, 
	[Telefono] VARCHAR(50) NULL, 
	[Mail] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Registro_Login]
(
	[Nombre_Login_conectado] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Registro_Ventas]
(
	[Id_Factura] VARCHAR(50) NULL, 
	[Vendedor] VARCHAR(50) NULL, 
	[Nombre_Cliente] VARCHAR(50) NULL, 
	[Apellido1_Cliente]VARCHAR(50) NULL, 
	[Apellido2_Cliente] VARCHAR(50) NULL, 
	[Direccion_Cliente] VARCHAR(50) NULL, 
	[Telefono_Cliente] VARCHAR(50) NULL, 
	[Mail_Cliente] VARCHAR(50) NULL, 
	[Fecha_venta] VARCHAR(50) NULL, 
	[Precio_Venta] VARCHAR(50) NULL
)




-- Borrar tablas.
Drop table Cuadros;
Drop table Llantas;
Drop table Horquillas;
Drop table Componentes;
Drop table Colores;
Drop table Login;
Drop table Clientes;
Drop table Registro_Login;
Drop table Registro_Ventas;