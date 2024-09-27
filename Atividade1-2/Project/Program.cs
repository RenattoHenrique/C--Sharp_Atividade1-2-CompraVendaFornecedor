using Project;

//Exercicio 1:

//Crie as classes:
//Contato, Transação, Compra, Venda, Fornecedor, Cliente e Produto

//faça com que as classes compra e venda sejam especializações da classe Transação

//faça com que as classes Fornecedor e Cliente sejam especializações da classe Contato

//crie uma instancia de cada classe, preencha os dados e mande imprimir na tela usando a função Console.Writeline

//Exercicio 2:
//Crie uma nova classe chamada Entity (ou Entidade em português) apenas com um atributo (int id).....

//E faça com que todas as classes de modelo do sistema (Contato, Transação, Compra, Venda, Fornecedor, Cliente e Produto), sejam direta ou indiretamente subclasses dessa classe.
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Fornecedor fornecedor = new Fornecedor(1, "FERREIRA COSTA & CIA LTDA", "(81) 3338-8309", "10.230.480/0022-65");
        Cliente cliente = new Cliente(2, "Renato Henrique de Oliveira Ramos", "(81) 98594-2139", "124.969.854-52");
        Produto produto = new Produto(3, "Eletroduto Rígido PVC Roscável 3/4 3,0m - Amanco", 50.0f);
        Compra compra = new Compra(4, DateTime.Now, 100.0f, fornecedor.Nome, cliente.Nome);
        Venda venda = new Venda(5, DateTime.Now, 100.0f, fornecedor.Nome, cliente.Nome);

        Console.WriteLine("Fornecedores:");
        fornecedor.ExibirDados();

        Console.WriteLine("\nClientes:");
        cliente.ExibirDados();

        Console.WriteLine("\nProdutos:");
        produto.ExibirDados();

        Console.WriteLine("\nCompras:");
        compra.ExibirDados();

        Console.WriteLine("\nVendas:");
        venda.ExibirDados();

        Console.ForegroundColor = ConsoleColor.White;
    }
}