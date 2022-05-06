using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    abstract class Animal
    {
        protected string nombre;

        public Animal()
        {

        }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        abstract public void comer();
       
       
    }
}
