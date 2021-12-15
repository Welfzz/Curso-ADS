using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public void setID(int id)
        {
            this.id = id;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void registrarLog(Log log)
        {
            
        }


    }
}
