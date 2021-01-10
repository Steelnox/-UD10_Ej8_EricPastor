using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej8
{
    public class Profesor : Persona
    {
        private string materia;

        public Profesor()
        {
            this.nombre = "";
            this.edad = 20;
            this.sexo = 'H';
            this.materia = "matematicas";
        }

        public Profesor(string nombre, int edad, char sexo, string materia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.materia = materia;
        }

        public string Materia { get => materia; set => materia = value; }

        public override bool Asistencia()
        {
            Random random_asis = new Random();
            int num_asis = 0;
            num_asis = random_asis.Next(1, 11);

            if (num_asis <= 2) disponible = false;
            else disponible = true;

            return disponible;
        }
    }
}
