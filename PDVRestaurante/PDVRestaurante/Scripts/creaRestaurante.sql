-- Elimina las tablas existentes
IF OBJECT_ID('AuditEmpleado', 'U') IS NOT NULL 
   DROP TABLE AuditEmpleado; 

IF OBJECT_ID('AuditPersona', 'U') IS NOT NULL 
   DROP TABLE AuditPersona; 

IF OBJECT_ID('AuditUsuario', 'U') IS NOT NULL 
  DROP TABLE AuditUsuario; 

IF OBJECT_ID('AuditSucursal', 'U') IS NOT NULL 
  DROP TABLE AuditSucursal; 

IF OBJECT_ID('AuditCliente', 'U') IS NOT NULL 
  DROP TABLE AuditCliente; 

IF OBJECT_ID('AuditFactura', 'U') IS NOT NULL 
  DROP TABLE AuditFactura; 

IF OBJECT_ID('AuditInventario', 'U') IS NOT NULL 
  DROP TABLE AuditInventario; 

IF OBJECT_ID('TelefonoSucursal', 'U') IS NOT NULL 
  DROP TABLE TelefonoSucursal; 

IF OBJECT_ID('Inventario_Ingredientes', 'U') IS NOT NULL 
  DROP TABLE Inventario_Ingredientes; 

IF OBJECT_ID('Plato_Ingredientes', 'U') IS NOT NULL 
  DROP TABLE Plato_Ingredientes; 

IF OBJECT_ID('Platos_Factura', 'U') IS NOT NULL 
  DROP TABLE Platos_Factura; 

IF OBJECT_ID('Mesa_Factura', 'U') IS NOT NULL 
  DROP TABLE Mesa_Factura; 

IF OBJECT_ID('Empleados_Factura', 'U') IS NOT NULL 
  DROP TABLE Empleados_Factura; 

IF OBJECT_ID('OrdenCompra_Ingrediente', 'U') IS NOT NULL 
  DROP TABLE OrdenCompra_Ingrediente; 

IF OBJECT_ID('TelefonosPersona', 'U') IS NOT NULL 
  DROP TABLE TelefonosPersona; 

IF OBJECT_ID('CorreosPersona', 'U') IS NOT NULL 
  DROP TABLE CorreosPersona; 

IF OBJECT_ID('DireccionesPersona', 'U') IS NOT NULL 
  DROP TABLE DireccionesPersona; 

IF OBJECT_ID('Usuario', 'U') IS NOT NULL 
  DROP TABLE Usuario; 

IF OBJECT_ID('TipoUsuario', 'U') IS NOT NULL 
  DROP TABLE TipoUsuario; 

IF OBJECT_ID('Inventario', 'U') IS NOT NULL 
  DROP TABLE Inventario; 

IF OBJECT_ID('Plato', 'U') IS NOT NULL 
  DROP TABLE Plato; 

IF OBJECT_ID('Ingrediente', 'U') IS NOT NULL 
  DROP TABLE Ingrediente; 

IF OBJECT_ID('Factura', 'U') IS NOT NULL 
  DROP TABLE Factura; 

IF OBJECT_ID('OrdenCompra', 'U') IS NOT NULL 
  DROP TABLE OrdenCompra; 

IF OBJECT_ID('Cliente', 'U') IS NOT NULL 
  DROP TABLE Cliente; 

IF OBJECT_ID('Proveedor', 'U') IS NOT NULL 
  DROP TABLE Proveedor; 

IF OBJECT_ID('PersonaJuridica', 'U') IS NOT NULL 
  DROP TABLE PersonaJuridica; 

IF OBJECT_ID('PersonaFisica', 'U') IS NOT NULL 
  ALTER TABLE PersonaFisica DROP CONSTRAINT FK01_PerFisica_Persona;

IF OBJECT_ID('Persona', 'U') IS NOT NULL 
  DROP TABLE Persona; 

IF OBJECT_ID('Empleado', 'U') IS NOT NULL BEGIN
  ALTER TABLE Empleado DROP CONSTRAINT FK01_Empleado_PerFisica;
  ALTER TABLE Empleado DROP CONSTRAINT FK02_Empleado_Sucursal;
END

IF OBJECT_ID('PersonaFisica', 'U') IS NOT NULL 
  DROP TABLE PersonaFisica; 

IF OBJECT_ID('Sucursal', 'U') IS NOT NULL 
  DROP TABLE Sucursal; 

IF OBJECT_ID('Empleado', 'U') IS NOT NULL 
  DROP TABLE Empleado; 

IF OBJECT_ID('Distrito', 'U') IS NOT NULL 
  DROP TABLE Distrito; 

IF OBJECT_ID('Canton', 'U') IS NOT NULL 
  DROP TABLE Canton; 

IF OBJECT_ID('Provincia', 'U') IS NOT NULL 
  DROP TABLE Provincia; 

-- Crea las tablas
CREATE TABLE Persona (
	Cedula varchar(10) NOT NULL,
	TipoP char(1),
	CONSTRAINT PK_Persona PRIMARY KEY (Cedula)
)

CREATE TABLE PersonaJuridica (
	CodPerJuridica varchar(10) NOT NULL,
	Nombre varchar(30) NOT NULL,
	FechaApertura date NOT NULL,
	CONSTRAINT PK_PerJuridica PRIMARY KEY (CodPerJuridica),
	CONSTRAINT FK01_PerJuridica_Persona FOREIGN KEY (CodPerJuridica) REFERENCES Persona(Cedula)
)

CREATE TABLE PersonaFisica (
	CodPerFisica varchar(10) NOT NULL,
	Nombre1 varchar(30) NOT NULL,
	Nombre2 varchar(30) NULL,
	Apellido1 varchar(30) NOT NULL,
	Apellido2 varchar(30) NULL,
	Sexo char NOT NULL,
	EstadoCivil varchar(20) NULL,
	FechaNacimiento date NOT NULL,
	CONSTRAINT PK_PerFisica PRIMARY KEY (CodPerFisica),
	CONSTRAINT FK01_PerFisica_Persona FOREIGN KEY (CodPerFisica) REFERENCES Persona(Cedula)
)

CREATE TABLE Provincia (
	IdProvincia int NOT NULL,
	Descripcion varchar(100) NULL,
	CONSTRAINT PK_Provincia PRIMARY KEY (IdProvincia)
)

CREATE TABLE Canton (
	IdProvincia int NOT NULL,
	IdCanton int NOT NULL,
	Descripcion varchar(100) NULL,
	CONSTRAINT PK_Canton PRIMARY KEY (IdProvincia, IdCanton),
	CONSTRAINT FK01_Canton_Provincia FOREIGN KEY (IdProvincia) REFERENCES Provincia(IdProvincia)
)

CREATE TABLE Distrito (
	IdProvincia int NOT NULL,
	IdCanton int NOT NULL,
	IdDistrito int NOT NULL,
	Descripcion varchar(100) NULL,
	CONSTRAINT PK_Distrito PRIMARY KEY (IdProvincia, IdCanton, IdDistrito),
	CONSTRAINT FK01_Distrito_PrvncCntn FOREIGN KEY (IdProvincia, IdCanton) REFERENCES Canton(IdProvincia, IdCanton)
)

CREATE TABLE TelefonosPersona (
	Cedula varchar(10) NOT NULL,
	Tipo varchar(15) NOT NULL,
	Numero varchar(15) NOT NULL,
	CONSTRAINT PK_TelefonosPersona PRIMARY KEY (Cedula, Tipo),
	CONSTRAINT FK01_TelsPersona_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula)
)

CREATE TABLE CorreosPersona (
	Cedula varchar(10) NOT NULL,
	Tipo varchar(15) NOT NULL,
	Correo varchar(100) NOT NULL,
	CONSTRAINT PK_CorreosPersona PRIMARY KEY (Cedula, Tipo),
	CONSTRAINT FK01_CorreosPersona_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula)
)

CREATE TABLE DireccionesPersona (
	Cedula varchar(10) NOT NULL,
	Tipo varchar(15) NOT NULL,
	IdDistrito int NOT NULL,
	IdCanton int NOT NULL,
	IdProvincia int NOT NULL,
	Detalle varchar(100) NULL,
	CONSTRAINT PK_DireccionesPersona PRIMARY KEY (Cedula, Tipo),
	CONSTRAINT FK01_DirsPersona_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula),
	CONSTRAINT FK02_DirsPersona_Distrito FOREIGN KEY (IdProvincia, IdCanton, IdDistrito) REFERENCES Distrito(IdProvincia, IdCanton, IdDistrito)
)

CREATE TABLE Empleado(
	Cedula varchar(10) NOT NULL,
	TipoE varchar(15) NOT NULL,
	Salario numeric(18,2) NOT NULL,
	IdSucursal int NOT NULL,
	FechaInicio date NOT NULL
	CONSTRAINT PK_Empleado PRIMARY KEY (Cedula),
	CONSTRAINT FK01_Empleado_PerFisica FOREIGN KEY (Cedula) REFERENCES PersonaFisica(CodPerFisica),
)

CREATE TABLE Sucursal (
	IdSucursal int NOT NULL,
	FechaApertura date NULL,
	IdDistrito int NOT NULL,
	IdCanton int NOT NULL,
	IdProvincia int NOT NULL,
	IdGerente varchar(10) NULL,
	FechaInicio date NULL,
	Detalle varchar(100) NULL,
	CONSTRAINT PK_Sucursal PRIMARY KEY (IdSucursal),
	CONSTRAINT FK01_Sucursal_Distrito FOREIGN KEY (IdProvincia, IdCanton, IdDistrito) REFERENCES Distrito(IdProvincia, IdCanton, IdDistrito),
	CONSTRAINT FK02_Sucursal_Empleado FOREIGN KEY (IdGerente) REFERENCES Empleado(Cedula)
)
ALTER TABLE EMPLEADO ADD CONSTRAINT FK02_Empleado_Sucursal FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal)

CREATE TABLE TipoUsuario (
	IdTipoUsuario int NOT NULL,
	Nombre varchar(20) NOT NULL,
	CONSTRAINT PK_TipoUsuario PRIMARY KEY (IdTipoUsuario),
)

CREATE TABLE Usuario (
	Nombre varchar(20) NOT NULL,
	Contrasena varchar(50) NOT NULL,
	Salt varchar(25) NOT NULL,
	IdEmpleado varchar(10) NOT NULL,
	IdTipoUsuario int NOT NULL,
	CONSTRAINT PK_Usuario PRIMARY KEY (Nombre),
	CONSTRAINT UN_NombreUsuario UNIQUE(Nombre),
	CONSTRAINT FK01_Usuario_TipoUsuario FOREIGN KEY (IdTipoUsuario) REFERENCES TipoUsuario(IdTipoUsuario),
	CONSTRAINT FK02_Usuario_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(Cedula)
)

CREATE TABLE Cliente (
	Cedula varchar(10) NOT NULL,
	Frecuente bit NOT NULL,
	CONSTRAINT PK_Cliente PRIMARY KEY (Cedula),
	CONSTRAINT FK01_Cliente_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula),
)

CREATE TABLE Proveedor (
	Cedula varchar(10) NOT NULL,
	Descripcion varchar(100) NULL,
	CONSTRAINT PK_Proveedor PRIMARY KEY (Cedula),
	CONSTRAINT FK01_Proveedor_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula),
)

CREATE TABLE TelefonoSucursal (
	IdSucursal int NOT NULL,
	Telefono varchar(15) NOT NULL
	CONSTRAINT PK_TelefonoSucursal PRIMARY KEY (IdSucursal, Telefono),
	CONSTRAINT FK01_TelSucursal_Sucursal FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal),
)

CREATE TABLE Inventario (
	IdInventario int NOT NULL,
	Fecha date NOT NULL,
	IdSucursal int NOT NULL
	CONSTRAINT PK_Inventario PRIMARY KEY (IdInventario),
	CONSTRAINT FK01_Inventario_Sucursal FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal)
)

CREATE TABLE Ingrediente (
	IdIngrediente int NOT NULL,
	Nombre varchar(40) NOT NULL
	CONSTRAINT PK_Ingrediente PRIMARY KEY (IdIngrediente),
)

CREATE TABLE Plato (
	IdPlato int NOT NULL,
	Nombre varchar(40) NOT NULL,
	Descripcion varchar(100) NULL,
	Precio numeric(18,2) NOT NULL
	CONSTRAINT PK_Plato PRIMARY KEY (IdPlato),
)

CREATE TABLE Inventario_Ingredientes (
	IdInventario int NOT NULL,
	IdIngrediente int NOT NULL,
	Existencias int NOT NULL
	CONSTRAINT PK_InvenIngredientes PRIMARY KEY (IdInventario, IdIngrediente),
	CONSTRAINT FK01_InvenIngredientes_Inventario FOREIGN KEY (IdInventario) REFERENCES Inventario(IdInventario),
	CONSTRAINT FK02_InvenIngredientes_Ingrediente FOREIGN KEY (IdIngrediente) REFERENCES Ingrediente(IdIngrediente)
)

CREATE TABLE Plato_Ingredientes (
	IdPlato int NOT NULL,
	IdIngrediente int NOT NULL,
	Cantidad int NOT NULL
	CONSTRAINT PK_PlatoIngredientes PRIMARY KEY (IdPlato, IdIngrediente),
	CONSTRAINT FK01_PlatoIngredientes_Plato FOREIGN KEY (IdPlato) REFERENCES Plato(IdPlato),
	CONSTRAINT FK02_PlatoIngredientes_Ingrediente FOREIGN KEY (IdIngrediente) REFERENCES Ingrediente(IdIngrediente)
)

CREATE TABLE Factura (
	IdFactura int NOT NULL,
	Fecha date NOT NULL,
	Monto numeric(18,2) NOT NULL,
	TipoPago varchar(20) NOT NULL,
	CedulaCliente varchar(10) NOT NULL
	CONSTRAINT PK_Factura PRIMARY KEY (IdFactura),
	CONSTRAINT FK01_Factura_Cliente FOREIGN KEY (CedulaCliente) REFERENCES Cliente(Cedula)
)

CREATE TABLE Platos_Factura (
	IdFactura int NOT NULL,
	IdPlato int NOT NULL,
	Cantidad int NOT NULL,
	CONSTRAINT PK_PlatosFactura PRIMARY KEY (IdFactura, IdPlato),
	CONSTRAINT FK01_PlatosFactura_Factura FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura),
	CONSTRAINT FK02_PlatosFactura_Plato FOREIGN KEY (IdPlato) REFERENCES Plato(IdPlato)
)

CREATE TABLE Mesa_Factura (
	IdFactura int NOT NULL,
	NumeroMesa int NOT NULL
	CONSTRAINT PK_MesaFactura PRIMARY KEY (IdFactura, NumeroMesa),
	CONSTRAINT FK01_MesaFactura_Factura FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura)
)

CREATE TABLE Empleados_Factura (
	IdFactura int NOT NULL,
	CedulaEmpleado varchar(10) NOT NULL,
	CONSTRAINT PK_EmpleadosFactura PRIMARY KEY (IdFactura, CedulaEmpleado),
	CONSTRAINT FK01_EmpleadosFactura_Factura FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura),
	CONSTRAINT FK02_EmpleadosFactura_Empleados FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula)
)

CREATE TABLE OrdenCompra (
	IdCompra int NOT NULL,
	Fecha date NOT NULL,
	CedulaEmpleado varchar(10) NOT NULL,
	CedulaProveedor varchar(10) NOT NULL
	CONSTRAINT PK_OrdenCompra PRIMARY KEY (IdCompra),
	CONSTRAINT FK01_OrdenCompra_Empleado FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula),
	CONSTRAINT FK02_OrdenCompra_Proveedor FOREIGN KEY (CedulaProveedor) REFERENCES Proveedor(Cedula)
)

CREATE TABLE OrdenCompra_Ingrediente (
	IdCompra int NOT NULL,
	IdIngrediente int NOT NULL,
	MontoUnitario numeric(18,2) NOT NULL,
	Cantidad int NOT NULL,
	CONSTRAINT PK_OrdnCompraIngrediente PRIMARY KEY (IdCompra, IdIngrediente),
	CONSTRAINT FK01_OrdnCompraIngrediente_OrdenCompra FOREIGN KEY (IdCompra) REFERENCES OrdenCompra(IdCompra),
	CONSTRAINT FK02_OrdnCompraIngrediente_Ingrediente FOREIGN KEY (IdIngrediente) REFERENCES Ingrediente(IdIngrediente)
)


-- TRIGGERS
-- USUARIO

CREATE TABLE AuditUsuario(
	Usuario		varchar(100),
	Fecha		date,
	Tipo		char(1),
	NewUsuario  varchar(100),
	OldUsuario  varchar(100)
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaUsuario')
	DROP TRIGGER dbo.AuditaUsuario
GO
CREATE TRIGGER dbo.AuditaUsuario
	ON Usuario
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vNew	varchar(20),
			@vOld	varchar(20);
	
	SET  @vNew = (SELECT Nombre FROM inserted);
	SET  @vOld = (SELECT Nombre FROM deleted);
	
	INSERT INTO AuditUsuario(Usuario, Fecha, Tipo, NewUsuario, OldUsuario)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vNew, @vOld;

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOld = (SELECT Nombre FROM deleted);
	INSERT INTO AuditUsuario(Usuario, Fecha, Tipo, OldUsuario)
	SELECT SYSTEM_USER, GETDATE(), 'D', @vOld
END ELSE BEGIN
-- INSERT
	SET  @vNew = (SELECT Nombre FROM inserted);
	INSERT INTO AuditUsuario(Usuario, Fecha, Tipo, NewUsuario)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNew
END
go
-- FACTURA
CREATE TABLE AuditFactura(
	Usuario			varchar(100),
	Fecha			date,
	Tipo			char(1),
	NewTipoPago		varchar(20),
	OldTipoPago		varchar(20),
	NewCliente		varchar(10),
	OldCliente		varchar(10),
	NewMonto		numeric(18,2),
	OldMonto		numeric(18,2),
	NewFecha		date,
	OldFecha		date
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaFactura')
	DROP TRIGGER dbo.AuditaFactura
GO

CREATE TRIGGER dbo.AuditaFactura
	ON Factura
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vNewTipoPago	varchar(20),
			@vOldTipoPago	varchar(20),
			@vNewCliente	varchar(10),
			@vOldCliente	varchar(10),
			@vNewMonto		numeric(18,2),
			@vOldMonto		numeric(18,2),
			@vNewFecha		date,
			@vOldFecha		date
	
	SET  @vNewTipoPago = (SELECT TipoPago FROM inserted);
	SET  @vNewCliente = (SELECT CedulaCliente FROM inserted);
	SET  @vNewMonto = (SELECT Monto FROM inserted);
	SET  @vNewFecha = (SELECT Fecha FROM inserted);
	SET  @vOldTipoPago = (SELECT TipoPago FROM deleted);
	SET  @vOldCliente = (SELECT CedulaCliente FROM deleted);
	SET  @vOldMonto = (SELECT Monto FROM deleted);
	SET  @vOldFecha = (SELECT Fecha FROM deleted);

	
	INSERT INTO AuditFactura(Usuario, Fecha, Tipo, NewTipoPago, OldTipoPago, NewCliente, OldCliente, NewMonto, OldMonto, NewFecha, OldFecha)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vNewTipoPago, @vOldTipoPago, @vNewCliente, @vOldCliente, @vNewMonto, @vOldMonto, @vNewFecha, @vOldFecha

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOldTipoPago = (SELECT TipoPago FROM deleted);
	SET  @vOldCliente = (SELECT CedulaCliente FROM deleted);
	SET  @vOldMonto = (SELECT Monto FROM deleted);
	SET  @vOldFecha = (SELECT Fecha FROM deleted);
	INSERT INTO AuditFactura(Usuario, Fecha, Tipo, OldTipoPago, OldCliente,OldMonto, OldFecha)
	SELECT SYSTEM_USER, GETDATE(), 'D',  @vOldTipoPago,@vOldCliente, @vOldMonto, @vOldFecha
END ELSE BEGIN
-- INSERT
	SET  @vNewTipoPago = (SELECT TipoPago FROM inserted);
	SET  @vNewCliente = (SELECT CedulaCliente FROM inserted);
	SET  @vNewMonto = (SELECT Monto FROM inserted);
	SET  @vNewFecha = (SELECT Fecha FROM inserted);
	INSERT INTO AuditFactura(Usuario, Fecha, Tipo, NewTipoPago, NewCliente, NewMonto, NewFecha)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewTipoPago, @vNewCliente, @vNewMonto, @vNewFecha
END
GO

-- CLIENTE
CREATE TABLE AuditCliente(
	Usuario			varchar(100),
	Fecha			date,
	Tipo			char(1),
	NewFrecuente	bit,
	OldFrecuente	bit,
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaCliente')
	DROP TRIGGER dbo.AuditaCliente
GO

CREATE TRIGGER dbo.AuditaCliente
	ON Cliente
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vOldFrecuente	bit,
			@vNewFrecuente	bit;
	
	SET  @vNewFrecuente = (SELECT frecuente FROM inserted);
	SET  @vOldFrecuente = (SELECT frecuente FROM deleted);
	
	INSERT INTO AuditCliente(Usuario, Fecha, Tipo, OldFrecuente, NewFrecuente)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vOldFrecuente, @vNewFrecuente

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOldFrecuente = (SELECT frecuente FROM deleted);
	INSERT INTO AuditCliente(Usuario, Fecha, Tipo, OldFrecuente)
	SELECT SYSTEM_USER, GETDATE(), 'D', @vOldFrecuente
END ELSE BEGIN
-- INSERT
	SET  @vNewFrecuente = (SELECT frecuente FROM inserted);
	INSERT INTO AuditCliente(Usuario, Fecha, Tipo, NewFrecuente)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewFrecuente
END
GO

-- Inventario
CREATE TABLE AuditInventario(
	Usuario			varchar(100),
	Fecha			date,
	Tipo			char(1),
	NewFecha		date,
	OldFecha		date
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaInventario')
	DROP TRIGGER dbo.AuditaInventario
GO

CREATE TRIGGER dbo.AuditaInventario
	ON Inventario
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vNewFecha		date,
			@vOldFecha		date

	SET  @vNewFecha = (SELECT fecha FROM inserted);
	SET  @vOldFecha = (SELECT fecha FROM deleted);

	INSERT INTO AuditInventario(Usuario, Fecha, Tipo, NewFecha, OldFecha)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vNewFecha, @vOldFecha

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOldFecha = (SELECT fecha FROM deleted);
	INSERT INTO AuditInventario(Usuario, Fecha, Tipo, OldFecha)
	SELECT SYSTEM_USER, GETDATE(), 'D', @vOldFecha
END ELSE BEGIN
-- INSERT
	SET  @vNewFecha = (SELECT fecha FROM inserted);
	INSERT INTO AuditInventario(Usuario, Fecha, Tipo, NewFecha)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewFecha
END
GO

-- Empleado
CREATE TABLE AuditEmpleado(
	Usuario			varchar(100),
	Fecha			date,
	Tipo			char(1),
	OldSalario		numeric(18,2),
	OldTipoE		varchar(15),
	OldSucursal		int,
	NewSalario		numeric(18,2),
	NewTipoE		varchar(15),
	NewSucursal		int
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaEmpleado')
	DROP TRIGGER dbo.AuditaEmpleado
GO

CREATE TRIGGER dbo.AuditaEmpleado
	ON Empleado
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vOldSalario	numeric(18,2),
			@vOldTipoE		varchar(15),
			@vOldSucursal	int,
			@vNewSalario	numeric(18,2),
			@vNewTipoE		varchar(15),
			@vNewSucursal	int;

	SET @vOldSalario	= (select Salario from deleted)
	SET @vOldTipoE		= (select TipoE from deleted)
	SET @vOldSucursal	= (select IdSucursal from deleted)
	SET @vNewSalario	= (select Salario from inserted)
	SET @vNewTipoE		= (select TipoE from inserted)
	SET @vNewSucursal	= (select IdSucursal from inserted)

	INSERT INTO AuditEmpleado(Usuario, Fecha, Tipo, OldSalario, OldTipoE,OldSucursal,NewSalario,NewTipoE,NewSucursal)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vOldSalario, @vOldTipoE, @vOldSucursal, @vNewSalario, @vNewTipoE, @vNewSucursal 

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET @vOldSalario	= (select Salario from deleted)
	SET @vOldTipoE		= (select TipoE from deleted)
	SET @vOldSucursal	= (select IdSucursal from deleted)
	INSERT INTO AuditEmpleado(Usuario, Fecha, Tipo, OldSalario, OldTipoE,OldSucursal)
	SELECT SYSTEM_USER, GETDATE(), 'D', @vOldSalario, @vOldTipoE, @vOldSucursal
END ELSE BEGIN
-- INSERT
	SET @vNewSalario	= (select Salario from inserted)
	SET @vNewTipoE		= (select TipoE from inserted)
	SET @vNewSucursal	= (select IdSucursal from inserted)
	INSERT INTO AuditEmpleado(Usuario, Fecha, Tipo, NewSalario,NewTipoE,NewSucursal)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewSalario, @vNewTipoE, @vNewSucursal 
END
GO


-- SUCURSAL

CREATE TABLE AuditSucursal(
	Usuario		varchar(100),
	Fecha		date,
	Tipo		char(1),
	NewDetalle  varchar(100),
	OldDetalle  varchar(100),
	NewGerente varchar(10),
	OldGerente varchar(10)
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaSucursal')
	DROP TRIGGER dbo.AuditaSucursal
GO

CREATE TRIGGER dbo.AuditaSucursal
	ON Sucursal
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vNewDetalle	varchar(100),
			@vOldDetalle	varchar(100),
			@vNewGerente	varchar(10),
			@vOldGerente	varchar(10);
	
	SET  @vNewDetalle = (SELECT detalle FROM inserted);
	SET  @vOldDetalle = (SELECT detalle FROM deleted);
	SET  @vNewGerente = (SELECT idgerente FROM inserted);
	SET  @vOldGerente = (SELECT idgerente FROM deleted);
	
	INSERT INTO AuditSucursal(Usuario, Fecha, Tipo, NewDetalle, OldDetalle)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vNewDetalle, @vOldDetalle;

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOldDetalle = (SELECT detalle FROM deleted);
	SET  @vOldGerente = (SELECT idgerente FROM deleted);
	INSERT INTO AuditSucursal( Usuario,     Fecha,     Tipo, OldDetalle,   OldGerente)
	SELECT                     SYSTEM_USER, GETDATE(), 'D',  @vOldDetalle, @vOldGerente
END ELSE BEGIN
-- INSERT
	SET  @vNewDetalle = (SELECT detalle FROM inserted);
	SET  @vNewGerente = (SELECT idgerente FROM inserted);
	INSERT INTO AuditSucursal(Usuario, Fecha, Tipo, NewDetalle, NewGerente)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewDetalle, @vNewGerente
END
GO


-- PERSONA

CREATE TABLE AuditPersona(
	Usuario		varchar(100),
	Fecha		date,
	Tipo		char(1),
	NewTipoP  char(1),
	OldTipoP  char(1),
)

IF EXISTS(SELECT OBJECT_ID FROM sys.triggers WHERE name = 'AuditaPersona')
	DROP TRIGGER dbo.AuditaPersona
GO

CREATE TRIGGER dbo.AuditaPersona
	ON Persona
	AFTER UPDATE, DELETE, INSERT
	AS

IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) BEGIN
-- UPDATE
	DECLARE @vNewTipoP	char(1),
			@vOldTipoP	char(1);
	
	SET  @vNewTipoP = (SELECT TipoP FROM inserted);
	SET  @vOldTipoP = (SELECT TipoP FROM deleted);
	
	INSERT INTO AuditPersona(Usuario, Fecha, Tipo, NewTipoP, OldTipoP)
	SELECT SYSTEM_USER, GETDATE(), 'U', @vNewTipoP, @vOldTipoP;

END ELSE IF EXISTS(SELECT * FROM DELETED) BEGIN
-- DELETE
	SET  @vOldTipoP = (SELECT TipoP FROM deleted);
	INSERT INTO AuditPersona( Usuario,     Fecha,     Tipo, OldTipoP)
	SELECT SYSTEM_USER, GETDATE(), 'D',  @vOldTipoP
END ELSE BEGIN
-- INSERT
	SET  @vNewTipoP = (SELECT TipoP FROM inserted);
	INSERT INTO AuditPersona(Usuario, Fecha, Tipo, NewTipoP)
	SELECT SYSTEM_USER, GETDATE(), 'I', @vNewTipoP
END
GO
