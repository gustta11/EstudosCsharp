namespace sistemaProdutos;


public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
class Program
{
    public static void Main()
    {
        Dictionary<int,Produto> _produtos = new Dictionary<int,Produto>();
        string ?opcao;

        do
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar todos os produtos");
            Console.WriteLine("3 - Alterar produtos");
            Console.WriteLine("4 - Remover produtos");
            Console.WriteLine("5 - Finalizar sistema");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Produto produto = new();
                    Console.WriteLine("Informe o ID do produto");
                    produto.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o nome do produto:");
                    produto.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o preço do produto:");
                    produto.Preco = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"{produto.Nome} cadastrado com sucesso!");
                    break;

                case "2":

            }
        } while (opcao != "5");
    }
}
