namespace Project
{
    public class Transacao : Entity
    {
        public DateTime Data;
        public float Valor;

        public Transacao(int id, DateTime data, float valor) 
            : base(id)
        {
         
            this.Data = data;
            this.Valor = valor;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"ID: {id} \nData: {Data} \nValor de Transação: {Valor}");
        }
    }
}