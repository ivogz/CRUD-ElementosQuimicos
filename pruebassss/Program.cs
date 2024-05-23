using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Metal gz = new Metal(17, "Gonzalez", "GZ", 9, 11, ECategoriasMetales.MetalPostransicional, 230.450, 9000, "rojo");

        Console.WriteLine(gz.Protones);


    }
}