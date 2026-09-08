namespace exercicios31;

class Program
{
    public static void Main()
    {
        string[,] produtos =
        {
            {"1", "Notebook", "4500" },
            {"2", "Iphone", "5000" },
            {"3", "Ipad", "4000" },
            {"4", "Monitor", "800" },
            {"5", "Mouse", "150" },
            {"6", "Teclado", "200" },
            {"7", "Pen Drive", "50" },
            {"8", "Capa de celular", "20" },
            {"9", "HD", "300" },
            {"10", "SSD", "500" }
        };

        string ?codigo;
        int totalCompra = 0;
        string ?opcaoSair = "0";

        do
        {
            for(int i = 0; i< produtos.GetLength(0); i++)
            {    
               Console.WriteLine($"Código:{produtos[i, 0]}, Produtos:{produtos[i, 1]}, Valor:{produtos[i,2]}");
               Console.WriteLine(" ");
            }

            Console.WriteLine("Informe o código do produto que deseja adquirir e 0 para sair");
            codigo = Console.ReadLine();

            for (int i = 0; i < produtos.GetLength(0); i++)
            {
                for (int j = 0; j < produtos.GetLength(1); j++)
                {
                    if(codigo == produtos[i, j])
                    {
                        int valor = int.Parse(produtos[i, 2]);
                        totalCompra += valor;
                    }
                }
            }

        } while( codigo != opcaoSair );

        Console.WriteLine($"Total da compra:{totalCompra}");
    }
}
