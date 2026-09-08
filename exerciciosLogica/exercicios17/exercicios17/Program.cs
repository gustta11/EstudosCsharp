namespace exercicios17;

class Program
{
    public static void Main()
    {   
        Multiplicar m = new Multiplicar();
        Console.WriteLine(m.CalcularNumeros(5, 5));
        Console.WriteLine(m.CalcularNumeros(5, 4));
        Console.WriteLine(m.CalcularNumeros2(6, 6));
        Console.WriteLine(m.CalcularNumeros2(6, 5));
    }
}