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

-- visitas de clientes sin membresia: se cargan en el check-in y quedan pendientes hasta cobrarse en pagos
create table visitas(
	id_visita int PRIMARY KEY IDENTITY(1,1),
	id_cliente int NOT NULL,
	fecha date NOT NULL DEFAULT CAST(GETDATE() AS date),
	monto decimal(10,2) NOT NULL CHECK (monto >= 0),
	estado nvarchar(20) NOT NULL DEFAULT 'Pendiente' CHECK (estado IN ('Pendiente','Pagada')),
	id_pago int NULL,
	FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
	FOREIGN KEY (id_pago) REFERENCES pagos(id_pago),
	CONSTRAINT UQ_visitas_cliente_fecha UNIQUE (id_cliente, fecha)
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
	monto_visita decimal(10,2) NOT NULL DEFAULT 500.00,
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

insert into configuracion (id_configuracion, nombre_gimnasio, porcentaje_impuesto, monto_visita, mensaje_recibo)
values (1, 'Mi Gimnasio', 18.00, 500.00, 'Gracias por su compra')

-- cliente generico para cobrar las visitas del dia
insert into clientes (nombre, apellido, cedula)
values ('Visitante', 'Del Dia', '000-0000000-0')
go

-- =====================================================================
-- datos de prueba (las fechas son relativas a hoy para que el demo se vea actual)
-- =====================================================================

set xact_abort on
begin transaction

-- usuarios de prueba: cajero / Cajero123 y recepcion / Recepcion123
insert into usuarios (id_rol, nombre_usuario, clave, nombre_completo, correo) values
(2, 'cajero', CONVERT(nvarchar(64), HASHBYTES('SHA2_256', 'Cajero123'), 2), 'Pedro Cajero', 'cajero@gimnasio.com'),
(3, 'recepcion', CONVERT(nvarchar(64), HASHBYTES('SHA2_256', 'Recepcion123'), 2), 'Maria Recepcion', 'recepcion@gimnasio.com')

-- inventario
insert into categorias (nombre, descripcion)
select 'Suplementos', 'Proteinas, creatina y vitaminas' where not exists (select 1 from categorias where nombre = 'Suplementos')

insert into categorias (nombre, descripcion) values
('Bebidas', 'Agua, isotonicas y energeticas'),
('Ropa deportiva', 'Camisetas, shorts y licras'),
('Accesorios', 'Guantes, shakers y correas'),
('Snacks', 'Barras y snacks proteicos')

insert into marcas (nombre) values
('Optimum Nutrition'), ('MuscleTech'), ('Gatorade'), ('Monster'), ('Dasani'), ('Nike'), ('Under Armour'), ('Quest'), ('SmartFit')

insert into proveedores (nombre, rnc, telefono, correo, direccion) values
('Suplementos del Caribe SRL', '131-12345-6', '809-555-1010', 'ventas@suplecaribe.com', 'Av. Estrella Sadhala, Santiago'),
('Bebidas Nacionales SA', '101-98765-4', '809-555-2020', 'pedidos@bebidasnac.com', 'Zona Franca, Santiago'),
('Deportes Cibao', '130-55555-1', '809-555-3030', 'info@deportescibao.com', 'Calle del Sol #45, Santiago')

insert into productos (codigo, nombre, descripcion, id_categoria, id_marca, precio_compra, precio_venta, stock, stock_minimo) values
('P100', 'Proteina Whey 2lb', 'Sabor chocolate', (select id_categoria from categorias where nombre = 'Suplementos'), (select id_marca from marcas where nombre = 'Optimum Nutrition'), 2200, 3200, 15, 5),
('P101', 'Creatina Monohidrato 300g', 'Sin sabor', (select id_categoria from categorias where nombre = 'Suplementos'), (select id_marca from marcas where nombre = 'MuscleTech'), 900, 1450, 3, 5),
('P102', 'Pre-entreno 30 servicios', 'Sabor fruit punch', (select id_categoria from categorias where nombre = 'Suplementos'), (select id_marca from marcas where nombre = 'MuscleTech'), 1500, 2300, 8, 4),
('P103', 'Multivitaminico 60 capsulas', null, (select id_categoria from categorias where nombre = 'Suplementos'), (select id_marca from marcas where nombre = 'Optimum Nutrition'), 600, 950, 12, 5),
('P104', 'Agua 500ml', null, (select id_categoria from categorias where nombre = 'Bebidas'), (select id_marca from marcas where nombre = 'Dasani'), 20, 50, 120, 40),
('P105', 'Bebida isotonica 600ml', 'Sabor naranja', (select id_categoria from categorias where nombre = 'Bebidas'), (select id_marca from marcas where nombre = 'Gatorade'), 45, 90, 4, 24),
('P106', 'Bebida energetica 250ml', null, (select id_categoria from categorias where nombre = 'Bebidas'), (select id_marca from marcas where nombre = 'Monster'), 70, 130, 30, 12),
('P107', 'Camiseta dry-fit', 'Talla M y L', (select id_categoria from categorias where nombre = 'Ropa deportiva'), (select id_marca from marcas where nombre = 'Nike'), 650, 1200, 20, 5),
('P108', 'Short deportivo', 'Talla M y L', (select id_categoria from categorias where nombre = 'Ropa deportiva'), (select id_marca from marcas where nombre = 'Under Armour'), 700, 1300, 10, 5),
('P109', 'Guantes de gimnasio', 'Talla unica', (select id_categoria from categorias where nombre = 'Accesorios'), (select id_marca from marcas where nombre = 'Nike'), 400, 800, 6, 5),
('P110', 'Shaker 700ml', 'Con logo del gimnasio', (select id_categoria from categorias where nombre = 'Accesorios'), (select id_marca from marcas where nombre = 'SmartFit'), 150, 350, 25, 10),
('P111', 'Correas de agarre', 'Par', (select id_categoria from categorias where nombre = 'Accesorios'), (select id_marca from marcas where nombre = 'Under Armour'), 300, 600, 2, 5),
('P112', 'Barra de proteina', 'Chocolate chip', (select id_categoria from categorias where nombre = 'Snacks'), (select id_marca from marcas where nombre = 'Quest'), 80, 150, 40, 20)

-- horarios, entrenadores y clases
insert into horarios (nombre, dias, hora_inicio, hora_fin) values
('Manana', 'Lunes a Viernes', '06:00', '12:00'),
('Tarde', 'Lunes a Viernes', '14:00', '20:00'),
('Fin de semana', 'Sabado a Domingo', '08:00', '14:00')

insert into entrenadores (nombre, apellido, cedula, telefono, correo, especialidad, id_horario) values
('Maria', 'Rodriguez', '031-1111111-1', '829-111-1111', 'maria@gimnasio.com', 'Musculacion', (select id_horario from horarios where nombre = 'Manana')),
('Pedro', 'Martinez', '031-2222222-2', '829-222-2222', 'pedro@gimnasio.com', 'CrossFit y funcional', (select id_horario from horarios where nombre = 'Tarde')),
('Laura', 'Sanchez', '031-3333333-3', '829-333-3333', 'laura@gimnasio.com', 'Yoga y pilates', (select id_horario from horarios where nombre = 'Manana')),
('Jose', 'Reyes', '031-4444444-4', '829-444-4444', 'jose@gimnasio.com', 'Boxeo', (select id_horario from horarios where nombre = 'Fin de semana'))

insert into clases (nombre, descripcion, id_entrenador, dia_semana, hora_inicio, hora_fin, cupo_maximo) values
('Zumba', 'Baile aerobico', (select id_entrenador from entrenadores where cedula = '031-3333333-3'), 'Lunes', '18:00', '19:00', 20),
('CrossFit', 'Alta intensidad', (select id_entrenador from entrenadores where cedula = '031-2222222-2'), 'Martes', '17:00', '18:00', 15),
('Yoga', 'Flexibilidad y respiracion', (select id_entrenador from entrenadores where cedula = '031-3333333-3'), 'Miercoles', '07:00', '08:00', 12),
('Funcional', 'Circuitos con peso corporal', (select id_entrenador from entrenadores where cedula = '031-2222222-2'), 'Jueves', '18:00', '19:00', 15),
('Pilates', 'Fuerza del core', (select id_entrenador from entrenadores where cedula = '031-3333333-3'), 'Viernes', '07:00', '08:00', 12),
('Boxeo', 'Tecnica y saco', (select id_entrenador from entrenadores where cedula = '031-4444444-4'), 'Sabado', '09:00', '10:00', 10)

-- planes de membresia
insert into membresias (nombre, descripcion, duracion_dias, precio) values
('Mensual', 'Acceso ilimitado por 30 dias', 30, 1500),
('Trimestral', 'Acceso ilimitado por 3 meses', 90, 4000),
('Semestral', 'Acceso ilimitado por 6 meses', 180, 7500),
('Anual', 'Acceso ilimitado por un ano', 365, 14000),
('Estudiante', 'Mensual con descuento, presentando carnet', 30, 1200)

-- clientes
insert into clientes (nombre, apellido, cedula, telefono, correo, direccion, fecha_nacimiento, sexo) values
('Ana', 'Garcia', '402-2222222-2', '829-555-0001', 'ana.garcia@gmail.com', 'Los Jardines, Santiago', '1998-03-12', 'F'),
('Luis', 'Fernandez', '402-3333333-3', '829-555-0002', 'luisfer@gmail.com', 'Villa Olga, Santiago', '1995-07-08', 'M'),
('Carla', 'Nunez', '031-5555555-5', '829-555-0003', 'carla.n@hotmail.com', 'La Trinitaria, Santiago', '2001-11-23', 'F'),
('Miguel', 'Torres', '402-6666666-6', '829-555-0004', 'mtorres@gmail.com', 'Cerros de Gurabo, Santiago', '1990-01-30', 'M'),
('Sofia', 'Ramirez', '031-7777777-7', '829-555-0005', 'sofia.r@gmail.com', 'El Embrujo, Santiago', '1999-05-17', 'F'),
('Andres', 'Polanco', '402-8888888-8', '829-555-0006', 'apolanco@gmail.com', 'Reparto del Este, Santiago', '1988-09-02', 'M'),
('Valeria', 'Castillo', '031-9999999-9', '829-555-0007', 'vale.castillo@gmail.com', 'Jardines Metropolitanos, Santiago', '2002-02-14', 'F'),
('Roberto', 'Jimenez', '402-1010101-0', '829-555-0008', 'rjimenez@gmail.com', 'Bella Vista, Santiago', '1993-12-05', 'M')

-- membresias asignadas con su pago (mismo patron que usa el sistema)
declare @idUsuario int = (select id_usuario from usuarios where nombre_usuario = 'admin')
declare @hoy date = cast(getdate() as date)
declare @idCliente int, @idMembresia int, @idClienteMembresia int, @idPago int, @idVenta int, @idProducto int

-- Ana: Mensual activa (empezo hace 10 dias)
set @idCliente = (select id_cliente from clientes where cedula = '402-2222222-2')
set @idMembresia = (select id_membresia from membresias where nombre = 'Mensual')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -10, @hoy), dateadd(day, 19, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -10, getdate()), @idCliente, @idUsuario, 'Efectivo', 1500)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Mensual (30 días)', 1500)

-- Luis: Trimestral activa (empezo hace 30 dias)
set @idCliente = (select id_cliente from clientes where cedula = '402-3333333-3')
set @idMembresia = (select id_membresia from membresias where nombre = 'Trimestral')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -30, @hoy), dateadd(day, 59, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -30, getdate()), @idCliente, @idUsuario, 'Tarjeta', 4000)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Trimestral (90 días)', 4000)

-- Carla: Mensual VENCIDA hace 11 dias (debe renovar)
set @idCliente = (select id_cliente from clientes where cedula = '031-5555555-5')
set @idMembresia = (select id_membresia from membresias where nombre = 'Mensual')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -40, @hoy), dateadd(day, -11, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -40, getdate()), @idCliente, @idUsuario, 'Efectivo', 1500)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Mensual (30 días)', 1500)

-- Miguel: Anual activa (empezo hace 100 dias)
set @idCliente = (select id_cliente from clientes where cedula = '402-6666666-6')
set @idMembresia = (select id_membresia from membresias where nombre = 'Anual')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -100, @hoy), dateadd(day, 264, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -100, getdate()), @idCliente, @idUsuario, 'Transferencia', 14000)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Anual (365 días)', 14000)

-- Sofia: Estudiante VENCIDA hace 3 dias (debe renovar)
set @idCliente = (select id_cliente from clientes where cedula = '031-7777777-7')
set @idMembresia = (select id_membresia from membresias where nombre = 'Estudiante')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -32, @hoy), dateadd(day, -3, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -32, getdate()), @idCliente, @idUsuario, 'Efectivo', 1200)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Estudiante (30 días)', 1200)

-- Andres: Semestral activa que vence en 5 dias
set @idCliente = (select id_cliente from clientes where cedula = '402-8888888-8')
set @idMembresia = (select id_membresia from membresias where nombre = 'Semestral')
insert into cliente_membresia (id_cliente, id_membresia, fecha_inicio, fecha_fin) values (@idCliente, @idMembresia, dateadd(day, -174, @hoy), dateadd(day, 5, @hoy))
set @idClienteMembresia = scope_identity()
insert into pagos (fecha, id_cliente, id_usuario, metodo_pago, monto_total) values (dateadd(day, -174, getdate()), @idCliente, @idUsuario, 'Tarjeta', 7500)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, id_cliente_membresia, concepto, monto) values (@idPago, @idClienteMembresia, 'Membresía Semestral (180 días)', 7500)

-- Roberto no tiene membresia: hoy pago la visita del dia
set @idCliente = (select id_cliente from clientes where cedula = '402-1010101-0')
insert into pagos (id_cliente, id_usuario, metodo_pago, monto_total) values (@idCliente, @idUsuario, 'Efectivo', 500)
set @idPago = scope_identity()
insert into pagos_detalle (id_pago, concepto, monto) values (@idPago, 'Visita del día', 500)

-- entradas de hoy y de ayer
insert into asistencia (id_cliente, fecha) values
((select id_cliente from clientes where cedula = '402-2222222-2'), dateadd(minute, 7 * 60 + 15, cast(@hoy as datetime))),
((select id_cliente from clientes where cedula = '402-3333333-3'), dateadd(minute, 8 * 60 + 30, cast(@hoy as datetime))),
((select id_cliente from clientes where cedula = '402-1010101-0'), dateadd(minute, 9 * 60 + 5, cast(@hoy as datetime))),
((select id_cliente from clientes where cedula = '402-6666666-6'), dateadd(minute, 18 * 60 + 10, cast(dateadd(day, -1, @hoy) as datetime))),
((select id_cliente from clientes where cedula = '402-8888888-8'), dateadd(minute, 19 * 60 + 40, cast(dateadd(day, -1, @hoy) as datetime)))

-- ventas del pos (los precios quedan congelados en el detalle)

-- venta 1: hoy, consumidor final, contado: 2 aguas + 3 barras
insert into ventas (fecha, id_cliente, id_usuario, tipo_pago, subtotal, descuento, impuesto, total)
values (dateadd(minute, 10 * 60 + 20, cast(@hoy as datetime)), null, @idUsuario, 'Contado', 550, 0, 99, 649)
set @idVenta = scope_identity()
insert into venta_detalle (id_venta, id_producto, cantidad, precio, descuento, subtotal) values
(@idVenta, (select id_producto from productos where codigo = 'P104'), 2, 50, 0, 100),
(@idVenta, (select id_producto from productos where codigo = 'P112'), 3, 150, 0, 450)

-- venta 2: ayer, Ana, contado: 1 proteina
set @idCliente = (select id_cliente from clientes where cedula = '402-2222222-2')
insert into ventas (fecha, id_cliente, id_usuario, tipo_pago, subtotal, descuento, impuesto, total)
values (dateadd(minute, 17 * 60 + 45, cast(dateadd(day, -1, @hoy) as datetime)), @idCliente, @idUsuario, 'Contado', 3200, 0, 576, 3776)
set @idVenta = scope_identity()
insert into venta_detalle (id_venta, id_producto, cantidad, precio, descuento, subtotal) values
(@idVenta, (select id_producto from productos where codigo = 'P100'), 1, 3200, 0, 3200)

-- venta 3: hace 3 dias, Luis, A CREDITO (queda pendiente en cuentas por cobrar): 2 camisetas + 1 shaker
set @idCliente = (select id_cliente from clientes where cedula = '402-3333333-3')
insert into ventas (fecha, id_cliente, id_usuario, tipo_pago, subtotal, descuento, impuesto, total)
values (dateadd(minute, 16 * 60, cast(dateadd(day, -3, @hoy) as datetime)), @idCliente, @idUsuario, 'Credito', 2750, 0, 495, 3245)
set @idVenta = scope_identity()
insert into venta_detalle (id_venta, id_producto, cantidad, precio, descuento, subtotal) values
(@idVenta, (select id_producto from productos where codigo = 'P107'), 2, 1200, 0, 2400),
(@idVenta, (select id_producto from productos where codigo = 'P110'), 1, 350, 0, 350)
insert into cuentas_cobrar (id_venta, id_cliente, monto_original, saldo, fecha_vencimiento)
values (@idVenta, @idCliente, 3245, 3245, dateadd(day, 27, @hoy))

commit transaction
go
