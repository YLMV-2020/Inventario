create database TiendaDB

create table Categoria
(
id_categoria int primary key identity,
nombre varchar(30) not null,
descripcion text default 'N'
);

create table Producto
(
id_producto int primary key identity,
id_categoria int,
nombre varchar(30) not null,
descripcion text,
precio float not null,
cantidad int not null,

CONSTRAINT fk_Categoria_Producto FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);

create table Cliente
(
id_cliente int primary key identity,
nombres varchar(30) not null,
dni int not null,
ventas_realizadas int default 0,
valor_total float default 0,
);

ALTER TABLE Cliente
  ALTER COLUMN valor_total float

create table LineaDeVenta
(
id_linea_de_venta int primary key identity,
id_producto int,
id_venta int,
cantidad int not null,
descripcion text default 'N',
precio_unitario float,
importe float not null,

/*CONSTRAINT fk_Producto_LineaDeVenta FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),*/

);

ALTER TABLE LineaDeVenta
ADD FOREIGN KEY (id_producto) REFERENCES Producto(id_producto);

ALTER TABLE LineaDeVenta
ADD FOREIGN KEY (id_venta) REFERENCES Venta(id_venta);

create table Venta
(
id_venta int primary key identity,
id_cliente int,
id_tienda int not null,
fecha datetime not null,

/*
CONSTRAINT fk_Cliente_Venta FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
CONSTRAINT fk_Tienda_Venta FOREIGN KEY (id_tienda) REFERENCES Tienda(id_tienda)*/
);

ALTER TABLE Venta
ADD FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente);

ALTER TABLE Venta
ADD FOREIGN KEY (id_tienda) REFERENCES Tienda(id_tienda);

create table Tienda
(
id_tienda int primary key identity,
nombre varchar(30) not null,
direccion text not null,
ruc varchar(20) not null,

);

insert into Tienda(nombre,direccion,ruc) values('Morevas','Avenida Miguel Grau','1798285937001 ')

select * from Tienda

insert into Categoria(nombre) values('Muebles')
insert into Categoria(nombre) values('Tecnologia')
insert into Categoria(nombre) values('Juguetes')
insert into Categoria(nombre) values('Ropa')

select * from Categoria

insert into Producto(id_categoria, nombre, descripcion, precio, cantidad) values((SELECT id_categoria from Categoria WHERE nombre='Tecnologia'), 'Play Station', 'novedoso', 3500, 50)
insert into Producto(nombre, descripcion, precio, cantidad) values('Silla', 'para eventos', 74.99, 20)
insert into Producto(nombre, descripcion, precio, cantidad) values('Mesa', 'para eventos', 144.99, 60)

select * from Producto

insert into Cliente(nombres, dni) values('Yordy Leonidas', 78188165)
insert into Cliente(nombres, dni) values('Piero Jose', 78173133)
insert into Cliente(nombres, dni) values('Margot Bueno', 68173133)

select nombres from Cliente where dni = 78199106

select * from Cliente 

insert into Venta(id_cliente,id_tienda,fecha) values((SELECT id_cliente from Cliente WHERE dni=78199106), (SELECT id_tienda from Tienda WHERE nombre = 'Morevas'), convert(datetime,'18-06-12 10:34:09 PM',5))
insert into Venta(id_cliente,id_tienda,fecha) values((SELECT id_cliente from Cliente WHERE dni=78199107), (SELECT id_tienda from Tienda WHERE nombre = 'Morevas'), convert(datetime,'20-06-20 10:34:09 PM',5))
insert into Venta(id_cliente,id_tienda,fecha) values((SELECT id_cliente from Cliente WHERE dni=78199106), (SELECT id_tienda from Tienda WHERE nombre = 'Morevas'), convert(datetime,'02-06-21 16:34:09 PM',5))

select * from Venta

insert into LineaDeVenta(id_producto, id_venta, cantidad, descripcion, precio_unitario, importe) values((SELECT id_producto from Producto WHERE nombre='Silla'),
(SELECT id_venta from Venta WHERE Venta.id_cliente=(SELECT id_cliente from Cliente WHERE Cliente.dni=78199107)), 4, 'novedoso', 0, (SELECT precio from Producto WHERE nombre='Silla')*4)

select * from LineaDeVenta


select P.nombre,P.descripcion,P.precio,P.cantidad,C.nombre,C.descripcion from Producto P  join Categoria C ON P.id_categoria=C.id_categoria

DELETE FROM Producto 
    WHERE nombre = 'mesa' and id_producto=2


drop database TiendaDB

delete from Cliente
