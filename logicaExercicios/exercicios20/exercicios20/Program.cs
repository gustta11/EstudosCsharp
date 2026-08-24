namespace exercicios20;

class Program
{
    public static void Main()
    {
        NumeroPar n = new NumeroPar();
        int[] numeros = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(n.QuatidadeDeNumerosPar(numeros));
    }
}
