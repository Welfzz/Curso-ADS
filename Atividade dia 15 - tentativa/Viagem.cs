using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Viagem
    {
        private int id;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculos;

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        
        public void setOrigem(Garagem ori)
        {
            this.origem = ori;
        }
        public Garagem getOrigem()
        {
            return this.origem;
        }

        public void setDestino(Garagem dest)
        {
            this.destino = dest;
        }
        public Garagem getDesino()
        {
            return this.destino;
        }


        public void setVeiculos(Veiculo veic)
        {
            this.veiculos = veic;
        }
        public Veiculo getVeiculos()
        {
            return this.veiculos;
        }
    }
}
