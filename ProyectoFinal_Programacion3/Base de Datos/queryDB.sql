set ansi_nulls on
set quoted_identifier on
go

create database GimnasioDB
go

use GimnasioDB
go

-- seguridad

create table roles(
	id_rol int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	descripcion nvarchar(200),
	estado bit NOT NULL DEFAULT 1
)

create table permisos(
	id_permiso int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	descripcion nvarchar(200)
)

create table rol_permiso(
	id_rol int NOT NULL,
	id_permiso int NOT NULL,
	PRIMARY KEY (id_rol, id_permiso),
	FOREIGN KEY (id_rol) REFERENCES roles(id_rol),
	FOREIGN KEY (id_permiso) REFERENCES permisos(id_permiso)
)

create table usuarios(
	id_usuario int PRIMARY KEY IDENTITY(1,1),
	id_rol int NOT NULL,
	nombre_usuario nvarchar(50) NOT NULL UNIQUE,
	clave nvarchar(64) NOT NULL,
	nombre_completo nvarchar(100) NOT NULL,
	correo nvarchar(100),
	fecha_creacion datetime NOT NULL DEFAULT GETDATE(),
	estado bit NOT NULL DEFAULT 1,
	FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
)

-- entrenadores y horarios

create table horarios(
	id_horario int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	dias nvarchar(50) NOT NULL,
	hora_inicio time NOT NULL,
	hora_fin time NOT NULL,
	estado bit NOT NULL DEFAULT 1
)

create table entrenadores(
	id_entrenador int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL,
	apellido nvarchar(50) NOT NULL,
	cedula nvarchar(15) NOT NULL UNIQUE,
	telefono nvarchar(15),
	correo nvarchar(100),
	especialidad nvarchar(100),
	id_horario int NOT NULL,
	estado bit NOT NULL DEFAULT 1,
	FOREIGN KEY (id_horario) REFERENCES horarios(id_horario)
)

-- clientes y membresias

create table clientes(
	id_cliente int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL,
	apellido nvarchar(50) NOT NULL,
	cedula nvarchar(15) NOT NULL UNIQUE,
	telefono nvarchar(15),
	correo nvarchar(100),
	direccion nvarchar(200),
	fecha_nacimiento date,
	sexo char(1) CHECK (sexo IN ('M','F')),
	foto varbinary(max),
	fecha_registro datetime NOT NULL DEFAULT GETDATE(),
	estado bit NOT NULL DEFAULT 1
)

create table membresias(
	id_membresia int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	descripcion nvarchar(200),
	duracion_dias int NOT NULL CHECK (duracion_dias > 0),
	precio decimal(10,2) NOT NULL CHECK (precio >= 0),
	fecha_creacion datetime NOT NULL DEFAULT GETDATE(),
	estado bit NOT NULL DEFAULT 1
)

create table cliente_membresia(
	id_cliente_membresia int PRIMARY KEY IDENTITY(1,1),
	id_cliente int NOT NULL,
	id_membresia int NOT NULL,
	fecha_inicio date NOT NULL,
	fecha_fin date NOT NULL,
	estado nvarchar(20) NOT NULL DEFAULT 'Activa' CHECK (estado IN ('Activa','Vencida','Cancelada')),
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	FOREIGN KEY (id_membresia) REFERENCES membresias(id_membresia),
	CHECK (fecha_fin >= fecha_inicio)
)

-- pagos de membresias

create table pagos(
	id_pago int PRIMARY KEY IDENTITY(1,1),
	fecha datetime NOT NULL DEFAULT GETDATE(),
	id_cliente int NOT NULL,
	id_usuario int NOT NULL,
	metodo_pago nvarchar(20) NOT NULL CHECK (metodo_pago IN ('Efectivo','Tarjeta','Transferencia')),
	monto_total decimal(10,2) NOT NULL CHECK (monto_total >= 0),
	observacion nvarchar(200),
	estado nvarchar(20) NOT NULL DEFAULT 'Completado' CHECK (estado IN ('Completado','Anulado')),
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
)

create table pagos_detalle(
	id_pago_detalle int PRIMARY KEY IDENTITY(1,1),
	id_pago int NOT NULL,
	id_cliente_membresia int,
	concepto nvarchar(100) NOT NULL,
	monto decimal(10,2) NOT NULL CHECK (monto >= 0),
	FOREIGN KEY (id_pago) REFERENCES pagos(id_pago),
	FOREIGN KEY (id_cliente_membresia) REFERENCES cliente_membresia(id_cliente_membresia)
)

-- clases, reservas y asistencia

create table clases(
	id_clase int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL,
	descripcion nvarchar(200),
	id_entrenador int NOT NULL,
	dia_semana nvarchar(15) NOT NULL,
	hora_inicio time NOT NULL,
	hora_fin time NOT NULL,
	cupo_maximo int NOT NULL CHECK (cupo_maximo > 0),
	estado bit NOT NULL DEFAULT 1,
	FOREIGN KEY (id_entrenador) REFERENCES entrenadores(id_entrenador)
)

create table reservas(
	id_reserva int PRIMARY KEY IDENTITY(1,1),
	id_clase int NOT NULL,
	id_cliente int NOT NULL,
	fecha_reserva date NOT NULL,
	fecha_creacion datetime NOT NULL DEFAULT GETDATE(),
	estado nvarchar(20) NOT NULL DEFAULT 'Reservada' CHECK (estado IN ('Reservada','Cancelada','Asistio')),
	FOREIGN KEY (id_clase) REFERENCES clases(id_clase),
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	UNIQUE (id_clase, id_cliente, fecha_reserva)
)

create table asistencia(
	id_asistencia int PRIMARY KEY IDENTITY(1,1),
	id_cliente int NOT NULL,
	fecha datetime NOT NULL DEFAULT GETDATE(),
	id_reserva int,
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	FOREIGN KEY (id_reserva) REFERENCES reservas(id_reserva)
)

-- inventario

create table categorias(
	id_categoria int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	descripcion nvarchar(200),
	estado bit NOT NULL DEFAULT 1
)

create table marcas(
	id_marca int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(50) NOT NULL UNIQUE,
	estado bit NOT NULL DEFAULT 1
)

create table productos(
	id_producto int PRIMARY KEY IDENTITY(1,1),
	codigo nvarchar(20) NOT NULL UNIQUE,
	codigo_barras nvarchar(50),
	nombre nvarchar(100) NOT NULL,
	descripcion nvarchar(200),
	id_categoria int NOT NULL,
	id_marca int NOT NULL,
	precio_compra decimal(10,2) NOT NULL CHECK (precio_compra >= 0),
	precio_venta decimal(10,2) NOT NULL CHECK (precio_venta >= 0),
	stock int NOT NULL DEFAULT 0 CHECK (stock >= 0),
	stock_minimo int NOT NULL DEFAULT 0,
	imagen varbinary(max),
	estado bit NOT NULL DEFAULT 1,
	FOREIGN KEY (id_categoria) REFERENCES categorias(id_categoria),
	FOREIGN KEY (id_marca) REFERENCES marcas(id_marca)
)

-- unico solo cuando tiene codigo, para permitir varios productos sin codigo de barras
create unique index UQ_productos_codigo_barras on productos(codigo_barras) where codigo_barras is not null

create table proveedores(
	id_proveedor int PRIMARY KEY IDENTITY(1,1),
	nombre nvarchar(100) NOT NULL,
	rnc nvarchar(20),
	telefono nvarchar(15),
	correo nvarchar(100),
	direccion nvarchar(200),
	fecha_creacion datetime NOT NULL DEFAULT GETDATE(),
	estado bit NOT NULL DEFAULT 1
)

-- el rnc no se puede repetir, pero si se permite mas de un proveedor sin rnc
create unique index UQ_proveedores_rnc on proveedores(rnc) where rnc is not null

-- ventas (pos)

create table ventas(
	id_venta int PRIMARY KEY IDENTITY(1,1),
	fecha datetime NOT NULL DEFAULT GETDATE(),
	id_cliente int,
	id_usuario int NOT NULL,
	tipo_pago nvarchar(10) NOT NULL CHECK (tipo_pago IN ('Contado','Credito')),
	subtotal decimal(10,2) NOT NULL,
	descuento decimal(10,2) NOT NULL DEFAULT 0,
	impuesto decimal(10,2) NOT NULL DEFAULT 0,
	total decimal(10,2) NOT NULL,
	estado nvarchar(20) NOT NULL DEFAULT 'Completada' CHECK (estado IN ('Completada','Anulada')),
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
)

create table venta_detalle(
	id_detalle int PRIMARY KEY IDENTITY(1,1),
	id_venta int NOT NULL,
	id_producto int NOT NULL,
	cantidad int NOT NULL CHECK (cantidad > 0),
	precio decimal(10,2) NOT NULL,
	descuento decimal(10,2) NOT NULL DEFAULT 0,
	subtotal decimal(10,2) NOT NULL,
	FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
	FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
)

create table cuentas_cobrar(
	id_cuenta int PRIMARY KEY IDENTITY(1,1),
	id_venta int NOT NULL UNIQUE,
	id_cliente int NOT NULL,
	monto_original decimal(10,2) NOT NULL,
	saldo decimal(10,2) NOT NULL CHECK (saldo >= 0),
	fecha_vencimiento date NOT NULL,
	estado nvarchar(20) NOT NULL DEFAULT 'Pendiente' CHECK (estado IN ('Pendiente','Saldada','Vencida')),
	FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
)

create table abonos(
	id_abono int PRIMARY KEY IDENTITY(1,1),
	id_cuenta int NOT NULL,
	fecha datetime NOT NULL DEFAULT GETDATE(),
	monto decimal(10,2) NOT NULL CHECK (monto > 0),
	id_usuario int NOT NULL,
	FOREIGN KEY (id_cuenta) REFERENCES cuentas_cobrar(id_cuenta),
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
)

-- compras

create table compras(
	id_compra int PRIMARY KEY IDENTITY(1,1),
	fecha datetime NOT NULL DEFAULT GETDATE(),
	id_proveedor int NOT NULL,
	id_usuario int NOT NULL,
	numero_factura nvarchar(30),
	subtotal decimal(10,2) NOT NULL,
	impuesto decimal(10,2) NOT NULL DEFAULT 0,
	total decimal(10,2) NOT NULL,
	estado nvarchar(20) NOT NULL DEFAULT 'Completada' CHECK (estado IN ('Completada','Anulada')),
	FOREIGN KEY (id_proveedor) REFERENCES proveedores(id_proveedor),
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
)

create table compra_detalle(
	id_compra_detalle int PRIMARY KEY IDENTITY(1,1),
	id_compra int NOT NULL,
	id_producto int NOT NULL,
	cantidad int NOT NULL CHECK (cantidad > 0),
	precio_compra decimal(10,2) NOT NULL,
	subtotal decimal(10,2) NOT NULL,
	FOREIGN KEY (id_compra) REFERENCES compras(id_compra),
	FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
)

-- configuracion del negocio (una sola fila)

create table configuracion(
	id_configuracion int PRIMARY KEY CHECK (id_configuracion = 1),
	nombre_gimnasio nvarchar(100) NOT NULL,
	rnc nvarchar(20),
	telefono nvarchar(15),
	direccion nvarchar(200),
	correo nvarchar(100),
	porcentaje_impuesto decimal(5,2) NOT NULL DEFAULT 18.00,
	mensaje_recibo nvarchar(200),
	logo varbinary(max)
)
go

-- indices para las consultas mas comunes

create index IX_clientes_nombre on clientes(nombre, apellido)
create index IX_cliente_membresia_cli on cliente_membresia(id_cliente, fecha_fin)
create index IX_pagos_fecha on pagos(fecha)
create index IX_ventas_fecha on ventas(fecha)
create index IX_ventas_cliente on ventas(id_cliente)
create index IX_venta_detalle_venta on venta_detalle(id_venta)
create index IX_cuentas_cobrar_cli on cuentas_cobrar(id_cliente, estado)
create index IX_abonos_cuenta on abonos(id_cuenta)
create index IX_compras_fecha on compras(fecha)
create index IX_asistencia_fecha on asistencia(fecha)
create index IX_reservas_clase on reservas(id_clase, fecha_reserva)
create index IX_productos_nombre on productos(nombre)
go

-- datos iniciales

insert into roles (nombre, descripcion) values
('Administrador', 'Acceso total al sistema'),
('Cajero', 'POS, ventas y cobros'),
('Recepcionista', 'Clientes, membresias, reservas y asistencia')

insert into permisos (nombre, descripcion) values
('USUARIOS', 'Mantenimiento de usuarios y roles'),
('CLIENTES', 'Mantenimiento de clientes'),
('MEMBRESIAS', 'Planes, asignacion y renovacion'),
('PAGOS', 'Registrar pagos y recibos'),
('ENTRENADORES', 'Mantenimiento de entrenadores'),
('CLASES', 'Clases y reservas'),
('PRODUCTOS', 'Productos, categorias y marcas'),
('POS', 'Ventas en el punto de venta'),
('COMPRAS', 'Compras y proveedores'),
('CUENTAS', 'Cuentas por cobrar y abonos'),
('REPORTES', 'Reportes y dashboard'),
('CONFIGURACION', 'Configuracion del sistema')

-- el administrador tiene todos los permisos
insert into rol_permiso (id_rol, id_permiso)
select 1, id_permiso from permisos

insert into rol_permiso (id_rol, id_permiso)
select 2, id_permiso from permisos where nombre in ('POS','PAGOS','CUENTAS','PRODUCTOS')

insert into rol_permiso (id_rol, id_permiso)
select 3, id_permiso from permisos where nombre in ('CLIENTES','MEMBRESIAS','CLASES','PAGOS')

-- usuario admin, contrasena Admin123
insert into usuarios (id_rol, nombre_usuario, clave, nombre_completo, correo)
values (1, 'admin', CONVERT(nvarchar(64), HASHBYTES('SHA2_256', 'Admin123'), 2), 'Administrador del Sistema', 'admin@gimnasio.com')

insert into configuracion (id_configuracion, nombre_gimnasio, porcentaje_impuesto, mensaje_recibo)
values (1, 'Mi Gimnasio', 18.00, 'Gracias por su compra')
go
