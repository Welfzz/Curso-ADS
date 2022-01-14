using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Contrato

    {
        
        private string nome;
        private int qtde;
        //private List<string> listaItens;
        //private DateTime agendamento;


        //nome
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        //qtde
        public void setQtde(int qtde)
        {
            this.qtde = qtde;
        }

        public int getQtde()
        {
            return this.qtde;
        }

        
    }
}
