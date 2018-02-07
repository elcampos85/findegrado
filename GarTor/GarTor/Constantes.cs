using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarTor
{
    class Constantes
    {
        public const string MAIN_RUTA= "C:/GarTor";
        public const string PRODUCTOS_RUTA = "C:/GarTor/Productos";
        public const string CATEGORIAS_RUTA = "C:/GarTor/Productos/Categorias";
        public const string EXTENSION = ".png";
        public const string QUERY_CONSULTA_CATEGORIAS = "SELECT DISTINCT Categoria_Producto FROM Productos";
        public const string QUERY_CONSULTA_PRECIOVENTA = "SELECT PrecioVenta FROM PreciosVenta WHERE Cod_Producto=(" + QUERY_CONSULTA_CODPRODUCTO + ")";
        public const string QUERY_CONSULTA_CODPRODUCTO = "SELECT Cod_Producto FROM Productos WHERE Nombre_Producto=";
    }
}
