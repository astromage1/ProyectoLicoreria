using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoChico
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Conectar

            string usuario = txtContraseña.Text;
            string contraseña = txtUsuario.Text;

            if(usuario=="Admin" && contraseña == "Admin"){

            
                frmInicio inicio = new frmInicio();
                inicio.Show();
                this.Hide();
            }
            else{

                MessageBox.Show("Contraseña y/o usuario incorrecto");
            }
        }
    }
}
