using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Document
    {
        protected static DateTime fechaCreacion = new DateTime();
        protected static string entidad = "L.O.A.S";
        protected Employe emisor;
        protected Employe receptor;
        //agregar arrray de estados [creado-ejecucion-listo-termiando-cancelado]
        protected string[] estados = new string[] { "creado", "ejecucion", "listo", "termiando", "cancelado" };
        protected string estadoActual;
        public Document(){ }

        protected Document(Employe emisor, Employe receptor)
        {
            this.Emisor = emisor;
            this.Reseptor = receptor;
            this.EstadoActual = "creado";
        }
        public Employe Emisor
        {
            get { return this.emisor; }
            set { this.emisor = value; }
        }
        public Employe Reseptor
        {
            get { return this.receptor; }
            set { this.receptor = value; }
        }
        public string EstadoActual
        {
            get { return this.estadoActual; }
            set { this.estadoActual = value; }
        }


    }//
}//
