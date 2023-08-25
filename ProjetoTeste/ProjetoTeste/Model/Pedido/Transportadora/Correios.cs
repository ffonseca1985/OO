using ProjetoTeste.Model.Pedido.Contracts;

namespace ProjetoTeste.Model.Pedido.Transportadora
{
    public class Correios : ITransportadora<string>
    {
        public Correios(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public decimal CalculoFrete(decimal valor)
        {
            return 10;
        }
    }
}
