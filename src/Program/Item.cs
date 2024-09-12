public class Item
{
    // Propiedad pública para almacenar el nombre del ítem.
    public string Nombre { get; set; }

    // Propiedad pública para almacenar el valor de ataque del ítem.
    public int Ataque { get; set; }

    // Propiedad pública para almacenar el valor de defensa del ítem.
    public int Defensa { get; set; }

    // Constructor de la clase que inicializa las propiedades con los valores recibidos.
    public Item(string nombre, int ataque, int defensa)
    {
        // Asigna el valor del parámetro 'nombre' a la propiedad 'Nombre'.
        Nombre = nombre;

        // Asigna el valor del parámetro 'ataque' a la propiedad 'Ataque'.
        Ataque = ataque;

        // Asigna el valor del parámetro 'defensa' a la propiedad 'Defensa'.
        Defensa = defensa;
    }

    // Método sobrescrito que devuelve una representación en texto del objeto.
    public override string ToString()
    {
        // Retorna una cadena con el formato "Nombre: Ataque X, Defensa Y".
        return $"{Nombre}: Ataque {Ataque}, Defensa {Defensa}";
    }
}