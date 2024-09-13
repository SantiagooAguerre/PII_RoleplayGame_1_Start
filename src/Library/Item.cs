public class Item
{
    // Propiedad pública para almacenar el nombre del ítem.
    private string Nombre;

    // Propiedad pública para almacenar el valor de ataque del ítem.
    private int Ataque;

    public int ataque
    {
        get { return Ataque; }
    }

    // Propiedad pública para almacenar el valor de defensa del ítem.
    private int Defensa;

    public int defensa
    {
        get { return Defensa; }
    }

    private string Tipo;

    //private object Portador;

    // Constructor de la clase que inicializa las propiedades con los valores recibidos.
    public Item(string nombre, int ataque, int defensa, string tipo/*, object portador*/)
    {
        // Asigna el valor del parámetro 'nombre' a la propiedad 'Nombre'.
        Nombre = nombre;

        // Asigna el valor del parámetro 'ataque' a la propiedad 'Ataque'.
        Ataque = ataque;

        // Asigna el valor del parámetro 'defensa' a la propiedad 'Defensa'.
        Defensa = defensa;

        Tipo = tipo;

        //Portador = portador;
    }

    // Método sobrescrito que devuelve una representación en texto del objeto.
    public override string ToString()
    {
        // Retorna una cadena con el formato "Nombre: Ataque X, Defensa Y".
        return $"{Nombre}: ,Tipo {Tipo}, Ataque {Ataque}, Defensa {Defensa}.";
    }
}
    