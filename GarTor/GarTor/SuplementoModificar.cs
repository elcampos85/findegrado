﻿using System;
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
    public partial class SuplementoModificar : Form
    {
        private string grupo = "Suplementos";
        public SuplementoModificar()
        {
            InitializeComponent();

            cbSuplemento.DisplayMember = "Nom_Suplemento";
            cbSuplemento.ValueMember = "Cod_Suplemento";

            cbSuplemento.DataSource = Constantes.suplemento_TA.GetData();

        }

        private void cbSuplemento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSuplemento.SelectedItem != null)
            {
                tbNombre.Text = Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue));
                NPrecio.Value = Convert.ToDecimal(Constantes.suplemento_TA.GetPrecioSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue)));

                //Rellena la imagen
                this.imagen.Image = Image.FromFile(Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(Convert.ToInt32(cbSuplemento.SelectedValue)))+ Constantes.EXTENSION);
                this.imagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre=Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue));
                String nombreNuevo= tbNombre.Text;
                float precio=Convert.ToSingle(NPrecio.Value);
                int codSuplemento= Convert.ToInt32(cbSuplemento.SelectedValue);

                if (verificar(nombreNuevo) || nombre.Equals(nombreNuevo))
                {
                    Constantes.suplemento_TA.UpdateSuplemento(nombreNuevo, Convert.ToDouble(precio), codSuplemento, nombre);
                    MessageBox.Show("Suplemento modificado correctamente");
                }
                else
                {
                    MessageBox.Show("El suplemento ya existe");
                }

                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el suplemento");
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
