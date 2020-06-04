using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJuegoDeRol
{
    /*
    public enum tipos
    {
        goblin,
        orco,
        duende
    }*/

    public class Personaje
    {
        private string nombre, apodo;
        private string tipo;
        private int velocidad, destreza, fuerza, nivel, armadura, edad;
        private DateTime fechaNac;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public string[] Tipo { get => tipo; set => tipo = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }

        public int calcularEdad()
        {
            return edad = DateTime.Now.Year - fechaNac.Year;
        }

        public void cargarDatosAleatorios(int velocidad1, int destreza1, int fuerza1, int nivel1, int armadura1)
        {
            velocidad = velocidad1;
            destreza = destreza1;
            fuerza = fuerza1;
            nivel = nivel1;
            armadura = armadura1;
        }

        public void cargarDatos(string nombre1, string apodo1, string tipo1,)
        {
            nombre = nombre1;
            apodo = apodo1;
            tipo = tipo1;
            fechaNac = 
        }
    }
}
