using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrderAcquisition : Document
    {
        public OrderAcquisition() : base() { }
        public OrderAcquisition(Employe emisor, Employe receptor) : base(emisor, receptor)
        {

        }

    }//
}//
