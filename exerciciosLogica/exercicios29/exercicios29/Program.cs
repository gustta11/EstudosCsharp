namespace exercicios29;

class Program
{
    public static void Main()
    {
        int[,] numeros = new int[5, 5];

        Random random = new Random();

        for(int i=0; i< numeros.GetLength(0); i++)
        {
            for(int j = 0; j< numeros.GetLength(1); j++)
            {
                int numeroAleatorio = random.Next(0, 9);
                numeros[i, j] = numeroAleatorio;
            }
        }

        for(int i = 0; i< numeros.GetLength(0); i++)
        {
            for(int j =0; j<numeros.GetLength(1); j++)
            {
                Console.Write(numeros[i, j]);
            }

            Console.WriteLine();
        }
    }
}
