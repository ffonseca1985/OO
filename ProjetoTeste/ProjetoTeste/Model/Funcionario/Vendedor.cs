using ProjetoTeste.Model.Contracts;

namespace ProjetoTeste.Model.Funcionario
{
    public class Vendedor : IFuncionario, ISubordinado, IComissionado
    {
        public Vendedor(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public double SelecionarComisssao(decimal totalVendas)
        {
            throw new NotImplementedException();
        }

        public List<IFuncionario> SelecionarSubordinado()
        {
            throw new NotImplementedException();
        }
    }
}
