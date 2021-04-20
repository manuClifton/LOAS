using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circular : Document
    {
        public Circular() : base() { }
        public Circular(Employe emisor, Employe receptor) : base(emisor, receptor)
        {

        }

    }//
}//
