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
        Stack<Document> stackDocuments;
        string name;
        public Module() {}
        protected Module(string name)
        {
            listEmployes = new List<Employe>();
            stackDocuments = new Stack<Document>();
            this.Name = name;
        }
        public Employe this[int index]
        {
            get { return this.listEmployes[index]; }
            set { this.listEmployes[index] = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
        public static bool operator -(Module mod, Employe emp)
        {

            if (!(mod is null) && !(emp is null))
            {
                if (mod.listEmployes.Contains(emp))
                {
                    mod.listEmployes.Remove(emp); // Revisar si elimina el seleccionado
                    return true;
                }
            }
            return false;
        }
        public static bool operator ==(Module mod1, Module mod2)
        {

            if (!(mod1 is null) && !(mod2 is null))
            {
                if (mod1.Name == mod2.Name && mod1.listEmployes == mod2.listEmployes ) // chequear cuando es igual un modulo a otro
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
