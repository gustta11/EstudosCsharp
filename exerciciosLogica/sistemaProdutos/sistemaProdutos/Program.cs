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
                    _produtos.Add(produto.Id, produto);
                    break;

                case "2":

                    foreach(var item in _produtos)
                    {
                        Console.WriteLine($"Código:{item.Key}, Nome:{item.Value.Nome}, Valor:{item.Value.Preco}");
                    }

                    break;

                case "3":

                    Produto produtoNovo = new();
                    Console.WriteLine("Informe o ID do produto que deseja alterar");
                    produtoNovo.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o nome do novo produto:");
                    produtoNovo.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o preço do novo produto");
                    produtoNovo.Preco = decimal.Parse(Console.ReadLine());
                    _produtos[produtoNovo.Id]= produtoNovo;
                    Console.WriteLine("Produto alterado com sucesso!");
                    break;

                case "4":

                    Console.WriteLine("Informe o ID do produto que deseja remover");
                    int removerId = int.Parse(Console.ReadLine());
                    _produtos.Remove(removerId);
                    Console.WriteLine("Produto removido com sucesso!");
                    break;

                case "5":

                    Console.WriteLine("Finalizando programa......");
                    break;

            }
        } while (opcao != "5");
    }
}
