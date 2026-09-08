namespace exercicios23;

class Program
{
    public static void Main()
    {
        Nomes n = new();
        string[] nomes = { "Paulo", "Gustavo", "Jaqueline", "Bruna", "Rafael" };
        Console.WriteLine(n.ConsultarNomes(nomes, "Jaque"));
    }
}
