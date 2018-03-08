using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarTor
{
    class Constantes
    {
        #region DS_INGREDIENTES
        public static DSIngredientesTableAdapters.IngredientesTableAdapter ingredientes_TA = new DSIngredientesTableAdapters.IngredientesTableAdapter();
        public static DSIngredientesTableAdapters.ProveedoresTableAdapter proveedores_TA = new DSIngredientesTableAdapters.ProveedoresTableAdapter();
        public static DSIngredientesTableAdapters.PrecioIngredientesTableAdapter precioIngredientes_TA = new DSIngredientesTableAdapters.PrecioIngredientesTableAdapter();
        #endregion

        #region DS_PRODUCTOS
        public static DSProductosTableAdapters.PreciosMayorTableAdapter preciosMayor_TA = new DSProductosTableAdapters.PreciosMayorTableAdapter();
        public static DSProductosTableAdapters.PreciosVentaTableAdapter preciosVenta_TA = new DSProductosTableAdapters.PreciosVentaTableAdapter();
        public static DSProductosTableAdapters.ProductosTableAdapter productos_TA = new DSProductosTableAdapters.ProductosTableAdapter();
        public static DSProductosTableAdapters.PedidosTableAdapter pedidos_TA = new DSProductosTableAdapters.PedidosTableAdapter();
        public static DSProductosTableAdapters.DetallePedidosTableAdapter detaPedidosVenta_TA = new DSProductosTableAdapters.DetallePedidosTableAdapter();
        public static DSProductosTableAdapters.FacturasVentaTableAdapter factVenta_TA = new DSProductosTableAdapters.FacturasVentaTableAdapter();
        public static DSProductosTableAdapters.FacturasMayorTableAdapter facturasMayor_TA = new DSProductosTableAdapters.FacturasMayorTableAdapter();
        public static DSProductosTableAdapters.PedidosMayorTableAdapter pedidosMayor_TA = new DSProductosTableAdapters.PedidosMayorTableAdapter();
        public static DSProductosTableAdapters.DetalleFacMayorTableAdapter detalleFacMayor_TA = new DSProductosTableAdapters.DetalleFacMayorTableAdapter();
        public static DSProductosTableAdapters.ClientesMayorTableAdapter clientesMayor_TA = new DSProductosTableAdapters.ClientesMayorTableAdapter();
        #endregion

        #region DS_DATASET1
        public static DataSet1TableAdapters.SuplementoTableAdapter suplemento_TA = new DataSet1TableAdapters.SuplementoTableAdapter();
        public static DataSet1TableAdapters.AccesoTableAdapter acceso_TA = new DataSet1TableAdapters.AccesoTableAdapter();
        public static DataSet1TableAdapters.ContabilidadTableAdapter contabilidad_TA = new DataSet1TableAdapters.ContabilidadTableAdapter();
        #endregion


        #region QUERYS
        public const string QUERY_CONSULTA_CATEGORIAS = "SELECT DISTINCT Categoria_Producto FROM Productos";
        #endregion


        public const int COLUMNA_PRECIO = 3;
        public const int COLUMNA_UNIDADES = 2;
        public const int COLUMNA_NOMBRE = 1;
        public const int TAMANO_IMAGENES = 175;
        public static string PESO_UD_PRODUCTO = "0";
        public static string PRECIO_ESTRELLA = "0";
        public static string IMPORTE = "0";
        public static bool VENTA_HECHA = false;
        public static int Num_Pedido = 0;

        public const string MAIN_RUTA= "C:/GarTor";
        public const string FACTURAS_RUTA = "C:/GarTor/Facturas";
        public const string FACTURAS_VT = "C:/GarTor/Facturas/VentasTienda";
        public const string FACTURAS_VM = "C:/GarTor/Facturas/VentasMayor";
        public const string PRODUCTOS_RUTA = "C:/GarTor/Productos";
        public const string CATEGORIAS_RUTA = "C:/GarTor/Productos/Categorias";
        public const string EXTENSION = ".png";
        
        
    }
}
