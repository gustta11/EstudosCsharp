namespace exercicios02;

class Program
{
    public static int VowelConut(string str)
    {
        int quantidade = 0;

        for(int i=0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                quantidade++;
            }
        }

        return quantidade;
    }

    static void Main()
    {
        Console.WriteLine(VowelConut("progrAmmIng"));
    }
}
