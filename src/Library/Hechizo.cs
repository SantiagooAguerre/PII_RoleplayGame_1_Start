namespace ucu;

public class Hechizo
{
    private string Nombre;  // Nombre del hechizo.
    private int Ataque;  // Valor de ataque del hechizo.

    // Propiedad pública para obtener el valor de ataque del hechizo.
    public int ataque
    {
        get { return Ataque; }
    }

    private int Defensa;  // Valor de defensa del hechizo.

    // Propiedad pública para obtener el valor de defensa del hechizo.
    public int defensa
    {
        get { return Defensa; }
    }

    // Constructor que inicializa el nombre, ataque y defensa del hechizo.
    public Hechizo(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;  // Asigna el nombre del hechizo.
        Ataque = ataque;  // Asigna el valor de ataque del hechizo.
        Defensa = defensa;  // Asigna el valor de defensa del hechizo.
    }
}
