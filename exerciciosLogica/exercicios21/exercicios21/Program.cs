namespace exercicios21;

class Program
{
    public static void Main()
    {
        Numeros n = new();
        Console.WriteLine("Informe um número:");
        int number = Convert.ToInt16(Console.ReadLine());
        n.EcontrarNumeros(number);
    }
}
