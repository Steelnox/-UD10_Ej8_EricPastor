using System;
using System.Collections.Generic;

namespace UD10_Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profe = new Profesor("Manuel", 50, 'H', "filosofia");

            Alumno[] array_alum = new Alumno[6];
            array_alum[0] = new Alumno("Eric", 27, 'H', 6);
            array_alum[1] = new Alumno("Laia", 22, 'M', 9);
            array_alum[2] = new Alumno("Andreu", 21, 'H', 7);
            array_alum[3] = new Alumno("Sidney", 18, 'M', 2);
            array_alum[4] = new Alumno("Raquel", 17, 'M', 1);
            array_alum[5] = new Alumno("Matias", 19, 'H', 0);

            Aula aul = new Aula(5, 20, "filosofia");

            int cant_disponible = 0;
            List<Alumno> lista_alumnas = new List<Alumno>();
            List<Alumno> lista_alumnos = new List<Alumno>();


            for (int i = 0; i < array_alum.Length; i++)
            {
                if (array_alum[i].Asistencia())
                {
                    cant_disponible++;
                }

                if(array_alum[i].Sexo == 'H')
                {
                    lista_alumnos.Add(array_alum[i]);
                }

                else if(array_alum[i].Sexo == 'M')
                {
                    lista_alumnas.Add(array_alum[i]);
                }
            }

            if (aul.isPosibleClase(profe, cant_disponible, array_alum.Length))
            {
                Console.WriteLine("Las siguientes alumnas están aprobadas:");
                foreach (Alumno a in lista_alumnas)
                {
                    if(a.Nota >= 5 )
                    {
                        Console.WriteLine("La alumna {0} con un {1}", a.Nombre, a.Nota);
                    }
                }

                Console.WriteLine("Los siguientes alumnos están aprobados:");
                foreach (Alumno a in lista_alumnos)
                {
                    if (a.Nota >= 5)
                    {
                        Console.WriteLine("El alumno {0} con un {1}", a.Nombre, a.Nota);
                    }
                }
            }
            
            else
            {
                Console.WriteLine("No es posible dar clase");
            }
        }
    }
}
