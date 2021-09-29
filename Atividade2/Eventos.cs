using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Eventos
    {
        private Evento[] osEventos;

        public void adicionarEvento(Evento e)
        {
            for (int i =0; i < 6;i++)
            {
                this.osEventos[i] = new Evento();
            }
            
        }

        public string pesquisarParticipante(Participante p)
        {
            return "";
        }

        public int qtdeParticipantes()
        {
            return 0;
        }

        public string listaEventos()
        {
            return "";
        }
    }
}
