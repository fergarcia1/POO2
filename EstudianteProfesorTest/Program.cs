using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorTest
{
    class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            int opt = Int32.Parse(Console.ReadLine());
            Persona persona1 = new Persona();
            Profesor profesor1 = new Profesor();
            Estudiante estudiante1 = new Estudiante();
            switch (opt)
            {
                case 1:
                    estudiante1.setEdad(16);
                    estudiante1.saludar();
                    estudiante1.estudiar();
                    estudiante1.verEdad();
                    Console.ReadKey();
                    profesor1.setEdad(30);
                    profesor1.saludar();
                    profesor1.explicar();
                    Console.ReadKey();
                    break;
                case 2:
                    Persona estudiante2 = new Estudiante(19, "Juanito");
                    Persona estudiante3 = new Estudiante(20, "Juan");
                    Persona profesor2 = new Profesor(40, "Juanpi");
                    Persona[] personas = new Persona[3];
                    personas[0] = estudiante2;
                    personas[1] = estudiante3;
                    personas[2] = profesor2;
                    int i = 0;
                    while(i < personas.Length)
                    {
                        Console.WriteLine(personas[i]);
                        
                        i++;
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Circulo circulo = new Circulo(20, 5, 6);
                    Rectangulo rectangulo = new Rectangulo(10,12,10,12);

                    Console.WriteLine("Area circulo: " + circulo.area());
                    Console.WriteLine("Area Rectangulo: " + rectangulo.area());


                    break;
                case 4:
                    Coche auto = new Coche(0);
                    Console.Write("Cuanto desea cargar: ");
                    bool cargo = auto.cargarNafta(double.Parse(Console.ReadLine()));
                    if(cargo == true)
                    {
                        Console.WriteLine(auto.ToString());
                    }
                    Console.ReadKey();

                    break;
                case 5:
                    Perro perrito = new Perro("Cartu");
                    perrito.comer();
                    break;
            }
           

        }
        
    }
}
