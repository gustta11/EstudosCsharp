namespace exercicios01;

class Program
{
    
    public static string FirstReverse(string str)
    {
        string reverse = "";

        for(int i = str.Length -1; i >= 0; i--)
        {
            reverse += str[i];
        }

        return reverse;
    }
    
    
    
    
    
    static void Main()
    {
        Console.WriteLine(FirstReverse("Coderbyte"));
    }


}
