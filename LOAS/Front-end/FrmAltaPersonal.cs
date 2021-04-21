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

namespace Clifton.Manuel
{

    public partial class FrmAltaPersonal : Form
    {
        //private Docente unDocente;
        private Employe oneEmploye;
        private bool flag;

        public FrmAltaPersonal()
        {
            InitializeComponent();
        }

        public Employe OneEmploye
        {
            get { return this.oneEmploye; }
        }

        public void SetPersonal()
        {
            Lb_TipoDeAlta.Text = "Alta de Empleado";

            //Lb_Cargo.Visible = false;
            //cmbCargo.Visible = false;
            flag = true;
        }


        private void FrmAlta_Load(object sender, EventArgs e)
        {
            /*
            cmbCargo.DataSource = Enum.GetNames(typeof(ECargo));
            */
            cmbTipo.DataSource = Enum.GetNames(typeof(EtypeEmploye));
            cmbSector.DataSource = Enum.GetNames(typeof(Esector));
        }

        private void AltaDocente()
        {
               bool sexo;
               if (Lb_TipoDeAlta.Text == "Alta de Docente")
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

                                oneEmploye = new Employe(txtNombre.Text, txtApellido.Text, cmbSexo.Text, int.Parse(txtDni.Text), txtDireccion.Text, cmbTipo.Text, legajo, 1, cmbSector.Text, txtCargo.Text); // REVISAR EL LEGAJOM TIPO Y SECTOR YA QUE SON ENUMS
                                if (!(oneEmploye is null))
                                {
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
            /*
            bool sexo;
            if (Lb_TipoDeAlta.Text == "Alta Administrativo")
            {
                if (Validaciones.ValidarString(txtNombre.Text) &&
                    Validaciones.ValidarString(txtApellido.Text) &&
                    Validaciones.ValidarString(txtDni.Text) &&
                    Validaciones.ValidarString(dateTimeHrEntrada.Text) &&
                    Validaciones.ValidarString(dateTimeHrSalida.Text) &&
                     cmbSexo.SelectedIndex != -1 &&
                     !(cmbCargo.SelectedIndex == -1)
                    )
                {
                    if (dateTimeHrEntrada.Text != dateTimeHrSalida.Text && string.Compare(dateTimeHrEntrada.Text, dateTimeHrSalida.Text) == -1 && (cmbSexo.Text == "Femenino" || cmbSexo.Text == "Masculino"))
                    {
                        if (Validaciones.ValidarEntero(txtDni.Text, 999999999, 1000000) && Validaciones.ValidarStringSoloNumeros(txtDni.Text))
                        {
                            if (cmbSexo.Text == "Femenino")
                            {
                                sexo = true;
                            }
                            else
                            {
                                sexo = false;
                            }
                            int entero = 0;
                            switch (cmbCargo.SelectedIndex)
                            {
                                case 0:
                                    entero = 100;
                                    break;
                                case 1:
                                    entero = 110;
                                    break;
                                case 2:
                                    entero = 140;
                                    break;
                                case 3:
                                    entero = 180;
                                    break;
                                case 4:
                                    entero = 240;
                                    break;
                                default:
                                    break;
                            }

                            unNoDocente = new Administrativo(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), sexo, Convert.ToDateTime(dateTimeHrEntrada.Value.ToString()), Convert.ToDateTime(dateTimeHrSalida.Value.ToString()), (ECargo)entero);
                            if (!(unNoDocente is null))
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Algo sucedio EL No Docente ES NULL. Reintentar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL DNI DEBE SER UN NUMERO VALIDO");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hora de entrada y salida invalida o DNI invalido");
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos");
                }

            }
            */
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*
            if (Validaciones.ValidarString(txtNombre.Text) &&
                    Validaciones.ValidarString(txtApellido.Text) &&
                    Validaciones.ValidarString(txtDni.Text) &&
                    Validaciones.ValidarString(dateTimeHrEntrada.Text) &&
                    Validaciones.ValidarString(dateTimeHrSalida.Text) &&
                     cmbSexo.SelectedIndex != -1 &&
                     !(cmbCargo.SelectedIndex == -1)
                    )
            {
                if (flag)
                {
                    this.AltaDocente();
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
            */
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
