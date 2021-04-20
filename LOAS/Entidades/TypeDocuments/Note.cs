using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Note : Document
    {
        public Note() : base() { }
        public Note(Employe emisor, Employe receptor) : base(emisor, receptor)
        {

        }
    }//
}//
