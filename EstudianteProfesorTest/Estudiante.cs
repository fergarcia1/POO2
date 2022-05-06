using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class Estudiante : Persona
    {
        public Estudiante()
        {
        }

        public Estudiante(int edad, string nombre) : base(edad, nombre)
        {
        }

        public void estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public void verEdad()
        {
            Console.WriteLine("Mi edad es: " + this.Edad + " años");
        }
        public override string ToString()
        {
            return "Soy estudiante mi nombre es: " + this.Nombre;
        }
    }
}
