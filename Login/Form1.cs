using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormBg : Form
    {
        public FormBg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea cerrar la aplicacion?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                

                if (r == DialogResult.Yes)
                {
                Application.Exit();
                }
           
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {
          if (TxtUsuario.Text == "Ingrese su usuario")
            {
               TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
          
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
           if (BtnEntrar.Text == "Ingrese su contraseña")
            {
              BtnEntrar.Text = "";
                BtnEntrar.ForeColor = Color.Black;
               
            }

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Ingrese su contraseña";
                TxtContraseña.ForeColor = Color.Black;
            }
        }
    }
}
