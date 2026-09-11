namespace exercicios03;

//Receba uma string e retorne a quantidade de letras que ela possui.

//Ignore espaços e números.

class Program
{
    public static int LetterCount(string str)
    {
        int count = 0;

        for(int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
            {
                count++;
            }
        }

        return count;

    }

    static void Main()
    {
        Console.WriteLine(LetterCount("hello world 123"));
    }
}
