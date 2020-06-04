using System;
using MiniJuegoDeRol;

namespace MiniJuegoDeRol
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje nuevoPersonaje = new Personaje();
            int velocidad = new Random().Next(1 , 11);
            int destreza = new Random().Next(1, 6);
            int fuerza = new Random().Next(1, 11);
            int nivel = new Random().Next(1, 11);
            int armadura = new Random().Next(1, 11);

            string nombre, apodo;
            Console.WriteLine("Ingrese su nombre\n");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apodo\n");
            apodo = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de su tipo de jugador: goblin, orco o duende");
            string tipo = Console.ReadLine();

            string fechaNac;
            Console.WriteLine("Ingrese su fecha de nacimiento con el siguiente formato: 17/03/00\n");
            fechaNac = Console.ReadLine();

            nuevoPersonaje.cargarDatosAleatorios(velocidad, destreza, fuerza, nivel, armadura);

        }
    }
}
