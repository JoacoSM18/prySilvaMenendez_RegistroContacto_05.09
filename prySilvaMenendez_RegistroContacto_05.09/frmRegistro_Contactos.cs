using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_RegistroContacto_05._09
{
    public partial class frmRegistro_Contactos : Form
    {
        public frmRegistro_Contactos()
        {
            InitializeComponent();
        }

        string vContacto = "";
        string vTelefono = "";
        int indice = 1;
        string[] vecContacto = new string[100];
        string[] vecTelefono = new string[100];
        private void frmRegistro_Contactos_Load(object sender, EventArgs e)
        {
            mskTelefono.Select(0, 0);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtContacto.Text == "" || !mskTelefono.MaskFull)
            {
                MessageBox.Show("Datos Incompletos, Por Favor Complete Todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Contacto Agregado Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstDatos.Show();
                vContacto = txtContacto.Text;
                vTelefono = mskTelefono.Text;
                string vDatos = "Contacto " + indice + " - " + vContacto + " - " + vTelefono;
                lstDatos.Items.Add(vDatos);
                vecContacto[indice] = vContacto;
                vecTelefono[indice] = vTelefono;
                indice++;
                mskTelefono.Text = "";
                txtContacto.Text = "";
                txtContacto.Focus();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mskTelefono_Click(object sender, EventArgs e)
        {
            mskTelefono.Select(0,0);
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
