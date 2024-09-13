namespace ucu;
using System.Collections;
public class LibroHechizos
{
    
    private ArrayList Hechizos;

    
    // Constructor de la clase
    public LibroHechizos()
    {
        Hechizos = new ArrayList();
    }
    // Agregar un hechizo al libro
    public void AgregarHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }

    // Eliminar un hechizo del libro
    public void EliminarHechizo(Hechizo hechizo)
    {
        Hechizos.Remove(hechizo);
    }
    // Obtener el total de ataque de todos los hechizos en el libro
    public int ObtenerTotalAtaque()
    {
        int ataqueTotal = 0;
        foreach (Hechizo hechizo in Hechizos) 
        {
            ataqueTotal += hechizo.ataque; // Suma el valor de ataque de cada hechizo
        }
        return ataqueTotal; 
    }

    // Obtener el total de defensa de todos los hechizos en el libro
    public int ObtenerTotalDefensa()
    {
        int defensaTotal = 0;
        foreach (Hechizo hechizo in Hechizos) 
        {
            defensaTotal += hechizo.defensa; // Suma el valor de defensa de cada hechizo
        }
        return defensaTotal; 
    }
}