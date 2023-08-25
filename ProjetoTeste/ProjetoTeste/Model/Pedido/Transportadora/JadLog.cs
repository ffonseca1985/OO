
using ProjetoTeste.Model.Pedido.Contracts;

namespace ProjetoTeste.Model.Pedido.Transportadora
{
    public class JadLog : ITransportadora<string>
    {
        public JadLog(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public decimal CalculoFrete(decimal valor)
        {
            return valor * 0.05m;
        }
    }
}
