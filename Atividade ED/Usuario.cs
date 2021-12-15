using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Usuario
    {

        private int id;
        private string nome;
        private List<Ambiente> ambientes;


        public void setID(int id)
        {
            this.id = id;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }


        public bool concederPermissao(Ambiente ambiente)
        {
            return false;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {

            return false;
        }




    }
}
