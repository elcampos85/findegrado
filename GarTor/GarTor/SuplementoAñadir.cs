using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class SuplementoAñadir : Form
    {
        public SuplementoAñadir()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (verificar(tbNombre.Text))
                {
                    Constantes.suplemento_TA.Insert(tbNombre.Text, Convert.ToDouble(NPrecio.Value));
                    MessageBox.Show("Suplemento agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El suplemento ya existe");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("El suplemento no se agregó");
            }
        }
        public bool verificar(string nombre)
        {
            if (Constantes.suplemento_TA.Verificacion(nombre) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
