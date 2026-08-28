namespace exercicios23;

class Program
{
    public static void Main()
    {
        Duplicados obj = new();
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 2, 5, 6, 7, 6 };

        foreach(int numero in obj.RemoverDuplicados(numeros))
        {
            Console.WriteLine(numero);
        }
    }
}
