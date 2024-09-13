namespace ucu;

using System;
using System.Collections.Generic;
using System.Collections;

public class Elfo
{
    // Propiedades privadas
    private string Nombre { get; set; }  // El nombre del Elfo, una propiedad privada que puede ser accedida pero no directamente modificada fuera de la clase.
    private int Vida;  // La vida actual del Elfo, es una variable mutable que se puede reducir o restaurar.

    // Propiedad pública para acceder y modificar la vida del Elfo
    public int vida
    {
        get { return Vida; }  // Permite acceder al valor actual de la vida.
        set { Vida = value; }  // Permite modificar la vida, útil para aplicar daño o curación.
    }

    // Almacena la vida inicial del Elfo al ser creado (inmutable desde el exterior)
    private int VidaInicial;  // Guarda el valor inicial de la vida del Elfo cuando es creado.

    // Propiedad pública para acceder a la vida inicial del Elfo, pero sin permitir su modificación.
    public int vidaInicial
    {
        get { return VidaInicial; }
    }

    private ArrayList ItemsList;  // Lista que almacena los items que el Elfo posee. `ArrayList` es genérico, no tipado.

    // Constructor de la clase Elfo
    public Elfo(string nombre, int vida)
    {
        Nombre = nombre;  // Se asigna el nombre del Elfo que se pasa al constructor.
        Vida = vida;  // Se asigna la vida actual del Elfo.
        VidaInicial = vida;  // Se almacena la vida inicial para poder restaurarla más adelante.
        ItemsList = new ArrayList();  // Se inicializa una lista vacía de items, que podrá almacenar cualquier tipo de objeto.
    }

    // Método para agregar un item a la lista de items del Elfo
    public void AgregarItem(Item item)
    {
        ItemsList.Add(item);  // Añade el item a la lista de inventario del Elfo.
    }

    // Método para quitar un item del inventario del Elfo
    public void QuitarItem(Item item)
    {
        // Verifica si el item existe en la lista antes de intentar eliminarlo.
        if (ItemsList.Contains(item))
        {
            ItemsList.Remove(item);  // Elimina el item si está presente.
        }
    }

    // Método para atacar a otro personaje con un item
    public void Atacar(Object personaje, Item item)
    {
        // El ataque del Elfo depende de a quién está atacando. Utiliza un chequeo de tipo
        // para verificar si el objetivo es un Enano, otro Elfo o un Mago.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;  // Si el personaje es un Enano, realiza el casting.
            enano.vida -= item.ataque;  // Aplica el daño del item al Enano.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;  // Si es otro Elfo, lo mismo.
            elfo.vida -= item.ataque;  // Aplica el daño del item al Elfo.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;  // Si es un Mago, también realiza el casting.
            mago.vida -= item.ataque;  // Aplica el daño del item al Mago.
        }
    }

    // Método para curar a otro personaje, restaurando su vida a su valor inicial
    public void Curar(Object personaje)
    {
        // Similar a `Atacar`, el método `Curar` restaura la vida de un personaje.
        // Verifica si el personaje es un Enano, Elfo o Mago y restaura su vida al valor inicial.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;
            enano.vida = enano.vidaInicial;  // La vida del Enano vuelve a su valor inicial.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;
            elfo.vida = elfo.vidaInicial;  // La vida del Elfo también se restaura.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;
            mago.vida = mago.vidaInicial;  // La vida del Mago vuelve a su valor original.
        }
    }

    // Método que calcula el ataque total sumando los ataques de todos los items que posee el Elfo
    public int getAtaqueTotal()
    {
        int ataqueTotal = 0;
        // Itera sobre la lista de items del Elfo para sumar el valor de ataque de cada uno.
        foreach (Item item in ItemsList)
        {
            ataqueTotal += item.ataque;  // Suma el ataque de cada item.
        }
        return ataqueTotal;  // Devuelve la suma total del ataque.
    }

    // Método que calcula la defensa total sumando la defensa de todos los items que posee el Elfo
    public int getDefensaTotal()
    {
        int defensaTotal = 0;
        // De manera similar al cálculo de ataque, suma el valor de defensa de todos los items.
        foreach (Item item in ItemsList)
        {
            defensaTotal += item.defensa;  // Suma la defensa de cada item.
        }
        return defensaTotal;  // Devuelve la suma total de la defensa.
    }
}
