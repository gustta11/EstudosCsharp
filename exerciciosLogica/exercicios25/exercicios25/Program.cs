namespace exercicios25;

class Program
{
    public static void Main()
    {
        double[] numeros = new double[5];
        double soma = 0;
        double media;

        for(int i =0; i < numeros.Length; i++)
        {
            Console.WriteLine("Informe um número");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            soma += numeros[i];
        }

        media = soma / numeros.Length;

        Console.WriteLine($"Números maiores ou iguais a média({media}):");

        foreach(int i in numeros)
        {
            if(i >= media)
            {
                Console.WriteLine($"{i}");
            }
        }


    }
}
