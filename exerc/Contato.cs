using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Contato : Data
    {

        protected string email;
        protected string nome;
        protected string telefone;
        protected Data tdNasc;

       

        public int getIdade()
        {
            return 2021 - this.ano;
        }

        public override string ToString()
        {
            return "Email: " + this.email + "\nNome: " + this.nome + "\nTelefone: " + this.telefone + "\nData Nascimento: ";
        }

    }
}
