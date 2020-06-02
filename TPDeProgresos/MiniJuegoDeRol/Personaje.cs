using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJuegoDeRol
{
    enum valorMax
    {
        velocidadMax = 10,
        destrezaMax = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    }
    class Personaje
    {
        private string nombre, apellido, apodo;
        private DateTime fechaNac;
        private int edad, salud;
        string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public int calcularEdad(DateTime fechaNac)
        {
            
        }
    }
}
