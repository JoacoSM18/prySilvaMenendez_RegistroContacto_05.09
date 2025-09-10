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

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        string vContacto = "";
        string vTelefono = "";
        int indice = 0;
        string[] vecContacto = new string[4];
        string[] vecTelefono = new string[4];
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            lstDatos.Show();
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;
            string vDatos = indice + "--" + vContacto + "--" + vTelefono;
            lstDatos.Items.Add (vDatos);
            vecContacto[indice] = vContacto;
            vecTelefono[indice] = vTelefono;
            indice++;
            txtTelefono.Text = "";
            txtContacto.Text = "";
            txtContacto.Focus();
        }
       
        private void frmRegistro_Contactos_Load(object sender, EventArgs e)
        {

        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
