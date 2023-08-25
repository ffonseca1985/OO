namespace ProjetoTeste.Model.Contracts
{
    public interface IFuncionario : Identificador<int>
    {
        public string Nome { get; }
        public double Salario { get; }
    }
}
