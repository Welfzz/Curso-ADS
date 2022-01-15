using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        //id
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        //placa
        public void setLocal(string local)
        {
            this.local = local;
        }
        public string getLocal()
        {
            return this.local;
        }

        public int qtdeDeVeiculos()
        {
            return 0;
        }

        public int potencialDeTransporte() {

            return 0;

        }
    }
}
