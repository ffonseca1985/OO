
using ProjetoTeste.Model.Beneficios;
using ProjetoTeste.Model.Contracts;
using ProjetoTeste.Model.Funcionario;
using ProjetoTeste.Model.Pedido;
using ProjetoTeste.Model.Pedido.Transportadora;

namespace OrientacaoAObjeto.ProjetoTeste
{
    public class Program
    {
        public static void Main()
        {
            var pedido = new Pedido(Guid.NewGuid().ToString(), new Vendedor(1, "Fabio", 10));

            pedido.AddItem("janela-123", 1, 3);
            pedido.AddTransportadora(new JadLog("Jadlog", "Jadlog"));

            pedido.CalculoFrete();
            var dividendo = new Dividendos();

            //IFuncionario socio = new CEO(1, "Fabio", 1);
            ISocio socio = new CEO(1, "Fabio", 1);

            dividendo.AdicionarSocio(socio);
             
        }
    }
}


