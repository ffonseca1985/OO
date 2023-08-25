using ProjetoTeste.Model.Contracts;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTeste.Model.Funcionario
{
    public class CEO : ISocio
    {
        public CEO(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public double Dividendo { get; private set; }

        public void ReceberDividendos(double dividendo)
        {
            this.Dividendo = dividendo;
        }
    }
}
