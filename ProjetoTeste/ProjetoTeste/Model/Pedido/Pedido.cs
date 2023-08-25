using ProjetoTeste.Model.Funcionario;
using ProjetoTeste.Model.Pedido.Contracts;

namespace ProjetoTeste.Model.Pedido
{
    public class Pedido
    {
        public Pedido(string id, Vendedor vendedor)
        {
            Id = id;
            this.Vendedor = vendedor;
        }

        public string Id { get; private set; }

        public Vendedor Vendedor { get; private set; }
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        public ITransportadora<string>? Transportadora { get; private set; } = null;

        public void MudarVendedor(Vendedor vendedor)
        {
            this.Vendedor = vendedor;
        }

        public void AddTransportadora(ITransportadora<string> transportadora)
        {
            Transportadora = transportadora;
        }

        public decimal CalculoFrete()
        {
            if(Transportadora != null)
            {
                return this.Transportadora.CalculoFrete(this.Total);
            }

            return 0m;
        }

        public void AddItem(string codProduto, decimal quantidade, decimal preco)
        {
            Itens.Add(new ItemPedido(codProduto, quantidade, preco));
        }

        public decimal Total
        {
            get { return Itens.Select(x => x.Total).Sum(); }
        }

        public DateTime DataCriacao
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}


