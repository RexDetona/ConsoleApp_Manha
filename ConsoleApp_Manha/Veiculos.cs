using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Veiculos
    {
        public int numeroRodas;
        public int numeroPortas;
        public string cor;
        public int quantidadeAcentos;
        public bool pagaImposto;

        public string ExibirDados()
        {
            return "Nº Portas" + numeroPortas + " Cor:" + cor;
        }
    }
}
