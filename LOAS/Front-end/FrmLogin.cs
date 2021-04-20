using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Front_end
{
    public partial class FrmLogin : Form
    {
        FrmSuperAdmin frmPrincipal;
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = String.Empty;
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == String.Empty)
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = String.Empty;
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == String.Empty)
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUser.Text)) && !(string.IsNullOrEmpty(txtPass.Text)))
            {
                if (txtUser.Text == "Manuel" && txtPass.Text == "123456")
                {

                    Lb_Error.Text = "";
                    frmPrincipal = new FrmSuperAdmin();
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    Lb_Error.Text = "Acceso Denegado. Reintente Nuevamente!";
                  //  BorrarError("Acceso Denegado. Reintente Nuevamente!");
                 
                } // EL ERROR ESTA EN QUE ESCRIBE EN EL FORM DESPUES QUE TERMINA EL EVENTO CLICK

            }
            else
            {
                // Lb_Error.Text = "Campos no pueden ser vacios";
                BorrarError("Campos no pueden ser vacios");
            }
        }

        public void BorrarError(string text)
        {
             Thread.Sleep(3000);

            Lb_Error.Text = string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



    }//
}//
