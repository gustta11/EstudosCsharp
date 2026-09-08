namespace exercicios18;

class Program
{
    public static void Main()
    {
        Calendario c = new();
        Console.WriteLine(c.DiaDaSemana(5));
        Console.WriteLine(c.DiaDaSemana(25));
        Console.WriteLine(c.DiaDaSemana(17));
    }
}
