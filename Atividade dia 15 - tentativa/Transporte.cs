using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Transporte
    {
        private Veiculo veiculo;
        private int qtdeTransportada;


        public void setVeiculo(Veiculo vei)
        {
            this.veiculo = vei;
        }
        public int getVeiculo()
        {
            return this.qtdeTransportada;
        }

        public void setQtdeTransportada(int qtde)
        {
            this.qtdeTransportada = qtde;
        }
        public int getQtdeTransportada()
        {
            return this.qtdeTransportada;
        }
    }
}
