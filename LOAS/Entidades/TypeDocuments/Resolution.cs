using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Resolution : Document
    {
        public Resolution() : base() { }
        public Resolution(Employe emisor, Employe receptor) : base(emisor,receptor)
        {

        }

    }//
}//
