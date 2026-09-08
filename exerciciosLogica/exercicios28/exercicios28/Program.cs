namespace exercicios28;

class Program { 

    public static void Main()
    {
        string?[,] pessoas = new string[3, 2];

        for(int i =0; i< pessoas.GetLength(0); i++)
        {
            for(int j =0; j< pessoas.GetLength(1); j++)
            {
                Console.WriteLine("Informe um nome:");
                pessoas[i, j] = Console.ReadLine();
                Console.WriteLine("Informe um E-mail:");
                pessoas[i, ++j] = Console.ReadLine();
            }
        }

        for (int i = 0; i < pessoas.GetLength(0); i++)
        {
            for (int j = 0; j < pessoas.GetLength(1); j++)
            {
                Console.Write($"Nome:{pessoas[i, j]} / E-mail:{pessoas[i, ++j]}");
            }

            Console.WriteLine();
        }



    }

}
