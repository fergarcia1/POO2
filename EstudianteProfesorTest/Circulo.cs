using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    public class Circulo : Forma
    {
        public double radio { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Circulo(double radio, int posx, int posy)
        {
            this.radio = radio;
            this.ubicacion = new Ubicacion(posx, posy);
        }
        public double area() { return Math.Pow(Math.PI * radio, 2); }
        public double perimetro() { return 2 * Math.PI * radio; }
        public override string ToString()
        {
            return "Coordenadas del circulo : " + ubicacion.ToString();
        }
    }
}
