namespace exercicios21;

class Program
{
    public static void Main()
    {
        Inverter obj = new Inverter();
        int[] numeros = { 1, 2, 3, 4, 5 };
        numeros = obj.InverterArray(numeros);
        for(int i = 0; i< numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
