using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarTor
{
    class Constantes
    {
        public static DSIngredientesTableAdapters.IngredientesTableAdapter ingredientes_TA = new DSIngredientesTableAdapters.IngredientesTableAdapter();
        public static DSIngredientesTableAdapters.ProveedoresTableAdapter proveedores_TA = new DSIngredientesTableAdapters.ProveedoresTableAdapter();
        public static DSIngredientesTableAdapters.PrecioIngredientesTableAdapter precioIngredientes_TA = new DSIngredientesTableAdapters.PrecioIngredientesTableAdapter();
        public static DSProductosTableAdapters.PreciosMayorTableAdapter preciosMayor_TA = new DSProductosTableAdapters.PreciosMayorTableAdapter();
        public static DSProductosTableAdapters.PreciosVentaTableAdapter preciosVenta_TA = new DSProductosTableAdapters.PreciosVentaTableAdapter();
        public static DSProductosTableAdapters.ProductosTableAdapter productos_TA = new DSProductosTableAdapters.ProductosTableAdapter();


        public const string QUERY_CONSULTA_CATEGORIAS = "SELECT DISTINCT Categoria_Producto FROM Productos";



        public const int COLUMNA_PRECIO = 3;
        public const int COLUMNA_UNIDADES = 2;
        public const int COLUMNA_NOMBRE = 1;
        public const int TAMANO_IMAGENES = 175;
        public static string PESO_UD_PRODUCTO = "0";



        public const string MAIN_RUTA= "C:/GarTor";
        public const string PRODUCTOS_RUTA = "C:/GarTor/Productos";
        public const string CATEGORIAS_RUTA = "C:/GarTor/Productos/Categorias";
        public const string EXTENSION = ".png";
        
        
    }
}
