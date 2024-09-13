namespace ucu;

public class Hechizo
{
    private string Nombre;
    private int Ataque;

    public int ataque
    {
        get { return Ataque; }
    }

    private int Defensa;

    public int defensa
    {
        get { return Defensa; }
    }

    public Hechizo(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }
}