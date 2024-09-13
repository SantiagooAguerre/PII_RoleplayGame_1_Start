namespace ucu;

using System;
using System.Collections.Generic;

public class Enano
{
    // Propiedades del enano
    private string Nombre { get; set; } // Nombre del enano
    private int Vida;  // Vida del enano

    public int vida
    {
        get { return Vida; } 
        set { Vida = value; }
    }

    private int VidaInicial;

    public int vidaInicial
    {
        get { return VidaInicial; }
    }
    public List<Item> ItemsList { get; set; }  // Lista de items que el enano posee
    public int Fuerza { get; set; } // Fuerza base del enano

    // Constructor de la clase Enano
    public Enano(string nombre, int vida, int fuerza)
    {
        Nombre = nombre; // Asigna el nombre
        Vida = vida; // Asigna la vida
        VidaInicial = vida;
        Fuerza = fuerza; // Asigna la fuerza
        ItemsList = new List<Item>(); // Inicializa la lista de items vacía
    }

    // Método para agregar un item al enano
    public void AgregarItem(Item item)
    {
        ItemsList.Add(item); // Añade el item a la lista de items
    }

    // Método para quitar un item del enano
    public void QuitarItem(Item item)
    {
        if (ItemsList.Contains(item)) // Verifica si el item está en la lista
        {
            ItemsList.Remove(item); // Si está, lo elimina
        }
    }

    public void Atacar(Object personaje, Item item)
    {
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;    
            enano.vida -= item.ataque;
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;    
            elfo.vida -= item.ataque;
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;    
            mago.vida -= item.ataque;
        }
        
    }
    public void Curar(Object personaje)
    {
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;    
            enano.vida = enano.vidaInicial;
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;    
            elfo.vida = elfo.vidaInicial;
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;    
            mago.vida = mago.vidaInicial;
        }
        
    }
    // Método que calcula el ataque total sumando los ataques de todos los items y la fuerza del enano
    public int getAtaqueTotal()
    {
        int ataqueTotal = 0;
        foreach (var item in ItemsList) // Itera sobre los items del enano
        {
            ataqueTotal += item.ataque; // Suma el valor de ataque de cada item
        }
        ataqueTotal += Fuerza; // Añade la fuerza del enano al ataque total
        return ataqueTotal; // Retorna el ataque total
    }

    // Método que calcula la defensa total sumando las defensas de todos los items
    public int getDefensaTotal()
    {
        int defensaTotal = 0;
        foreach (var item in ItemsList) // Itera sobre los items del enano
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
