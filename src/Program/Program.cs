namespace ucu;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// El punto de entrada al programa.
    /// </summary>
    public static void Main()
    {
        
        Enano dwarv = new Enano("Dwarven Stepworld", 60);
        Enano fasto = new Enano("Faston Sellsword", 85);
        
        Item pipa = new Item("Pipa del enano", 0, 10, "Life boost");
        Item faca = new Item("Faca afilada", 12, 0, "Short distance");
        
        fasto.AgregarItem(faca);
        fasto.QuitarItem(faca);
        dwarv.AgregarItem(faca);
        dwarv.Atacar(fasto,faca);
        dwarv.Curar(fasto);
        Console.WriteLine(fasto.vida);
        
    }
    

    
}
