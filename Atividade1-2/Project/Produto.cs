namespace Project
{
    public class Produto : Entity
    {
        public string Nome;
        public float Preco;

        public Produto(int id, string nome, float preco) 
            : base(id)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"ID: {id} \nProduto: {Nome} \nPreço: {Preco}");
        }
    }
}
