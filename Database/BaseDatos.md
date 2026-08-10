# Base de Datos — GimnasioDB

**Motor:** SQL Server (LocalDB o Express) · **Nombre de la BD:** `GimnasioDB`

**Convenciones usadas:**
- Tablas en minúscula y snake_case (como pide el enunciado).
- Toda PK es `INT IDENTITY(1,1)` con prefijo `id_`.
- `estado BIT` en catálogos: `1 = Activo`, `0 = Inactivo` (nunca se borra físicamente, se desactiva).
- Tablas transaccionales usan `estado NVARCHAR` con valores fijos (se indican en cada tabla).
- Dinero: `DECIMAL(10,2)`. Fechas con hora: `DATETIME`. Solo fecha: `DATE`.

---

## Módulo 1: Seguridad

### 1. roles
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_rol | INT IDENTITY | NO | PK | Identificador del rol |
| nombre | NVARCHAR(50) | NO | UNIQUE | Nombre del rol (Administrador, Cajero…) |
| descripcion | NVARCHAR(200) | SÍ | | Descripción del rol |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 2. permisos
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_permiso | INT IDENTITY | NO | PK | Identificador del permiso |
| nombre | NVARCHAR(50) | NO | UNIQUE | Clave del permiso (ej: CLIENTES, POS, REPORTES) |
| descripcion | NVARCHAR(200) | SÍ | | Qué permite hacer |

### 3. rol_permiso  (resuelve N:M entre roles y permisos)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_rol | INT | NO | PK compuesta, FK → roles | Rol |
| id_permiso | INT | NO | PK compuesta, FK → permisos | Permiso asignado |

### 4. usuarios
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_usuario | INT IDENTITY | NO | PK | Identificador del usuario |
| id_rol | INT | NO | FK → roles | Rol del usuario (1:N) |
| nombre_usuario | NVARCHAR(50) | NO | UNIQUE | Usuario para el login |
| clave | NVARCHAR(64) | NO | | Contraseña en **hash SHA-256** (hex mayúscula, 64 chars) |
| nombre_completo | NVARCHAR(100) | NO | | Nombre y apellido del empleado |
| correo | NVARCHAR(100) | SÍ | | Correo (para recuperación en la web) |
| fecha_creacion | DATETIME | NO | DEFAULT GETDATE() | Cuándo se creó |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

---

## Módulo 2: Clientes y Membresías

### 5. clientes
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_cliente | INT IDENTITY | NO | PK | Identificador del cliente |
| nombre | NVARCHAR(50) | NO | | Nombre |
| apellido | NVARCHAR(50) | NO | | Apellido |
| cedula | NVARCHAR(15) | NO | UNIQUE | Cédula (formato 000-0000000-0) |
| telefono | NVARCHAR(15) | SÍ | | Teléfono |
| correo | NVARCHAR(100) | SÍ | | Correo |
| direccion | NVARCHAR(200) | SÍ | | Dirección |
| fecha_nacimiento | DATE | SÍ | | Fecha de nacimiento |
| sexo | CHAR(1) | SÍ | CHECK (sexo IN ('M','F')) | Sexo |
| foto | VARBINARY(MAX) | SÍ | | Fotografía del cliente (bytes de la imagen) |
| fecha_registro | DATETIME | NO | DEFAULT GETDATE() | Fecha de inscripción |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 6. membresias  (catálogo de planes)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_membresia | INT IDENTITY | NO | PK | Identificador del plan |
| nombre | NVARCHAR(50) | NO | UNIQUE | Nombre del plan (Mensual, Trimestral…) |
| descripcion | NVARCHAR(200) | SÍ | | Qué incluye |
| duracion_dias | INT | NO | CHECK (duracion_dias > 0) | Días de vigencia |
| precio | DECIMAL(10,2) | NO | CHECK (precio >= 0) | Precio del plan |
| fecha_creacion | DATETIME | NO | DEFAULT GETDATE() | Cuándo se creó el plan |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 7. cliente_membresia  (N:M con historia — la renovación INSERTA una fila nueva)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_cliente_membresia | INT IDENTITY | NO | PK | Identificador de la asignación |
| id_cliente | INT | NO | FK → clientes | Cliente |
| id_membresia | INT | NO | FK → membresias | Plan asignado |
| fecha_inicio | DATE | NO | | Inicio de vigencia |
| fecha_fin | DATE | NO | CHECK (fecha_fin >= fecha_inicio) | Fin de vigencia |
| estado | NVARCHAR(20) | NO | DEFAULT 'Activa', CHECK IN ('Activa','Vencida','Cancelada') | Estado de la asignación |

---

## Módulo 3: Pagos (de membresías)

### 8. pagos
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_pago | INT IDENTITY | NO | PK | Número del recibo |
| fecha | DATETIME | NO | DEFAULT GETDATE() | Fecha del pago |
| id_cliente | INT | NO | FK → clientes | Quién paga |
| id_usuario | INT | NO | FK → usuarios | Quién cobró |
| metodo_pago | NVARCHAR(20) | NO | CHECK IN ('Efectivo','Tarjeta','Transferencia') | Método de pago |
| monto_total | DECIMAL(10,2) | NO | CHECK (monto_total >= 0) | Total del recibo |
| observacion | NVARCHAR(200) | SÍ | | Nota opcional |
| estado | NVARCHAR(20) | NO | DEFAULT 'Completado', CHECK IN ('Completado','Anulado') | Estado |

### 9. pagos_detalle  (un recibo puede tener varios conceptos)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_pago_detalle | INT IDENTITY | NO | PK | Identificador del renglón |
| id_pago | INT | NO | FK → pagos | Recibo al que pertenece |
| id_cliente_membresia | INT | SÍ | FK → cliente_membresia | Membresía que se está pagando (NULL si es otro concepto) |
| concepto | NVARCHAR(100) | NO | | Ej: "Membresía Mensual", "Inscripción" |
| monto | DECIMAL(10,2) | NO | CHECK (monto >= 0) | Monto del renglón |

---

## Módulo 4: Entrenadores, Clases y Asistencia

### 10. entrenadores
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_entrenador | INT IDENTITY | NO | PK | Identificador |
| nombre | NVARCHAR(50) | NO | | Nombre |
| apellido | NVARCHAR(50) | NO | | Apellido |
| cedula | NVARCHAR(15) | NO | UNIQUE | Cédula |
| telefono | NVARCHAR(15) | SÍ | | Teléfono |
| correo | NVARCHAR(100) | SÍ | | Correo |
| especialidad | NVARCHAR(100) | SÍ | | Ej: Pesas, CrossFit, Yoga |
| horario | NVARCHAR(100) | SÍ | | Horario de trabajo (texto: "L-V 8am-4pm") |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 11. clases
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_clase | INT IDENTITY | NO | PK | Identificador |
| nombre | NVARCHAR(50) | NO | | Nombre de la clase (Spinning, Yoga…) |
| descripcion | NVARCHAR(200) | SÍ | | Descripción |
| id_entrenador | INT | NO | FK → entrenadores | Entrenador que la imparte (1:N) |
| dia_semana | NVARCHAR(15) | NO | | Día que se imparte (Lunes…Domingo) |
| hora_inicio | TIME | NO | | Hora de inicio |
| hora_fin | TIME | NO | | Hora de fin |
| cupo_maximo | INT | NO | CHECK (cupo_maximo > 0) | Cupo de la clase |
| estado | BIT | NO | DEFAULT 1 | 1=Activa, 0=Inactiva |

### 12. reservas  (resuelve N:M entre clientes y clases)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_reserva | INT IDENTITY | NO | PK | Identificador |
| id_clase | INT | NO | FK → clases | Clase reservada |
| id_cliente | INT | NO | FK → clientes | Cliente que reserva |
| fecha_reserva | DATE | NO | UNIQUE (id_clase, id_cliente, fecha_reserva) | Fecha para la que reserva |
| fecha_creacion | DATETIME | NO | DEFAULT GETDATE() | Cuándo hizo la reserva |
| estado | NVARCHAR(20) | NO | DEFAULT 'Reservada', CHECK IN ('Reservada','Cancelada','Asistio') | Estado |

### 13. asistencia  (check-in del cliente al gimnasio)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_asistencia | INT IDENTITY | NO | PK | Identificador |
| id_cliente | INT | NO | FK → clientes | Cliente que entró |
| fecha | DATETIME | NO | DEFAULT GETDATE() | Fecha y hora de entrada |
| id_reserva | INT | SÍ | FK → reservas | Si vino por una clase reservada (NULL = visita normal) |

---

## Módulo 5: Inventario y POS

### 14. categorias
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_categoria | INT IDENTITY | NO | PK | Identificador |
| nombre | NVARCHAR(50) | NO | UNIQUE | Nombre (Suplementos, Bebidas, Ropa…) |
| descripcion | NVARCHAR(200) | SÍ | | Descripción |
| estado | BIT | NO | DEFAULT 1 | 1=Activa, 0=Inactiva |

### 15. marcas
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_marca | INT IDENTITY | NO | PK | Identificador |
| nombre | NVARCHAR(50) | NO | UNIQUE | Nombre de la marca |
| estado | BIT | NO | DEFAULT 1 | 1=Activa, 0=Inactiva |

### 16. productos
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_producto | INT IDENTITY | NO | PK | Identificador |
| codigo | NVARCHAR(20) | NO | UNIQUE | Código interno |
| codigo_barras | NVARCHAR(50) | SÍ | UNIQUE (permite NULL) | Código de barras |
| nombre | NVARCHAR(100) | NO | | Nombre del producto |
| descripcion | NVARCHAR(200) | SÍ | | Descripción |
| id_categoria | INT | NO | FK → categorias | Categoría (1:N) |
| id_marca | INT | NO | FK → marcas | Marca (1:N) |
| precio_compra | DECIMAL(10,2) | NO | CHECK (precio_compra >= 0) | Costo |
| precio_venta | DECIMAL(10,2) | NO | CHECK (precio_venta >= 0) | Precio al público |
| stock | INT | NO | DEFAULT 0, CHECK (stock >= 0) | Existencia actual |
| stock_minimo | INT | NO | DEFAULT 0 | Para la alerta de stock bajo |
| imagen | VARBINARY(MAX) | SÍ | | Imagen del producto |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 17. ventas
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_venta | INT IDENTITY | NO | PK | Número de la venta |
| fecha | DATETIME | NO | DEFAULT GETDATE() | Fecha |
| id_cliente | INT | SÍ | FK → clientes | Cliente (NULL = venta de mostrador al contado) |
| id_usuario | INT | NO | FK → usuarios | Cajero |
| tipo_pago | NVARCHAR(10) | NO | CHECK IN ('Contado','Credito') | A crédito exige cliente (regla de negocio) |
| subtotal | DECIMAL(10,2) | NO | | Suma de renglones |
| descuento | DECIMAL(10,2) | NO | DEFAULT 0 | Descuento global |
| impuesto | DECIMAL(10,2) | NO | DEFAULT 0 | ITBIS calculado |
| total | DECIMAL(10,2) | NO | | subtotal − descuento + impuesto |
| estado | NVARCHAR(20) | NO | DEFAULT 'Completada', CHECK IN ('Completada','Anulada') | Estado |

### 18. venta_detalle
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_detalle | INT IDENTITY | NO | PK | Identificador del renglón |
| id_venta | INT | NO | FK → ventas | Venta a la que pertenece |
| id_producto | INT | NO | FK → productos | Producto vendido |
| cantidad | INT | NO | CHECK (cantidad > 0) | Cantidad |
| precio | DECIMAL(10,2) | NO | | Precio al momento de vender (histórico) |
| descuento | DECIMAL(10,2) | NO | DEFAULT 0 | Descuento del renglón |
| subtotal | DECIMAL(10,2) | NO | | cantidad × precio − descuento |

---

## Módulo 6: Crédito, Compras y Configuración

### 19. cuentas_cobrar  (una venta a crédito genera UNA cuenta)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_cuenta | INT IDENTITY | NO | PK | Identificador |
| id_venta | INT | NO | FK → ventas, UNIQUE | Venta que la originó (1:1 con la venta a crédito) |
| id_cliente | INT | NO | FK → clientes | Deudor |
| monto_original | DECIMAL(10,2) | NO | | Total original de la deuda |
| saldo | DECIMAL(10,2) | NO | CHECK (saldo >= 0) | Lo que falta por pagar |
| fecha_vencimiento | DATE | NO | | Fecha límite de pago |
| estado | NVARCHAR(20) | NO | DEFAULT 'Pendiente', CHECK IN ('Pendiente','Saldada','Vencida') | Saldada cuando saldo = 0 |

### 20. abonos
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_abono | INT IDENTITY | NO | PK | Identificador |
| id_cuenta | INT | NO | FK → cuentas_cobrar | Cuenta a la que abona |
| fecha | DATETIME | NO | DEFAULT GETDATE() | Fecha del abono |
| monto | DECIMAL(10,2) | NO | CHECK (monto > 0) | Monto abonado |
| id_usuario | INT | NO | FK → usuarios | Quién recibió el abono |

### 21. proveedores
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_proveedor | INT IDENTITY | NO | PK | Identificador |
| nombre | NVARCHAR(100) | NO | | Nombre / razón social |
| rnc | NVARCHAR(20) | SÍ | | RNC |
| telefono | NVARCHAR(15) | SÍ | | Teléfono |
| correo | NVARCHAR(100) | SÍ | | Correo |
| direccion | NVARCHAR(200) | SÍ | | Dirección |
| estado | BIT | NO | DEFAULT 1 | 1=Activo, 0=Inactivo |

### 22. compras
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_compra | INT IDENTITY | NO | PK | Identificador |
| fecha | DATETIME | NO | DEFAULT GETDATE() | Fecha |
| id_proveedor | INT | NO | FK → proveedores | Proveedor |
| id_usuario | INT | NO | FK → usuarios | Quién registró la compra |
| numero_factura | NVARCHAR(30) | SÍ | | Nº de factura del proveedor |
| subtotal | DECIMAL(10,2) | NO | | Suma de renglones |
| impuesto | DECIMAL(10,2) | NO | DEFAULT 0 | ITBIS |
| total | DECIMAL(10,2) | NO | | Total pagado |
| estado | NVARCHAR(20) | NO | DEFAULT 'Completada', CHECK IN ('Completada','Anulada') | Estado |

### 23. compra_detalle
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_compra_detalle | INT IDENTITY | NO | PK | Identificador del renglón |
| id_compra | INT | NO | FK → compras | Compra a la que pertenece |
| id_producto | INT | NO | FK → productos | Producto comprado (suma stock) |
| cantidad | INT | NO | CHECK (cantidad > 0) | Cantidad |
| precio_compra | DECIMAL(10,2) | NO | | Costo unitario en esa compra |
| subtotal | DECIMAL(10,2) | NO | | cantidad × precio_compra |

### 24. configuracion  (una sola fila con los datos del negocio)
| Campo | Tipo | Nulo | Clave / Restricción | Descripción |
|---|---|---|---|---|
| id_configuracion | INT | NO | PK, CHECK (id_configuracion = 1) | Siempre 1 (fila única) |
| nombre_gimnasio | NVARCHAR(100) | NO | | Nombre del negocio |
| rnc | NVARCHAR(20) | SÍ | | RNC |
| telefono | NVARCHAR(15) | SÍ | | Teléfono |
| direccion | NVARCHAR(200) | SÍ | | Dirección |
| correo | NVARCHAR(100) | SÍ | | Correo |
| porcentaje_impuesto | DECIMAL(5,2) | NO | DEFAULT 18.00 | % de ITBIS que usa el POS |
| mensaje_recibo | NVARCHAR(200) | SÍ | | Pie de página de los recibos |
| logo | VARBINARY(MAX) | SÍ | | Logo para recibos/carnet |

---

## Índices recomendados (además de PK y UNIQUE)

```sql
CREATE INDEX IX_clientes_nombre       ON clientes(nombre, apellido);
CREATE INDEX IX_cliente_membresia_cli ON cliente_membresia(id_cliente, fecha_fin);
CREATE INDEX IX_pagos_fecha           ON pagos(fecha);
CREATE INDEX IX_ventas_fecha          ON ventas(fecha);
CREATE INDEX IX_ventas_cliente        ON ventas(id_cliente);
CREATE INDEX IX_venta_detalle_venta   ON venta_detalle(id_venta);
CREATE INDEX IX_cuentas_cobrar_cli    ON cuentas_cobrar(id_cliente, estado);
CREATE INDEX IX_abonos_cuenta         ON abonos(id_cuenta);
CREATE INDEX IX_compras_fecha         ON compras(fecha);
CREATE INDEX IX_asistencia_fecha      ON asistencia(fecha);
CREATE INDEX IX_reservas_clase        ON reservas(id_clase, fecha_reserva);
CREATE INDEX IX_productos_nombre      ON productos(nombre);
```

## Datos iniciales obligatorios (para que el sistema arranque)

> ⚠️ La contraseña se guarda como **SHA-256 en hexadecimal MAYÚSCULA** (así la genera el código C#).
> `HASHBYTES` de SQL Server produce exactamente el mismo hash, por eso el INSERT de abajo funciona con el login.

```sql
-- Roles
INSERT INTO roles (nombre, descripcion) VALUES
('Administrador', 'Acceso total al sistema'),
('Cajero',        'POS, ventas y cobros'),
('Recepcionista', 'Clientes, membresías, reservas y asistencia');

-- Permisos (uno por módulo del sistema)
INSERT INTO permisos (nombre, descripcion) VALUES
('USUARIOS',      'Mantenimiento de usuarios y roles'),
('CLIENTES',      'Mantenimiento de clientes'),
('MEMBRESIAS',    'Planes, asignación y renovación'),
('PAGOS',         'Registrar pagos y recibos'),
('ENTRENADORES',  'Mantenimiento de entrenadores'),
('CLASES',        'Clases y reservas'),
('PRODUCTOS',     'Productos, categorías y marcas'),
('POS',           'Ventas en el punto de venta'),
('COMPRAS',       'Compras y proveedores'),
('CUENTAS',       'Cuentas por cobrar y abonos'),
('REPORTES',      'Reportes y dashboard'),
('CONFIGURACION', 'Configuración del sistema');

-- El Administrador tiene TODOS los permisos
INSERT INTO rol_permiso (id_rol, id_permiso)
SELECT 1, id_permiso FROM permisos;

-- Cajero: POS, pagos, cuentas, productos (solo consulta se controla en la app)
INSERT INTO rol_permiso (id_rol, id_permiso)
SELECT 2, id_permiso FROM permisos WHERE nombre IN ('POS','PAGOS','CUENTAS','PRODUCTOS');

-- Recepcionista: clientes, membresías, clases, pagos
INSERT INTO rol_permiso (id_rol, id_permiso)
SELECT 3, id_permiso FROM permisos WHERE nombre IN ('CLIENTES','MEMBRESIAS','CLASES','PAGOS');

-- Usuario administrador inicial → usuario: admin / contraseña: Admin123
INSERT INTO usuarios (id_rol, nombre_usuario, clave, nombre_completo, correo)
VALUES (1, 'admin',
        CONVERT(NVARCHAR(64), HASHBYTES('SHA2_256', 'Admin123'), 2),
        'Administrador del Sistema', 'admin@gimnasio.com');

-- Configuración inicial
INSERT INTO configuracion (id_configuracion, nombre_gimnasio, porcentaje_impuesto, mensaje_recibo)
VALUES (1, 'Mi Gimnasio', 18.00, 'Gracias por su compra');
```

## Reglas de negocio que NO van en la BD (van en CapaNegocio)

- Venta a **crédito** exige cliente seleccionado y genera automáticamente la fila en `cuentas_cobrar`.
- La venta descuenta stock y la compra lo suma — **dentro de una transacción** (`SqlTransaction`).
- Un abono no puede ser mayor que el saldo; cuando saldo llega a 0 la cuenta pasa a `Saldada`.
- La renovación de membresía **inserta** una fila nueva en `cliente_membresia` (no actualiza la vieja) — así queda el historial.
- El check-in valida que el cliente tenga una membresía con `fecha_fin >= HOY` y estado `Activa`.
