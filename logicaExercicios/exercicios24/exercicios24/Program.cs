using System.Data;

namespace exercicios24;

class Program
{
    public static void Main()
    {
        SegundoMaior obj = new();
        int[] numeros = [10, 5, 8, 20, 11];
        Console.WriteLine(obj.EcontrarSegundoMaiorNumero(numeros));
    }
}
