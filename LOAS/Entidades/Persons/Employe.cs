using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entindades;

namespace Entidades
{
    /// <summary>
    /// Enumerado - tipos de empleado y accesibilidad
    /// </summary>
    public enum EtypeEmploye
    {
        SuperAdmin = 1,
        Admin = 2,
        Gerent= 3,
        Director = 4,
        Generic = 5
    }
    /// <summary>
    /// Enumerado - sectores de la institucion
    /// </summary>
    public enum Esector
    {
        Sistemas = 1,
        Tesoreria = 2,
        Gerencia = 3,
        Administracion = 4,
        Juegos = 4,
        Computo = 5,
        Contaduria = 6,
        Presidencia = 7,
        MesaEntrada = 8,
        RecursosHumanos = 9,
        Despacho = 10
    }
    public class Employe : Person
    {
        EtypeEmploye type;
        int leg;
        bool active;
        Esector sector;
        string cargo;

        public Employe() : base() {}
        public Employe(string nombre, string apellido, string sexo, int dni, string direccion, EtypeEmploye type, int leg, bool active, Esector sector,string cargo) : base(nombre, apellido, sexo, dni, direccion)
        {
            this.TypeEmploye = type;
            this.Leg = leg;
            this.Active = active;
            this.Sector = sector;
            this.Cargo = cargo;
        }

        public EtypeEmploye TypeEmploye
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Leg
        {
            get { return this.leg; }
            set { this.leg = value; }
        }
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        public Esector Sector
        {
            get { return this.sector; }
            set { this.sector = value; }
        }
        public string Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

    }//
}//
