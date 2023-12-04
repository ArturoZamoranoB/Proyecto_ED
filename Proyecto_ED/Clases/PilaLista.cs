using Proyecto_ED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ED.Clases
{
    public class PilaLista
    {
        private Nodo cabeza;
        private int indice = 0;
        public PilaLista()
        {
            cabeza = null;
        }

        public void AgregarJugadorPila(string nombre, int edad, string carrera, string cuatrimestre, string correo)
        {
            Persona nuevoJugador = new Persona
            {
                Id = ObtenerNuevoId(),
                Nombre = nombre,
                Edad = edad,
                Carrera = carrera,
                Cuatrimestre = cuatrimestre,
                Correo = correo
            };

            Nodo nuevoNodo = new Nodo(nuevoJugador);

   
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
        }



        public Persona[] ObtenerJugadores()
        {
           
            Persona[] jugadores = new Persona[ObtenerCantidadJugadores()];

          
            Nodo actual = cabeza;
            int indice = 0;
            while (actual != null)
            {
                jugadores[indice] = actual.Jugador;
                indice++;
                actual = actual.Siguiente;
            }

            return jugadores;
        }

        public Persona BuscarJugadorPorId(int id)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Jugador.Id == id)
                {
                    return actual.Jugador;
                }
                actual = actual.Siguiente;
            }
            return null; 
        }
        public int ObtenerNuevoId()
        {
         
            int ultimoId = ObtenerUltimoId();
            return ultimoId + 1;
        }


        public void ModificarJugadorPila(int id, string nombre, int edad, string carrera, string cuatrimestre, string correo)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Jugador.Id == id)
                {
                    actual.Jugador.Nombre = nombre;
                    actual.Jugador.Edad = edad;
                    actual.Jugador.Carrera = carrera;
                    actual.Jugador.Cuatrimestre = cuatrimestre;
                    actual.Jugador.Correo = correo;
                    return;
                }
                actual = actual.Siguiente;
            }

            Console.WriteLine($"No se encontró un jugador con Id {id}.");
        }


        public void EliminarJugadorPila(int id)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            cabeza = cabeza.Siguiente;
            Console.WriteLine("Jugador eliminado correctamente.");
        }


        private int ObtenerUltimoId()
        {
            Nodo actual = cabeza;
            while (actual != null && actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                return actual.Jugador.Id;
            }

            return 0; // Retorna 0 si la lista está vacía.
        }

        private int ObtenerCantidadJugadores()
        {
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }
    }
}

