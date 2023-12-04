using Proyecto_ED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_ED.Clases
{
    internal class Arreglo
    {
        private Persona[] jugadores = new Persona[10];
        private int indice = 0;

        public Persona[] Jugadores
        {
            get { return jugadores; }
        }

        public void AgregarJugador(string nombre, int edad, string carrera, string cuatrimestre, string correo)
        {
            if (indice < jugadores.Length)
            {
                Persona nuevoJugador = new Persona
                {
                    Id = indice + 1,
                    Nombre = nombre,
                    Edad = edad,
                    Carrera = carrera,
                    Cuatrimestre = cuatrimestre,
                    Correo = correo
                };

                jugadores[indice] = nuevoJugador;
                indice++;
            }
            else
            {
                Console.WriteLine("El arreglo de jugadores está lleno. No se pueden agregar más jugadores.");
            }
        }

     
        public Persona[] ObtenerJugadores()
        {
            return jugadores;
        }
        public Persona BuscarJugadorPorId(int id)
        {
            foreach (var jugador in jugadores)
            {
                if (jugador != null && jugador.Id == id)
                {
                    return jugador;
                }
            }
            return null; // Retorna null si no se encuentra el jugador con el ID especificado.
        }

        public void ModificarJugador(int id, string nombre, int edad, string carrera, string cuatrimestre, string correo)
        {
            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].Id == id)
                {
                    jugadores[i].Nombre = nombre;
                    jugadores[i].Edad = edad;
                    jugadores[i].Carrera = carrera;
                    jugadores[i].Cuatrimestre = cuatrimestre;
                    jugadores[i].Correo = correo;

                    Console.WriteLine($"Jugador con Id {id} modificado correctamente.");
                    return;
                }
            }

            Console.WriteLine($"No se encontró un jugador con Id {id}.");
        }

        public void EliminarJugador(int id)
        {
            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].Id == id)
                {
               
                    for (int j = i; j < indice - 1; j++)
                    {
                        jugadores[j] = jugadores[j + 1];
                    }

                    indice--;

                   
                    jugadores[indice] = null;

                    Console.WriteLine($"Jugador con Id {id} eliminado correctamente.");
                    return;
                }
            }

            Console.WriteLine($"No se encontró un jugador con Id {id}.");
        }

       
    }

}
