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
    public partial class Inicio : Form
    {
        #region DECLARACION DE VARIABLES
            private SqlConnection conexion;
            private string stringConexion;
        #endregion
        public Inicio()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//Cambia el uso de , y . para millar y decimas
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

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn panel1 = new LogIn();
            panel1.MaximizeBox = false;
            panel1.MinimizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            panel1.ShowDialog();
        }

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

        private void mantener(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

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

        private void miBalanceDiario_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            CierreCaja panel1 = new CierreCaja();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

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

        private void miBalanceAnual_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            IngreAnu panel1 = new IngreAnu();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miCalcularCosteProduccion_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            AgregarUsuario panel1 = new AgregarUsuario();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
        
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

        private void mostrarHora(object sender, EventArgs e)
        {
            tslbFechayHora.Text = DateTime.Now.ToString();
        }

        private void IngreGastos(object sender, EventArgs e)
        {

        }
    }
}
