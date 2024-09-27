namespace Project
{
    public class Contato : Entity
    {
        public string Nome;
        public string Telefone;

        public Contato(int id, string nome, string telefone) 
            : base(id)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"ID: {id} \nNome: {Nome} \nTelefone: {Telefone}");
        }
    }
}