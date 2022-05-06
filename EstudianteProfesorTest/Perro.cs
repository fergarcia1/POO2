using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class Perro : Animal
    {
        public Perro()
        {
        }

        public Perro(string nombre) : base(nombre)
        {
            this.nombre = nombre;
        }

        public override void comer()
        {
            Console.WriteLine(this.nombre + " esta comiendo");
        }
    }
}
