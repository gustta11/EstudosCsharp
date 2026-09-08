namespace exercicios19;

class Program
{
    public static void Main()
    {
        Bissexto b = new();

        Console.WriteLine("Informe uma ano:");
        int ano = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(b.VerificarAnoBissexto(ano));
    }
}
