namespace exercicios05;

//Retorne o segundo maior número diferente de um array
//Input: [10, 5, 8, 10, 3]
class Program
{

    public static int SecondNumberMax(int[] arr)
    {
        int maiorNumber = arr[0];
        int segundoMaior = 0;

        foreach(int i in arr)
        {
            if(maiorNumber < i)
            {
                maiorNumber = i;
            }

            if(segundoMaior < i && i != maiorNumber)
            {
                segundoMaior = i;
            }
        }

        return segundoMaior;
    }

    static void Main()
    {
        Console.WriteLine(SecondNumberMax([42, 7, 18, 42, 31, 25, 9]));
    }
}
