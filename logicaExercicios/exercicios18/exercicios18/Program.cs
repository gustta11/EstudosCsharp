namespace exercicios18;

class Program
{
    public static void Main()
    {
        Soma s = new Soma();
        int[] numeros = { 10, 30, 20 };
        Console.WriteLine(s.SomaDosNumeros(numeros));
    }
}
