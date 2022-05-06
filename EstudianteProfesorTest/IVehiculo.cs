using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    interface IVehiculo
    {
        void conducir();
        bool cargarNafta(double cargar);
        string ToString();
    }
}
