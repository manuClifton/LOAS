using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Module
    {
        List<Employe> listEmployes;
        public Module()
        {
            listEmployes = new List<Employe>();
        }
        public Employe this[int index]
        {
            get { return this.listEmployes[index]; }
            set { this.listEmployes[index] = value; }
        }


        public static bool operator +(Module mod, Employe emp)
        {

            if (!(mod is null) && !(emp is null))
            {
                if (!(mod.listEmployes.Contains(emp) ))
                {
                    mod.listEmployes.Add(emp);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Module mod1, Module mod2)
        {

            if (!(mod1 is null) && !(mod2 is null))
            {
                if (mod1.colorSala == mod2.colorSala ) // chequear cuando es igual un modulo a otro
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Module mod1, Module mod2)
        {
            return !(mod1 == mod2);
        }




    }//
}//
