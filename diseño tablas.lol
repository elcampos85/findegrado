Tabla acceso (user, pass)

Proveedores (cod_Proveedor, nom_Proveedor)
Ingredientes(cod_Ingrediente, nom_Ingrediente)
PrecioIngredientes(cod_Ingrediente, cod_Proveedor, precio)

Productos(cod_Producto, nom_Producto)
Precios(cod_Producto, precio_Venta, precio_Mayor)

ClientesMayor(cod_Cliente, nom_Cliente)
Facturas(cod_Factura, fecha_Factura, cod_Cliente, cod_Producto)

Suplementos(cod_Suplemento, nom_Suplemento, precio_Suplemento)



Contabilidad()



VentaProductos(cod_Autoincremental, unidad_Producto, nom_Producto, fecha_venta)
Fichero SQL con updates para los productos vendidos y llevar un seguimiento
(
	if exist(select nom from Ventas where id=@id)
		update
	else
		insert	
)