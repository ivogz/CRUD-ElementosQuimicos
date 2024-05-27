using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {

        Laboratorio labo = new Laboratorio("Laboratorio facultad", "Avellaneda", ETamaños.Mediano);

        Metal gz = new Metal(17, "Gonzalez", "Gz", 9, 11, ECategoriasMetales.MetalPostransicional, 230.450, 9000, "rojo");
        NoMetal gauto = new NoMetal(36, "Gauto", "Gt", 3, 7, 700, EEstados.Desconocido, 632.52, 7853.5);
        NoMetal ayud = new NoMetal(39, "Ayuda", "Ay", 78, 7);
        Gas gasoi = new Gas(78, "Gasoi", "G", 9, 17);

        //Console.WriteLine(gz.Protones);
        //Console.WriteLine(gasoi.ToString());
        //Console.WriteLine(gauto.ToString());

        labo += gauto;
        labo += ayud;
        labo += gz;
        labo += gasoi;

        Console.WriteLine(labo.ToString());

        labo.Elementos = labo.OrdenarPor(AtributosElemento.NumeroAtomico, labo.Elementos, true);

        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine(labo.ToString());

        labo.Elementos.Remove(gz);

        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine(labo.ToString());


    }
}