namespace exercicios30;

class Program
{
    public static void Main()
    {
        int[,] numeros =
        {
            {5,1,4,1,1 },
            {2,7,2,3,2 },
            {2,3,9,3,5 },
            {4,9,4,8,4 },
            {1,5,6,5,5 }
        };

        int somaTotal = 0;
        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0;

        for(int i = 0; i<numeros.GetLength(0); i++)
        {
            for(int j = 0; j<numeros.GetLength(1); j++)
            {
                somaTotal += numeros[i, j];
            }
        }


        for(int i = 0; i < numeros.GetLength(0); i++)
        {
            somaDiagonalPrincipal += numeros[i, i];
        }

        for(int i = 0; i < numeros.GetLength(0); i++)
        {
            int diminuicao = numeros.GetLength(0) - i - 1;
            somaDiagonalSecundaria += numeros[i, diminuicao];
        }

        Console.WriteLine(somaTotal);
        Console.WriteLine(somaDiagonalPrincipal);
        Console.WriteLine(somaDiagonalSecundaria);


    }
}
