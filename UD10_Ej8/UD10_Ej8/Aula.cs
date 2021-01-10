using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej8
{
    public class Aula
    {
        private int id;
        private int max_est;
        private string materia;

       
        public Aula(int id, int max_est, string materia)
        {
            this.id = id;
            this.max_est = max_est;
            this.materia = materia;
        }

        public Aula()
        {
            id = 0;
            max_est = 0;
            materia = "matematicas";
        }

        public int Id { get => id; set => id = value; }
        public int Max_est { get => max_est; set => max_est = value; }
        public string Materia { get => materia; set => materia = value; }


        public bool isPosibleClase(Profesor profe, int dispo_alum, int max_alum)
        {
            if (profe.Asistencia())
            {
                if(profe.Materia == materia)
                {
                    if(dispo_alum > max_alum / 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
