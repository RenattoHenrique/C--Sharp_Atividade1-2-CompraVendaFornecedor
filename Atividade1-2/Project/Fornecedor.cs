namespace Project
{
    public class Fornecedor : Contato
    {
        public string CNPJ;

        public Fornecedor(int id, string nome, string telefone, string cnpj)
            : base(id, nome, telefone)
        {
            this.CNPJ = cnpj;
        }

        public new void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"CNPJ: {CNPJ}");
        }
    }
}
