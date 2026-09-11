namespace exercicios04;

//Retorne o maior número do array

class Program { 

    public static int LargestNumber(int[] arr)
    {
        int maior = arr[0];

        foreach(int i in arr)
        {
            if(maior < i)
            {
                maior = i;
            }

        }

        return maior;
    }

    static void Main()
    {
        Console.WriteLine(LargestNumber([1, 2, 9, 18, 12]));
    }

}

