namespace Project
{
    public class Compra : Transacao
    {
        public string Fornecedor;
        public string Cliente;

        public Compra(int id, DateTime data, float valor, string fornecedor, string cliente)
            : base(id, data, valor)
        {
            this.Fornecedor = fornecedor;
            this.Cliente = cliente;
        }

        public new void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Fornecedor: {Fornecedor} \nCliente: {Cliente}");
        }
    }
}