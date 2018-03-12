using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace GarTor
{
    /// <summary>
    /// Formulario principal de la aplicacion
    /// </summary>
    public partial class Inicio : Form
    {
        #region DECLARACION DE VARIABLES
            private SqlConnection conexion;
            private string stringConexion;
        #endregion
        /// <summary>
        /// Constructor de la clase.
        /// Cambia el idioma de introduccion de datos para que la "," sea un ".".
        /// Realiza una conexion con la BBDD.
        /// Ajusta la ventana a la pantalla.
        /// Llama la metodo para crear los directorios de la aplicacion.
        /// Cambia de panel para que se muestre la portada desde el inicio.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-AU");//Cambia el uso de , y . para millar y decimas
            stringConexion = ConfigurationManager.ConnectionStrings["GarTor.Properties.Settings.PasteleriaConnectionString"].ConnectionString;//Se crea la conexion de configuracion del proyecto para utilizar la base de datos
            try
            {
                crearDirectorios();//Metodo que lleva a cabo la creacion de los directorios de recursos necesarios para la aplicacion si no existen
            }
            catch (Exception E)
            {
                MessageBox.Show("Se requieren permisos de administrador");
                this.Close();
            }

            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height; //Ajusta al alto de la pantalla
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width; //Ajusta al ancho de la pantalla

            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            Portada panel1 = new Portada();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();

           
        }
        /// <summary>
        /// Boton para abrir el LogIn y acceder a la pantalla de gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn panel1 = new LogIn();
            panel1.MaximizeBox = false;
            panel1.MinimizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            panel1.ShowDialog();
        }
        /// <summary>
        /// Abre el formulario de ventaTienda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ventaEnTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0)this.pPanelContenedor.Controls.RemoveAt(0);
            VentaTienda panel1 = new VentaTienda();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        /// <summary>
        /// Metodo para que no se pueda mover la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantener(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        /// <summary>
        /// Boton para abrir el formulario de ventaMayor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miVentaMayor_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0)this.pPanelContenedor.Controls.RemoveAt(0);
            VentaMayor panel1 = new VentaMayor();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        /// <summary>
        /// Boton para abrir el formulario para la consulta del dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miConsultaDia_Click(object sender, EventArgs e)
        {
            if(this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ConsultaDia panel1 = new ConsultaDia();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        /// <summary>
        /// Boton para abrir el formulario para la consulta por mes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miBalanceMensual_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            IngreMen panel1 = new IngreMen();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        /// <summary>
        /// Boton para abrir el formulario para la consulta por año
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miBalanceAnual_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ConsultaAnyo panel1 = new ConsultaAnyo();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        /// <summary>
        /// Metodo que comprueba si existe los directorios de la aplicacion, si no existen los crea
        /// </summary>
        private void crearDirectorios()
        {
            string rutaPrincipal = Constantes.MAIN_RUTA;
            string rutaProductos = Constantes.PRODUCTOS_RUTA;
            string rutaCategorias = Constantes.CATEGORIAS_RUTA;
            string rutaFacturas = Constantes.FACTURAS_RUTA;
            string rutaFacturasVT = Constantes.FACTURAS_VT;
            string rutaFacturasVM = Constantes.FACTURAS_VM;
            string[] categorias = null;//Array para almacenar las categorias de la consulta Sql

            if (!System.IO.File.Exists(rutaPrincipal))
            {
                System.IO.Directory.CreateDirectory(rutaPrincipal);//Se crea el directorio principal si no existe
            }
            if (!System.IO.File.Exists(rutaFacturas))
            {
                System.IO.Directory.CreateDirectory(rutaFacturas);//Se crea el directorio de Facturas dentro del principal si no existe
            }
            if (!System.IO.File.Exists(rutaFacturasVT))
            {
                System.IO.Directory.CreateDirectory(rutaFacturasVT);//Se crea el directorio de FacturasVentaTienda dentro de Facturas si no existe
            }
            if (!System.IO.File.Exists(rutaFacturasVM))
            {
                System.IO.Directory.CreateDirectory(rutaFacturasVM);//Se crea el directorio de FacturasVentaMayor dentro de Facturas si no existe
            }
            if (!System.IO.File.Exists(rutaProductos))
            {
                System.IO.Directory.CreateDirectory(rutaProductos);//Se crea el directorio de Productos dentro del principal si no existe
            }
            if (!System.IO.File.Exists(rutaCategorias))
            {
                System.IO.Directory.CreateDirectory(rutaCategorias);//Se crea el directorio de Categorias dentro del directorio de Productos si no existe
            }
            using (conexion = new SqlConnection(stringConexion))//Se crea la conexion a la base de datos y se realiza la consulta de las distintas categorias
            using (SqlDataAdapter adaptador = new SqlDataAdapter(Constantes.QUERY_CONSULTA_CATEGORIAS, conexion))//Se almacena el resultado en un adaptador
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);//Rellenamos el DataTable con las filas de la consulta en una unica columna
                categorias = dt.Rows.OfType<DataRow>().Select(x => x[0].ToString()).ToArray();//Rellenamos el array de categorias con los datos de las filas pasadas a string y posteriormente a un array
            }
            foreach (string cat in categorias)//Recorremos el array de categorias
            {
                if (!System.IO.File.Exists(rutaProductos + "/" + cat))//Comprobamos si existen los directorios de las diferentes categorias en el directorio de productos
                {
                    System.IO.Directory.CreateDirectory(rutaProductos + "/" + cat);//Si no existe alguno se crea
                }
            }
        }
        /// <summary>
        /// Metodo para que se actualice la hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarHora(object sender, EventArgs e)
        {
            tslbFechayHora.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// Abre el formulario para agregar gastos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IngreGastos(object sender, EventArgs e)
        {
            VentanaGastos panel1 = new VentanaGastos();
            panel1.MinimizeBox = false;
            panel1.MaximizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            panel1.ShowDialog();
        }
    }
}
