using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    public interface Forma
    {
        Ubicacion ubicacion { get; set; }
        double area();
        double perimetro();
        string ToString();
    }
}
