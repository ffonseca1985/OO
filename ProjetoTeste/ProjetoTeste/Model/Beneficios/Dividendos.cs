using ProjetoTeste.Model.Contracts;

namespace ProjetoTeste.Model.Beneficios
{
    public class Dividendos
    {
        public List<ISocio> Socios { get; set; } = new List<ISocio>();

        public void AdicionarSocio(ISocio socio)
        {
            Socios.Add(socio);
        }

        public void PagarDividendos(double lucro)
        {
            foreach (var item in Socios)
            {
                item.ReceberDividendos(lucro / Socios.Count());
            }
        }
    }
}
