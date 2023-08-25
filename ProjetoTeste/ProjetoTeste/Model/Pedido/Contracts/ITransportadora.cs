using ProjetoTeste.Model.Contracts;

namespace ProjetoTeste.Model.Pedido.Contracts
{
    public interface ITransportadora<T> : Identificador<T>
    {
        public string Name { get; set; }
        public decimal CalculoFrete(decimal valor);
    }
}


