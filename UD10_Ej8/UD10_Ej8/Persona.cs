﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej8
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        protected char sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public virtual bool Asistencia()
        {
            return true;
        }
    }
}
