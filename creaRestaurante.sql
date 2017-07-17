-- Elimina las tablas existentes
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
	Correo varchar(15) NOT NULL,
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
	FechaApertura date NOT NULL,
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
	Descripción varchar(100) NULL,
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
	IdSucursal int NOT NULL,
	TiempoReal bit NOT NULL,
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
	CedulaCliente varchar(10) NOT NULL,
	Cancelada bit NOT NULL
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
