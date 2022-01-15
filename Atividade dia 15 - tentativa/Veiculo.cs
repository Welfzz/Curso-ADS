using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Veiculo
    {
        private int id;
        private string placa;
        private int locacao;

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
        public void setPlaca(string placa)
        {
            this.placa = placa;
        }
        public string getPlaca()
        {
            return this.placa;
        }

        //placa
        public void setLocacao(int locacao)
        {
            this.locacao = locacao;
        }
        public int getLocacao()
        {
            return this.locacao;
        }
    }
}
