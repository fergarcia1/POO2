using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
     public class Rectangulo : Forma
    {
        protected double lado1 { get; set; }
        protected double lado2 { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Rectangulo(int lado1, int lado2, int posx, int posy)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.ubicacion = new Ubicacion(posx, posy);
        }
        public double area() { return lado1 * lado2; }
        public double perimetro() { return lado1 * 2 + lado2 * 2; }
        public override string ToString()
        {
            return "Coordenadas del rectangulo: " + ubicacion.ToString();
        }
    }
}
