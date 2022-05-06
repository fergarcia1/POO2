using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class Profesor : Persona
    {
        public Profesor()
        {
        }

        public Profesor(int edad, string nombre) : base(edad, nombre)
        {
        }

        public void explicar()
        {
            Console.WriteLine("Estoy explicando");
        }

        public override string ToString()
        {
            return "Soy profesor mi nombre es: " + this.Nombre;
        }
    }
  
}
