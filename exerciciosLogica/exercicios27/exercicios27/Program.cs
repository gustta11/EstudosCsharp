namespace exercicios27;

class Program
{
    public static void Main()
    {


        int[,] numeros = {
        {1,2,3 },
        {4,5,6 },
        {7,8,9 }
        };

        int soma = 0;

        for(int i=0; i < numeros.GetLength(0); i++)
        {
            for(int j = 0; j<numeros.GetLength(1); j++)
            {
                Console.Write(numeros[i,j] + " ");
                soma += numeros[i, j];
            }

            Console.WriteLine();
        }

        Console.WriteLine($"A soma dos valores:{soma}");

    }

}
