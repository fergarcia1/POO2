using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    public class Ubicacion 
    {
        private double x;
        private double y;
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public Ubicacion(double x, double y) { this.x = x; this.y = y; }
        public override string ToString()
        {
            return "Eje X: " + this.X + " Eje Y: " + this.Y;
        }
    }

}
