using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Entidades;
using Excepciones;

namespace Front_end
{
    public partial class FrmSuperAdmin : Form
    {
        
        string Path = @"C:\Users\\MSISTEMAS\Desktop\";

        /* Formularios*/
        //Forms Hijos del Principal
        FrmPersonal instListPersonal;

        //Forms Modal
        FrmAltaPersonal instAltaPersonal;

        //Forms Altas

        //Frm Bajas

        //Frm Modificar

        /* Declaracion de Entidades */

        List<Employe> listEmploye;

        /* logica para asignar legajo automarico */
        int legajo = 1000;

        public FrmSuperAdmin()
        {
            InitializeComponent();

            /* inicializar entidades */
            this.ListEmploye = new List<Employe>();

           harcodear();
        }

        /* Propiedades de entidades para acceder externamente */
        public List<Employe> ListEmploye
        {
            get { return this.listEmploye; }
            set { this.listEmploye = value; }
        }

        //public List<Docente> DocentesNoDisponibles
        //{
        //    get { return this.docentesNoDisponibles; }
        //    set { this.docentesNoDisponibles = value; }
        //}


        //metodo para mostrar forms hijos en los paneles 1 y 2
        #region frmHijos
        public void AbrirFormHijo(object formHijo)
        {
            if (this.panelContenedor1.Controls.Count > 0)
            {
                this.panelContenedor1.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor1.Controls.Add(fh);
            this.panelContenedor1.Tag = fh;
            fh.Show();
        }

        /*
        public void AbrirFormHijo2(object formHijo)
        {
            if (this.panelContenedor2.Controls.Count > 0)
            {
                this.panelContenedor2.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor2.Controls.Add(fh);
            this.panelContenedor2.Tag = fh;
            fh.Show();
        }    */
        #endregion


        //Harcodeo
        #region Harcodeo
        public void harcodear()
        {
            //    // string Direccion = @"C:\Users\manu_\Desktop\Parcial_Laboratorio2\Parcial 1 Laboratorio  2\Clifton.Manuel\bin\Debug";

            //Empleados
            this.ListEmploye.Add(new Employe("Manuel", "Clifton", "Masculino", 36105581, "Pto. San Julian 90", EtypeEmploye.SuperAdmin, 00001, true, Esector.Sistemas, "Director Servicios Informaticos"));
           
        //    //No Docente
        //    noDocentes.Add(new Administrativo("Maria", "Gonzalez", 25123456, true, Convert.ToDateTime("1/2/2000 07:00:00 AM"), Convert.ToDateTime("20:00:00"), ECargo.Cocina));

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\NoDocentes.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Administrativo>)));

        //        ser.Serialize(Escribir, NoDocentes);
        //    }

        //    //ALUMNOS
        //    alumnosSinAula.Add(new Alumno("Reeta", "Imrie", 248844921, true, 1));
        //    alumnosSinAula[0].Responsable = responsables[0];
        //    alumnosSinAula[0].Legajo = legajo;
        //    legajo++;



        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosConAula.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));
        //        //ser.Serialize(Escribir, AlumnosConAula);
        //    }

        //    using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Aulas.xml", Encoding.UTF8))
        //    {
        //        XmlSerializer ser = new XmlSerializer((typeof(List<Aula>)));
        //        //ser.Serialize(Escribir, Aulas);
        //    }

        }//Fin Harcodeo
        #endregion

        //MENUES
        #region menues
        private void ocultarSubMenu()
        {
            if (panelSubMenuArchivo.Visible == true)
            {
                panelSubMenuArchivo.Visible = false;
            }
            else if (panelSubMenuReporte.Visible == true)
            {
                panelSubMenuReporte.Visible = false;
            }
        }

        //Hace visuble el submenu de cada boton
        private void showSubMenu(Panel subMenu)
        {

            switch (subMenu.Name)
            {
                case "panelSubMenuArchivo":
                        if (subMenu.Visible == false)
                        {
                        subMenu.Visible = true;
                         }
                        else
                         {
                            subMenu.Visible = false;
                            panelSubAltas.Visible = false;
                            panelSubBajas.Visible = false;
                            panelSubModificar.Visible = false;
                        }
                        subMenu.Width = 141;
                        subMenu.Height = 125;
                   
                    break;
                case "panelSubMenuReporte":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                    }
                    else
                    {
                        subMenu.Visible = false;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 200;
                    

                    break;
                case "panelSubAltas":
               
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 250;
                        panelSubBajas.Visible = false;
                        panelSubModificar.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 125;
                    break;
                case "panelSubBajas":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 285;
                        panelSubAltas.Visible = false;
                        panelSubModificar.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 160;
                    break;
                case "panelSubModificar":
                    if (subMenu.Visible == false)
                    {
                        subMenu.Visible = true;
                        panelSubMenuArchivo.Height = 285;
                        panelSubBajas.Visible = false;
                        panelSubAltas.Visible = false;
                    }
                    else
                    {
                        subMenu.Visible = false;
                        panelSubMenuArchivo.Height = 133;
                    }
                    subMenu.Width = 141;
                    subMenu.Height = 160;
                    break;
            }
        }
        #endregion

        //  Archivo y SUBMENUS PRINCIPALES
        #region Archivo
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            showSubMenu(panelSubMenuArchivo);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubAltas);
        }
        private void btnBajas_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubBajas);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubModificar);
        }




        // BOTONES DE ALTA
        #region

        private void btnAltaModulo_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAltaAlumno = new FrmAltaAlumno();
            instAltaAlumno.Legajo = legajo;
            instAltaAlumno.ListResponsables = Responsables;
            if (instAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                this.alumnosSinAula.Add(instAltaAlumno.UnAlumno);
                legajo = instAltaAlumno.Legajo;
                // instAlumnos = new FrmAlumnos(alumnosSinAula, "Sin Aula");
                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = alumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta del Alumno");
            }
            */
        }

        private void btnAltaDocumento_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAlta = new FrmAltaPersonal();
            instAlta.SetDocente();
            if (instAlta.ShowDialog() == DialogResult.OK)
            {
                this.Docentes.Add(instAlta.UnDocente);
                instDocentes = new FrmDocente(Docentes);
                this.AbrirFormHijo(instDocentes);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta del Docente");
            }
            */
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            instAltaPersonal = new FrmAltaPersonal();
            instAltaPersonal.SetPersonal();
            instAltaPersonal.Legajo = legajo;
            if (instAltaPersonal.ShowDialog() == DialogResult.OK)
            {
                this.ListEmploye.Add(instAltaPersonal.OneEmploye);
                instListPersonal = new FrmPersonal(ListEmploye);             // AGREGAR EL FORMULARIOHIJO DE PERSONAL
                this.AbrirFormHijo(instListPersonal);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta del Personal");
            }
        }

        private void btnAltaAula_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();


            instAltaAula = new FrmAltaAula();
            instAltaAula.ListAlumnosConAula = AlumnosConAula;
            instAltaAula.ListAlumnosSinAula = AlumnosSinAula;
            instAltaAula.ListDocentesDisponibles = docentes;
            instAltaAula.ListAulas = Aulas;


            if (instAltaAula.ShowDialog() == DialogResult.OK)
            {
                this.Aulas = instAltaAula.ListAulas;
                this.AlumnosSinAula = instAltaAula.ListAlumnosSinAula;
                this.AlumnosConAula = instAltaAula.ListAlumnosConAula;
                this.Docentes = instAltaAula.ListDocentesDisponibles;

                this.instAula = new FrmAula(Aulas);
                this.AbrirFormHijo(instAula);
                this.instAlumnos = new FrmAlumnos();
                this.instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                this.instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            else
            {
                MessageBox.Show("Se cancelo el Alta de Aula");
            }
            */
        }
        #endregion


        //BOTONES DE BAJA     -- ANDA PERO HAY QUE REVISAR
        private void btnBajaModulo_Click(object sender, EventArgs e)
        {/*
            instBaja = new FrmBaja();
            instBaja.ListAlumnosConAula = AlumnosConAula;
            instBaja.ListAlumnosSinAula = AlumnosSinAula;
            instBaja.ListAulas = Aulas;
            instBaja.CargarFormAlumno();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instBaja.ListAlumnosConAula;
                AlumnosSinAula = instBaja.ListAlumnosSinAula;
                Aulas = instBaja.ListAulas;

                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            */
        }
        private void btnBajaDocumento_Click(object sender, EventArgs e)
        {/*
            instBaja = new FrmBaja();
            instBaja.ListResponsables = Responsables;
            instBaja.ListAlumnosConAula = AlumnosConAula;
            instBaja.ListAlumnosSinAula = AlumnosSinAula;
            instBaja.CargarFormResponsable();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                Responsables = instBaja.ListResponsables;
                AlumnosConAula = instBaja.ListAlumnosConAula;
                AlumnosSinAula = instBaja.ListAlumnosSinAula;

                instResponsables = new FrmResponsables(Responsables);
                this.AbrirFormHijo2(instResponsables);
            }
            */
        }
        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {/*
            instBaja = new FrmBaja();
            instBaja.ListDocentes = Docentes;
            instBaja.ListAulas = Aulas;
            instBaja.CargarFormDocente();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                Docentes = instBaja.ListDocentes;
                Aulas = instBaja.ListAulas;

                instDocentes = new FrmDocente(Docentes);
                this.AbrirFormHijo(instDocentes);
            }
            */
        }
        private void btnBajaAdministrativo_Click(object sender, EventArgs e)
        {/*
            instBaja = new FrmBaja();
            instBaja.ListAdministrativo = NoDocentes;
            instBaja.CargarFormAdministrativo();
            if (instBaja.ShowDialog() == DialogResult.OK)
            {
                NoDocentes = instBaja.ListAdministrativo;

                instNoDocente = new FrmNoDocente(NoDocentes);
                this.AbrirFormHijo(instNoDocente);
            }
            */
        }
        private void btnBajaAula_Click(object sender, EventArgs e)
        {/*
            instBajaAula = new FrmBajaAula();
            instBajaAula.ListAlumnosConAula = AlumnosConAula;
            instBajaAula.ListAlumnosSinAula = AlumnosSinAula;
            instBajaAula.ListAulas = Aulas;
            if (instBajaAula.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instBajaAula.ListAlumnosConAula;
                AlumnosSinAula = instBajaAula.ListAlumnosSinAula;
                Aulas = instBajaAula.ListAulas;

                instAula = new FrmAula(Aulas);
                this.AbrirFormHijo(instAula);

            }
            */
        }
        //BOTONES DE MOFICICAR
        private void btnEditarModulo_Click(object sender, EventArgs e)
        {/*
            instEditarAlumno = new FrmEditarAlumno();
            instEditarAlumno.ListAlumnosConAula = AlumnosConAula;
            instEditarAlumno.ListAlumnosSinAula = AlumnosSinAula;
            instEditarAlumno.ListResponsables = Responsables;
            instEditarAlumno.ListAulas = Aulas;
            if (instEditarAlumno.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instEditarAlumno.ListAlumnosConAula;
                AlumnosSinAula = instEditarAlumno.ListAlumnosSinAula;
                Aulas = instEditarAlumno.ListAulas;

                instAlumnos = new FrmAlumnos();
                instAlumnos.ListAlumnosSinAula = AlumnosSinAula;
                instAlumnos.CargarSinAula();
                this.AbrirFormHijo2(instAlumnos);
            }
            */
        }
        private void btnEditarDocumento_Click(object sender, EventArgs e)
        {/*
            instEditarResponsable = new FrmEditarResponsable();
            instEditarResponsable.ListAlumnosConAula = AlumnosConAula;
            instEditarResponsable.ListAlumnosSinAula = AlumnosSinAula;
            instEditarResponsable.ListResponsables = Responsables;
            instEditarResponsable.ListAulas = Aulas;
            if (instEditarResponsable.ShowDialog() == DialogResult.OK)
            {
                AlumnosConAula = instEditarResponsable.ListAlumnosConAula;
                AlumnosSinAula = instEditarResponsable.ListAlumnosSinAula;
                Responsables = instEditarResponsable.ListResponsables;
                Aulas = instEditarResponsable.ListAulas;

                instResponsables = new FrmResponsables(Responsables);
                this.AbrirFormHijo2(instResponsables);
            }
            */
        }
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            //TERMINAR EDITAR DOCENTE
        }
        private void btnEditarAdministrtivo_Click(object sender, EventArgs e)
        {/*
            instEditarAdministrativo = new FrmEditarAdministrativo();
            instEditarAdministrativo.ListAdministrativos = NoDocentes;
            if (instEditarAdministrativo.ShowDialog() == DialogResult.OK)
            {
                NoDocentes = instEditarAdministrativo.ListAdministrativos;

                instNoDocente = new FrmNoDocente(NoDocentes);
                this.AbrirFormHijo(instNoDocente);
            }*/
        }
        private void btnEditarAula_Click(object sender, EventArgs e)
        {

        }

        #endregion//FIN MENUES PRINCIPALES

        //Reporte y SubMenu
        #region Reporte

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            sonido.Play();

            showSubMenu(panelSubMenuReporte);
        }

        /* Botones de formularios hijos dentro del principal */
        private void btnInfoPadres_Click(object sender, EventArgs e)
        {
            /* inicializo y lo formularios hijos en el form principal */
           /* instListadoPadres = new FrmListadoPadres(aulas);
            instListadoPadres.Show(); */
        }

        private void btnSueldoDocente_Click(object sender, EventArgs e)
        {/*
            instDinero = new FrmDinero();
            instDinero.ListDocentes = docentes;
            instDinero.CargarSueldoDocentes();
            instDinero.ShowDialog();*/
        }

        private void btnSueldoNoDocente_Click(object sender, EventArgs e)
        {/*
            instDinero = new FrmDinero();
            instDinero.ListNoDocentes = noDocentes;
            instDinero.CargarSueldoNoDocentes();
            instDinero.ShowDialog(); */

        }

        private void btnRecTotalJardin_Click(object sender, EventArgs e)
        {/*
            instDinero = new FrmDinero();
            instDinero.ListAlumnoSinAula = alumnosSinAula;
            instDinero.ListAlumnoConAula = alumnosConAula;
            instDinero.CargarRecaudacionTotal();
            instDinero.ShowDialog(); */
        }

        private void btnAumnosPorAula_Click(object sender, EventArgs e)
        {/*
            if (aulas.Count > 0)
            {
                instAlumnosPorAula = new FrmAlumnosPorAula(alumnosConAula, aulas);
                instAlumnosPorAula.Show();
            }
            else
            {
                MessageBox.Show("NO existen las aulas ahora es todo por intenet #QUEDATEENCASA \n\nCREA UN AULA PRIMERO =)");
            }
            */
        }

        #endregion



        // Botones
        #region BOTONES PRINCIPALES
        private void btnAdministracion_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (aulas.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Aula.");
            }
            else
            {
               AbrirFormHijo(instAula);
            }*/
        }

        private void btnTesoreria_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (noDocentes.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un No Docente.");
            }
            else
            {
                AbrirFormHijo(instNoDocente);
            }*/
        }

        
        private void btnSistemas_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (docentes.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Docente.");
            }
            else
            {
                AbrirFormHijo(instDocentes);
            }*/
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();

            if (responsables.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Responsable.");
            }
            else
            {
                AbrirFormHijo2(instResponsables);
            }*/
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {/*
            SoundPlayer sonido = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            sonido.Play();



            if (alumnosSinAula.Count == 0 && alumnosConAula.Count == 0)
            {
                MessageBox.Show("Primero debe dar de alta un Alumno.");
            }
            else
            {
                if (MessageBox.Show("Con aula asignada ?", "Mostrar Alumnos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    instAlumnos = new FrmAlumnos();
                    instAlumnos.ListAlumnosConAula = alumnosConAula;
                    instAlumnos.CargarConAula();
                    AbrirFormHijo2(instAlumnos);
                }
                else
                {
                    instAlumnos = new FrmAlumnos();
                    instAlumnos.ListAlumnosSinAula = alumnosSinAula;
                    instAlumnos.CargarSinAula();
                    AbrirFormHijo2(instAlumnos);
                }
            }*/
        }
        #endregion


        //TIME Y LOAD
        #region TIME Y LOAD
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_Timer.Text = DateTime.Now.ToString("hh:mm:ss");
            Lb_Fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            /* Serializacion de archivo XML */

            /*
            using (XmlTextReader Leer = new XmlTextReader(Path + "\\AlumnosSinAula.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Alumno>));

                alumnosSinAula = (List<Alumno>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\AlumnosConAula.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Alumno>));

                alumnosConAula = (List<Alumno>)ser.Deserialize(Leer);
            }
            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Aulas.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Aula>));

                aulas = (List<Aula>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Responsables.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Responsable>));

                responsables = (List<Responsable>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\Docentes.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Docente>));

                docentes = (List<Docente>)ser.Deserialize(Leer);
            }

            using (XmlTextReader Leer = new XmlTextReader(Path + "\\NoDocentes.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Administrativo>));

                noDocentes = (List<Administrativo>)ser.Deserialize(Leer);
            }

            */
            //Fin Serializacion

            /* Instacio los formularios hijos y abro 2 en el formulario principal */
            /*
            instNoDocente = new FrmNoDocente(noDocentes);
            instResponsables = new FrmResponsables(responsables);
            instAula = new FrmAula(aulas);

            instAlumnos = new FrmAlumnos();
            instAlumnos.ListAlumnosSinAula = alumnosSinAula;
            instAlumnos.CargarSinAula();

            instDocentes = new FrmDocente(docentes);
            AbrirFormHijo(instDocentes);
            AbrirFormHijo2(instAlumnos);
            */
            instListPersonal = new FrmPersonal(ListEmploye);
            AbrirFormHijo(instListPersonal);
        }




        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Cerrando Programa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
                /* Serializo para guardar los cambios en las lisas de entidades */
                /*
                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Docentes.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Docente>)));

                    ser.Serialize(Escribir, docentes);
                }
                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\NoDocentes.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Administrativo>)));

                    ser.Serialize(Escribir, noDocentes);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Responsables.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Responsable>)));

                    ser.Serialize(Escribir, responsables);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosSinAula.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));

                    ser.Serialize(Escribir, alumnosSinAula);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\AlumnosConAula.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Alumno>)));
                    ser.Serialize(Escribir, alumnosConAula);
                }

                using (XmlTextWriter Escribir = new XmlTextWriter(Path + "\\Aulas.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Aula>)));
                    ser.Serialize(Escribir, aulas);
                }
                */
            }

        }





        //private void btnHardcodear_Click(object sender, EventArgs e)
        //{
        //    harcodear();
        //    instNoDocente = new FrmNoDocente(noDocentes);
        //    instResponsables = new FrmResponsables(responsables);
        //    instAula = new FrmAula(aulas);

        //    instAlumnos = new FrmAlumnos();
        //    instAlumnos.ListAlumnosSinAula = alumnosSinAula;
        //    instAlumnos.CargarSinAula();

        //    instDocentes = new FrmDocente(docentes);
        //    AbrirFormHijo(instDocentes);
        //    AbrirFormHijo2(instAlumnos);
        //    btnHardcodear.Enabled = false;
        //    btnHardcodear.Visible = false;
        //}


    }//
}//
