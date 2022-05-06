using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class Coche : IVehiculo
    {
        private double gasolina;
        public Coche(double gasolina)
        {
            this.gasolina = gasolina;
        }
        public  void conducir()
        {
            if(this.gasolina > 0)
            Console.WriteLine("Conduciendo...");
        }
        public  bool cargarNafta(double cargar)
        {
            this.gasolina += cargar;
            return true;
        }
        public override string ToString()
        {
            return "La nafta actual es: " + this.gasolina;
        }
    }
}
