using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3operaciones_básicas_de_pilasArrays
{
    internal class Cola
    {
        private int[] cola;
        private int frente;
        private int rear;
        private int tamaño;
        private int capacidad;

        public Cola(int capacidad)
        {
            this.capacidad = capacidad;
            cola = new int[capacidad];
            frente = 0;
            rear = -1;
            tamaño = 0;
        }

        public bool EstaVacia()
        {
            return tamaño == 0;
        }

        public bool EstaLlena()
        {
            return tamaño == capacidad;
        }

        public void Encolar(int elemento)
        {
            if (EstaLlena())
            {
                Console.WriteLine("Error: Cola llena. No se puede encolar.");
            }
            else
            {
                rear = (rear + 1) % capacidad;
                cola[rear] = elemento;
                tamaño++;
                Console.WriteLine($"Elemento {elemento} encolado.");
            }
        }

        public int Desencolar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("Error: Cola vacía. No se puede desencolar.");
                return -1; // Retorna un valor negativo para indicar error
            }
            else
            {
                int elemento = cola[frente];
                frente = (frente + 1) % capacidad;
                tamaño--;
                Console.WriteLine($"Elemento {elemento} desencolado.");
                return elemento;
            }
        }

        public int ObtenerFrente()
        {
            if (EstaVacia())
                return -1; // Retorna -1 si la cola está vacía
            return cola[frente];
        }
    }

    // Ejemplo de uso de la cola
    public class Program
    {
        public static void Main(string[] args)
        {
            Cola cola = new Cola(5);
            cola.Encolar(10);
            cola.Encolar(20);
            cola.Encolar(30);
            Console.WriteLine($"Elemento al frente: {cola.ObtenerFrente()}");
            cola.Desencolar();
            Console.WriteLine($"Elemento al frente: {cola.ObtenerFrente()}");
        }
    }
}

