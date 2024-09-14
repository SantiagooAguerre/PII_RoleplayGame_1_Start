namespace ucu;

using System;
using System.Collections.Generic;
using System.Collections;

public class Mago
{
    // Propiedades privadas
    private string Nombre { get; set; }  // El nombre del Mago. Es privado y sólo puede ser accedido a través de la propiedad.
    private int Vida;  // Vida actual del Mago, que puede cambiar durante el juego.

    // Propiedad pública para acceder o modificar la vida del Mago.
    public int vida
    {
        get { return Vida; }  // Devuelve la vida actual.
        set { Vida = value; }  // Permite modificar la vida, útil para aplicar daño o curaciones.
    }

    private int VidaInicial;  // Vida con la que comienza el Mago, que no puede ser modificada después de inicializarla.

    // Propiedad pública para obtener el valor de la vida inicial.
    public int vidaInicial
    {
        get { return VidaInicial; }
    }

    private int Mana;  // Esta es una propiedad específica del Mago. Representa los puntos de maná, usados para lanzar hechizos.

    private ArrayList ItemsList;  // Lista de items que el Mago posee. Al igual que con las otras clases, se usa `ArrayList`, aunque sería más apropiado usar un `List<Item>`.

    // Constructor de la clase Mago
    public Mago(string nombre, int vida, int mana)
    {
        Nombre = nombre;  // Se asigna el nombre del Mago.
        Vida = vida;  // Se asigna la vida del Mago.
        VidaInicial = vida;  // Se guarda la vida inicial para poder restaurarla más adelante.
        Mana = mana;  // Asigna el valor de maná inicial.
        ItemsList = new ArrayList();  // Inicializa la lista de items vacía.
    }

    // Método para agregar un item a la lista del Mago
    public void AgregarItem(Item item)
    {
        ItemsList.Add(item);  // Añade el item a la lista de items del Mago.
    }

    // Método para quitar un item de la lista del Mago
    public void QuitarItem(Item item)
    {
        if (ItemsList.Contains(item))  // Verifica si el item está presente en la lista.
        {
            ItemsList.Remove(item);  // Si está, lo elimina.
        }
    }

    // Método para atacar a otro personaje utilizando un item
    public void Atacar(Object personaje, Item item)
    {
        // Verifica el tipo del personaje al que se está atacando.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;  // Realiza el casting a Enano si el objetivo es un Enano.
            enano.vida -= item.ataque;  // Aplica el valor de ataque del item al Enano.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;  // Realiza el casting a Elfo si el objetivo es un Elfo.
            elfo.vida -= item.ataque;  // Aplica el valor de ataque al Elfo.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;  // Realiza el casting a Mago si el objetivo es otro Mago.
            mago.vida -= item.ataque;  // Aplica el valor de ataque al Mago.
        }
    }

    // Método para curar a otro personaje, restaurando su vida a la inicial
    public void Curar(Object personaje)
    {
        // Verifica el tipo del personaje para restaurar su vida a la inicial.
        if (personaje is Enano)
        {
            Enano enano = (Enano)personaje;  // Realiza el casting a Enano.
            enano.vida = enano.vidaInicial;  // Restaura la vida del Enano a su valor inicial.
        }
        else if (personaje is Elfo)
        {
            Elfo elfo = (Elfo)personaje;  // Realiza el casting a Elfo.
            elfo.vida = elfo.vidaInicial;  // Restaura la vida del Elfo a su valor inicial.
        }
        else if (personaje is Mago)
        {
            Mago mago = (Mago)personaje;  // Realiza el casting a Mago.
            mago.vida = mago.vidaInicial;  // Restaura la vida del Mago a su valor inicial.
        }
    }

    // Método que calcula el ataque total sumando los ataques de todos los items
    public int getAtaqueTotal()
    {
        int ataqueTotal = 0;
        // Recorre la lista de items del Mago y suma el valor de ataque de cada item.
        foreach (Item item in ItemsList)
        {
            ataqueTotal += item.ataque;  // Suma el valor de ataque del item al ataque total.
        }
        return ataqueTotal;  // Devuelve el valor del ataque total.
    }

    // Método que calcula la defensa total sumando las defensas de todos los items
    public int getDefensaTotal()
    {
        int defensaTotal = 0;
        // Recorre la lista de items del Mago y suma el valor de defensa de cada item.
        foreach (Item item in ItemsList)
        {
            defensaTotal += item.defensa;  // Suma el valor de defensa del item a la defensa total.
        }
        return defensaTotal;  // Devuelve el valor de la defensa total.
    }
}
