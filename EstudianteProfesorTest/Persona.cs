using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class Persona
    {
        private int edad;
        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(int edad, string nombre)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }
        public Persona()
        {
        }




        public void saludar() 
        {
            Console.WriteLine("Hola");
        }
        public void setEdad(int edad)
        {
            this.Edad = edad;
        }

        public void setEdad() { }
        public void mostrar() { }
        public override string ToString()
        {
            return "Nombre: " + this.Nombre;
        }



    }
}
