namespace ucu;

using System;
using System.Collections.Generic;
using System.Collections;

public class Enano
{
    // Propiedades privadas
    private string Nombre { get; set; }  // Propiedad que almacena el nombre del enano.
    private int Vida;  // Almacena la vida actual del enano, es mutable.
    private int VidaInicial;  // Almacena la vida inicial del enano al crearlo, es inmutable.
    private ArrayList ItemsList;  // Lista de items que el enano tiene, el tipo es genérico.

    // Propiedad pública para acceder y modificar 'Vida'
    public int vida
    {
        get { return Vida; } 
        set { Vida = value; }
    }

    // Propiedad pública para acceder a 'VidaInicial', pero sin modificarla
    public int vidaInicial
    {
        get { return VidaInicial; }
    }

    // Constructor de la clase Enano
    public Enano(string nombre, int vida)
    {
        Nombre = nombre;  // Se asigna el nombre proporcionado al constructor.
        Vida = vida;  // Se asigna la vida actual, que será mutable.
        VidaInicial = vida;  // Se almacena la vida inicial, inmutable durante la vida del objeto.
        ItemsList = new ArrayList();  // Inicializa una lista vacía de items (puede contener cualquier tipo de objeto).
    }

    // Método para agregar un item a la lista de items del enano
    public void AgregarItem(Item item)
    {
        ItemsList.Add(item);  // Añade el item a la lista del inventario.
    }

    // Método para eliminar un item del inventario del enano
    public void QuitarItem(Item item)
    {
        // Verifica si el item está en la lista antes de intentar eliminarlo.
        if (ItemsList.Contains(item)) 
        {
            ItemsList.Remove(item);  // Si el item está presente, lo remueve.
        }
    }

    // Método para atacar a otro personaje usando un item específico
    public void Atacar(Object personaje, Item item)
    {
        // Verifica el tipo del personaje objetivo (puede ser Enano, Elfo o Mago)
        // para ajustar su vida en función del ataque del item.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;  // Realiza el casting si es Enano.
            enano.vida -= item.ataque;  // Resta el valor del ataque del item a la vida del enano.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;  // Realiza el casting si es Elfo.
            elfo.vida -= item.ataque;  // Aplica el ataque al Elfo.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;  // Realiza el casting si es Mago.
            mago.vida -= item.ataque;  // Aplica el ataque al Mago.
        }
    }

    // Método para curar a otro personaje restaurando su vida a su valor inicial
    public void Curar(Object personaje)
    {
        // De nuevo, verifica el tipo del personaje antes de curarlo.
        // Restaura la vida al valor que tenía al crear el personaje.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;
            enano.vida = enano.vidaInicial;  // La vida vuelve a su valor inicial.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;
            elfo.vida = elfo.vidaInicial;  // Mismo comportamiento para el Elfo.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;
            mago.vida = mago.vidaInicial;  // Y lo mismo para el Mago.
        }
    }

    // Calcula el ataque total del enano sumando el ataque de todos los items que posee
    public int getAtaqueTotal()
    {
        int ataqueTotal = 0;  // Inicializa un contador de ataque.
        foreach (Item item in ItemsList)  // Recorre la lista de items del enano.
        {
            ataqueTotal += item.ataque;  // Suma el valor de ataque de cada item.
        }
        return ataqueTotal;  // Retorna el total acumulado del ataque.
    }

    // Calcula la defensa total del enano sumando la defensa de todos los items que posee
    public int getDefensaTotal()
    {
        int defensaTotal = 0;  // Inicializa un contador de defensa.
        foreach (Item item in ItemsList)  // Recorre la lista de items del enano.
        {
            defensaTotal += item.defensa;  // Suma el valor de defensa de cada item.
        }
        return defensaTotal;  // Retorna el total acumulado de la defensa.
    }
}

