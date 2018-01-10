using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
            tbUser.Select();

        }

        private void logIn(object sender, EventArgs e)
        {
            

            string user = tbUser.Text.ToString();
            string pass = tbPass.Text.ToString();


            try
            {

                String conexion = "Data Source =.\\SQLEXPRESS; Initial Catalog = Pasteleria; Integrated Security = true";

                SqlConnection cnn = new SqlConnection(conexion);
                cnn.Open();
                String consulta = "select User from Acceso where User = " + user;

                SqlCommand cmd = new SqlCommand(consulta, cnn);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show(reader.GetValue(1).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR CLAVE NO ENCONTRADA");
            }

            if (pass == "123")
            {
                MessageBox.Show("yeah");
            }
        }
        
    }
}
