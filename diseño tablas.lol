Tabla user y pass (marginada)

Proveedores (cod_Proveedor, nom_Proveedor)
Ingredientes(cod_Ingrediente, nom_Ingrediente)
PrecioIngredientes(cod_Ingrediente, cod_Proveedor, precio)

Productos(cod_Producto, nom_Producto)
PrecioVenta(cod_Producto, precio_Venta)
PrecioMayor(cod_Producto, precio_Mayor)

Suplementos(cod_Suplemento, nom_Suplemento, precio_Suplemento)





Contabilidad

Facturas





VentaProductos(cod_Autoincremental, unidad_Producto, nom_Producto, fecha_venta)
Fichero SQL con updates para los productos vendidos y llevar un seguimiento
(
	if exist(select nom from Ventas where id=@id)
		update
	else
		insert	
)