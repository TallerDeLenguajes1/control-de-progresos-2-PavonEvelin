using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJuegoDeRol
{
    class Personaje
    {
        private string nombre, apellido, apodo;
        private DateTime fechaNac;
        private int edad, salud;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }

        public int calcularEdad(DateTime fechaNac)
        {
            
        }
    }
}
