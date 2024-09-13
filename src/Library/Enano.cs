namespace ucu;

using System;
using System.Collections.Generic;

public class Enano
{
    // Propiedades del enano
    public string Nombre { get; set; } // Nombre del enano
    public int Vida { get; set; } // Vida del enano
    public List<Item> Items { get; set; }  // Lista de items que el enano posee
    public int Fuerza { get; set; } // Fuerza base del enano

    // Constructor de la clase Enano
    public Enano(string nombre, int vida, int fuerza)
    {
        Nombre = nombre; // Asigna el nombre
        Vida = vida; // Asigna la vida
        Fuerza = fuerza; // Asigna la fuerza
        Items = new List<Item>(); // Inicializa la lista de items vacía
    }

    // Método para agregar un item al enano
    public void AgregarItem(Item item)
    {
        Items.Add(item); // Añade el item a la lista de items
    }

    // Método para quitar un item del enano
    public void QuitarItem(Item item)
    {
        if (Items.Contains(item)) // Verifica si el item está en la lista
        {
            Items.Remove(item); // Si está, lo elimina
        }
    }

    // Método que calcula el ataque total sumando los ataques de todos los items y la fuerza del enano
    public int Atacar()
    {
        int ataqueTotal = 0;
        foreach (var item in Items) // Itera sobre los items del enano
        {
            ataqueTotal += item.ataque; // Suma el valor de ataque de cada item
        }
        ataqueTotal += Fuerza; // Añade la fuerza del enano al ataque total
        return ataqueTotal; // Retorna el ataque total
    }

    // Método que calcula la defensa total sumando las defensas de todos los items
    public int Defender()
    {
        int defensaTotal = 0;
        foreach (var item in Items) // Itera sobre los items del enano
        {
            defensaTotal += item.defensa; // Suma el valor de defensa de cada item
        }
        return defensaTotal; // Retorna la defensa total
    }

    // Método que describe la acción de luchar del enano
    public string Luchar()
    {
        return $"{Nombre} lucha con una fuerza de {Fuerza}"; // Retorna un mensaje indicando la fuerza de lucha
    }
}
