using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end
{
    public partial class FrmPersonal : Form
    {
        List<Employe> listEmploye;

        public FrmPersonal()
        {
            InitializeComponent();
        }

        public FrmPersonal(List<Employe> empleados):this()
        {
            listEmploye = empleados;
            CargarTabla();
        }


        private void CargarTabla()
        {
            this.dataGridEmpleados.Rows.Clear();
            int fila = 0;
            foreach (Employe Aux in listEmploye)
            {
                fila = dataGridEmpleados.Rows.Add();
                dataGridEmpleados.Rows[fila].Cells[0].Value = Aux.Nombre;
                dataGridEmpleados.Rows[fila].Cells[1].Value = Aux.Apellido;
                dataGridEmpleados.Rows[fila].Cells[2].Value = Aux.Dni;
                dataGridEmpleados.Rows[fila].Cells[3].Value = Aux.Sexo;
                dataGridEmpleados.Rows[fila].Cells[4].Value = Aux.Sector;
                dataGridEmpleados.Rows[fila].Cells[5].Value = Aux.Cargo;
                dataGridEmpleados.Rows[fila].Cells[6].Value = Aux.Active;
            }
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            dataGridEmpleados.ReadOnly = true;
            dataGridEmpleados.AllowUserToAddRows = false;
            dataGridEmpleados.RowHeadersVisible = false;
        }
    }//
}//
