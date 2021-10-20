using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Data
    {

        private int dia;
        private int mes;
        protected int ano;

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            return this.dia + "/" + this.mes + "/" + this.ano;
        }

    }
}
