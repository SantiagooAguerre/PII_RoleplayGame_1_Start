public class Item
{
    private string Nombre;  // Nombre del item.
    private int Ataque;  // Valor de ataque del item.

    // Propiedad pública para obtener el valor de ataque del item.
    public int ataque
    {
        get { return Ataque; }
    }

    private int Defensa;  // Valor de defensa del item.

    // Propiedad pública para obtener el valor de defensa del item.
    public int defensa
    {
        get { return Defensa; }
    }

    private string Tipo;  // Tipo del item, como "arma", "escudo", etc.

    // Constructor que inicializa las propiedades del item.
    public Item(string nombre, int ataque, int defensa, string tipo)
    {
        Nombre = nombre;  // Asigna el nombre del item.
        Ataque = ataque;  // Asigna el valor de ataque del item.
        Defensa = defensa;  // Asigna el valor de defensa del item.
        Tipo = tipo;  // Asigna el tipo de item.
    }
}

    