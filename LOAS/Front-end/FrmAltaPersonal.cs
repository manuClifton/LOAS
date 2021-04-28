using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Front_end
{

    public partial class FrmAltaPersonal : Form
    {
        private Employe oneEmploye;
        private bool flag;
        private int legajoPersonal;

        public FrmAltaPersonal()
        {
            InitializeComponent();
        }

        public Employe OneEmploye
        {
            get { return this.oneEmploye; }
        }
        public int Legajo
        {
            get { return this.legajoPersonal; }
            set { this.legajoPersonal = value; }
        }
        public void SetPersonal()
        {
            Lb_TipoDeAlta.Text = "Alta de Empleado";
            flag = true;
        }


        private void FrmAltaPersonal_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetNames(typeof(EtypeEmploye));
            cmbSector.DataSource = Enum.GetNames(typeof(Esector));
        }

        private void AltaEmpleado()
        {
               if (Lb_TipoDeAlta.Text == "Alta de Empleado")
               {
                   if (Validation.ValidarString(txtNombre.Text) &&
                       Validation.ValidarString(txtApellido.Text) &&
                       Validation.ValidarString(txtDni.Text)
                       )
                   {
                       //if (Validaciones.ValidarString(txtNombre.Text) && Validaciones.ValidarString(txtApellido.Text) )
                       //{

                       //}
                       if ( (cmbSexo.Text == "Femenino" || cmbSexo.Text == "Masculino"))
                       {
                           if (Validation.ValidarEntero(txtDni.Text, 999999999, 1000000))
                           {

                                oneEmploye = new Employe(txtNombre.Text, txtApellido.Text, cmbSexo.Text, int.Parse(txtDni.Text), txtDireccion.Text, (EtypeEmploye)cmbTipo.SelectedItem, legajoPersonal, true, (Esector)cmbSector.SelectedItem, txtCargo.Text);
                                if (!(oneEmploye is null))
                                {
                                    legajoPersonal++;
                                    this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    MessageBox.Show("Algo sucedio EL EMPLEADO ES NULL. Reintentar");
                                }
                           }
                           else
                           {
                               MessageBox.Show("EL DNI DEBE SER UN NUMERO");
                           }

                       }
                       else
                       {
                           MessageBox.Show("Sexo Incorrecto");
                       }
                   }
                   else
                   {
                       MessageBox.Show("Debe completar todos los datos");
                   }

               }
               
        }


        private void AltaNoDocente()
        {
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validation.ValidarString(txtNombre.Text) &&
                    Validation.ValidarString(txtApellido.Text) &&
                    Validation.ValidarString(txtDni.Text) &&
                     cmbSexo.SelectedIndex != -1 &&
                     !(cmbSector.SelectedIndex == -1) &&
                     !(cmbTipo.SelectedIndex == -1)
                    )
            {
                if (flag)

                {
                    this.AltaEmpleado();
                }
                else
                {
                    this.AltaNoDocente();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            
        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected void pictureBtnX_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }//
}//
