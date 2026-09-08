namespace matriz;

class Program
{
    public static void Main()
    {
        string[,] dados =
        {
            {"Gustavo", "Alagoinhas" },
            {"Jaqueline", "Inhambupe" },
            {"Bruna", "Inhambupe" }
        };

        for(int i = 0; i<dados.GetLength(0); i++)
        {
            for(int j = 0; j < dados.GetLength(1); j++)
            {
                Console.WriteLine($"Nome:{dados[i, j]}, Cidade:{dados[i,++j]}");
            }
        }
    }
}
