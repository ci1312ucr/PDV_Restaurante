alter table Usuario drop constraint FK01_Usuario_TipoUsuario;
alter table Usuario drop constraint FK02_Usuario_Empleado;

alter table PersonaJuridica drop constraint FK01_PerJuridica_Persona;

alter table PersonaFisica drop constraint FK01_PerFisica_Persona;

alter table Distrito drop constraint FK01_Distrito_PrvncCntn;

alter table Canton drop constraint FK01_Canton_Provincia;

alter table TelefonosPersona drop constraint FK01_TelsPersona_Persona;

alter table CorreosPersona drop constraint FK01_CorreosPersona_Persona;

alter table DireccionesPersona drop constraint FK01_DirsPersona_Persona;
alter table DireccionesPersona drop constraint FK02_DirsPersona_Distrito;

alter table Empleado drop constraint FK01_Empleado_PerFisica;
alter table Empleado drop constraint FK02_Empleado_Sucursal;

alter table Cliente drop constraint FK01_Cliente_Persona;

alter table Proveedor drop constraint FK01_Proveedor_Persona;

alter table Sucursal drop constraint FK01_Sucursal_Distrito;
alter table Sucursal drop constraint FK02_Sucursal_Empleado

alter table TelefonoSucursal drop constraint FK01_TelSucursal_Sucursal;

alter table Inventario drop constraint FK01_Inventario_Sucursal;

alter table Inventario_Ingredientes drop constraint FK01_InvenIngredientes_Inventario;
alter table Inventario_Ingredientes drop constraint FK02_InvenIngredientes_Ingrediente;

alter table Plato_Ingredientes drop constraint FK01_PlatoIngredientes_Plato;
alter table Plato_Ingredientes drop constraint FK02_PlatoIngredientes_Ingrediente;

alter table Factura drop constraint FK01_Factura_Cliente;

alter table Platos_Factura drop constraint FK01_PlatosFactura_Factura;
alter table Platos_Factura drop constraint FK02_PlatosFactura_Plato;

alter table Mesa_Factura drop constraint FK01_MesaFactura_Factura;

alter table Empleados_Factura drop constraint FK01_EmpleadosFactura_Factura;
alter table Empleados_Factura drop constraint FK02_EmpleadosFactura_Empleados;

alter table OrdenCompra drop constraint FK01_OrdenCompra_Empleado;
alter table OrdenCompra drop constraint FK02_OrdenCompra_Proveedor;

alter table OrdenCompra_Ingrediente drop constraint FK01_OrdnCompraIngrediente_OrdenCompra;
alter table OrdenCompra_Ingrediente drop constraint FK02_OrdnCompraIngrediente_Ingrediente;


drop table Empleado;
drop table Usuario;
drop table TipoUsuario;
drop table TelefonosPersona;
drop table DireccionesPersona;
drop table Distrito;
drop table Canton;
drop table Provincia;
drop table CorreosPersona;
drop table Cliente;
drop table Proveedor;
drop table TelefonoSucursal;
drop table Sucursal;
drop table Inventario;
drop table Plato;
drop table Ingrediente;
drop table Inventario_Ingredientes;
drop table Plato_Ingredientes;
drop table Factura;
drop table Platos_Factura;
drop table Mesa_Factura;
drop table Empleados_Factura;
drop table OrdenCompra;
drop table OrdenCompra_Ingrediente;
drop table PersonaJuridica;
drop table PersonaFisica;
drop table Persona;


CREATE TABLE Persona (
	Cedula varchar(10) NOT NULL,
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
	CONSTRAINT PK_DireccionesPersona PRIMARY KEY (Cedula, Tipo, IdProvincia, IdCanton, IdDistrito),
	CONSTRAINT FK01_DirsPersona_Persona FOREIGN KEY (Cedula) REFERENCES Persona(Cedula),
	CONSTRAINT FK02_DirsPersona_Distrito FOREIGN KEY (IdProvincia, IdCanton, IdDistrito) REFERENCES Distrito(IdProvincia, IdCanton, IdDistrito)
)

CREATE TABLE Empleado(
	Cedula varchar(10) NOT NULL,
	Tipo varchar(15) NOT NULL,
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
