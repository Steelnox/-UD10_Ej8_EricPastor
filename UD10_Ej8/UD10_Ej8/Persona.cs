using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej8
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        protected char sexo;

        public virtual bool Asistencia()
        {
            return true;
        }
    }
}
