using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Participante
    {
        private string email;
        private string nome;

      

        public void setNome(string nome) {
            this.nome = nome;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }


        public bool podeInscrever(Eventos e)
        {

            return false;
        }

        public bool Equals()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        

    }
}
