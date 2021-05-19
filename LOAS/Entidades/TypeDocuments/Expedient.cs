using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TypeDocuments
{
    public class Expedient : Document
    {
        List<Document> listaDocumentos;
        public Expedient() : base() { }
        public Expedient(Employe emisor, Employe receptor) : base(emisor, receptor)
        {
            listaDocumentos = new List<Document>();
        }


    }//
}//
