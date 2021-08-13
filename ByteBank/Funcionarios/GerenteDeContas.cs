using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25 ;
        }
    }
}
