namespace exercicios26;

class Program
{
    public static void Main()
    {
        int[] numeros = new int[5];

        for(int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Informe um número:");
            numeros[i] = Convert.ToInt16(Console.ReadLine());
        }

        for(int i = 0; i<numeros.Length; i++)
        {
            if (numeros[i] == 5)
            {
                Console.WriteLine($"Posição -> {i}");
            }
        }

        if (!numeros.Contains(5))
        {
            Console.WriteLine("Número 5 Não encontrado");
        }
    }
}
