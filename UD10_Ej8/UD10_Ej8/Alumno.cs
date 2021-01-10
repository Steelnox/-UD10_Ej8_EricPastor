using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej8
{
    public class Alumno : Persona
    {
        private int nota;

        public Alumno()
        {
            this.nombre = "";
            this.edad = 10;
            this.sexo = 'H';
            this.nota = 0;
        }

        public Alumno(string nombre, int edad, char sexo, int nota)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.nota = nota;
        }

        public int Nota { get => nota; set => nota = value; }

        public override bool Asistencia()
        {
            Random random_asis = new Random();
            int num_asis = 0;
            num_asis = random_asis.Next(1, 11);

            if (num_asis <= 5) return false;
            else return true;
        }
    }
}
