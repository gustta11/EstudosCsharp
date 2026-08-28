namespace exercicios22;

class Program
{
    public static void Main()
    {
        Duplicados obj = new();
        int[] numeros = { 1, 2, 3, 2, 4, 5, 3,4,6,7,6 };
        
        foreach(int numerosDuplicados in obj.EcontrarNumerosDuplicados(numeros))
        {
            Console.WriteLine(numerosDuplicados);
        }
    }
}
