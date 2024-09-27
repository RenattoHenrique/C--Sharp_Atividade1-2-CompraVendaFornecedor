namespace Project
{
    public class Cliente : Contato
    {
        public string CPF;

        public Cliente(int id, string nome, string telefone, string cpf)
            : base(id, nome, telefone)
        {
            this.CPF = cpf;
        }

        public new void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}