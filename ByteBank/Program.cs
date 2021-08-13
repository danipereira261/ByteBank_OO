using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("12345678911", 3000);
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("12312312311", 5000);
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("45645645644", 1000);
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("78978978977", 4000);
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("32132132133", 3000);
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês: R$ " + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("12312312311", 5000);
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeContas camila = new GerenteDeContas("78978978977", 4000);
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";


            sistemaInterno.Logar(roberta,"123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");

        }
    }
}
