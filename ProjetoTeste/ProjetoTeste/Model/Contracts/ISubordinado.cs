using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste.Model.Contracts
{
    public interface ISubordinado
    {
        List<IFuncionario> SelecionarSubordinado();
    }
}
