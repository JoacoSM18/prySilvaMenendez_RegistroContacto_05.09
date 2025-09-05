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
        int vContador = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;
            string vDatos = vContador + "---" + vContacto + "---" + vTelefono;
            lstDatos.Items.Add (vDatos);
            txtTelefono.Text = "";
            txtContacto.Text = "";
            txtContacto.Focus();
        }
       
        private void frmRegistro_Contactos_Load(object sender, EventArgs e)
        {

        }
    }
}
