using System;

public class Pila
{
    private int[] pila;
    private int top;
    private int capacidad;

    public Pila(int capacidad)
    {
        this.capacidad = capacidad;
        pila = new int[capacidad];
        top = -1; // Inicialmente, la pila está vacía
    }

    public bool EstaVacia()
    {
        return top == -1;
    }

    public bool EstaLlena()
    {
        return top == capacidad - 1;
    }

    public void Apilar(int elemento)
    {
        if (EstaLlena())
        {
            Console.WriteLine("Error: Pila llena. No se puede apilar.");
        }
        else
        {
            pila[++top] = elemento;
            Console.WriteLine($"Elemento {elemento} apilado.");
        }
    }

    public int Desapilar()
    {
        if (EstaVacia())
        {
            Console.WriteLine("Error: Pila vacía. No se puede desapilar.");
            return -1; // Retorna un valor negativo para indicar error
        }
        else
        {
            int elemento = pila[top--];
            Console.WriteLine($"Elemento {elemento} desapilado.");
            return elemento;
        }
    }

    public int ObtenerTop()
    {
        if (EstaVacia())
            return -1; // Retorna -1 si la pila está vacía
        return pila[top];
    }
}

// Ejemplo de uso de la pila
public class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila(5);
        pila.Apilar(10);
        pila.Apilar(20);
        pila.Apilar(30);
        Console.WriteLine($"Elemento en la cima: {pila.ObtenerTop()}");
        pila.Desapilar();
        Console.WriteLine($"Elemento en la cima: {pila.ObtenerTop()}");
        Console.ReadKey();
    }
}
