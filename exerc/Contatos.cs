using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Contatos 
    {
        private List<Contato> agenda = new List<Contato>();

        public Contatos() : this(new List<Contato>()){}

        public Contatos(List<Contato> agenda)
        {
            this.agenda = agenda;
        }

        public bool adicionar(Contato c)
        {
            bool resposta = false;
            if (!agenda.Exists(p => p.email.ToString() == c.email.ToString()))
            {
                resposta = true;
                this.agenda.Add(c);
            }
            return resposta;

        }
        public Contato pesquisar(Contato c)
        {
            Contato resposta = new Contato();
            List<Contato> contato = agenda.FindAll(delegate (Contato p)
            {
                return p.email.ToString() == c.email.ToString();
            });

            return resposta;
        }
        public bool alterar(Contato c)
        {
            bool resposta = false;
            List<Contato> contato = agenda.FindAll(delegate (Contato p)
            {
                return p.email.ToString() == c.email.ToString();
            });

            contato.ForEach(delegate (Contato p)
            {

                p.nome = c.nome.ToString();
                p.email = c.email.ToString();
                p.telefone = c.telefone.ToString();
                Data data = new Data(int.Parse(c.tdNasc.dia.ToString()), int.Parse(c.tdNasc.mes.ToString()), int.Parse(c.tdNasc.ano.ToString()));
                p.tdNasc = data;
                resposta = true;

            });
            return resposta;

        }
        public bool remover(Contato c)
        {
            bool resposta = false;

            agenda.RemoveAll(p => p.email == c.email);
            if (!agenda.Exists(x => x == c))
            {
                resposta = true;
            }
            return resposta;
        }

        internal void pesquisar(string e)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Object obj)
        {
            return false;
        }

        internal void alterar(string e)
        {
            throw new NotImplementedException();
        }

        internal void remover(string e)
        {
            throw new NotImplementedException();
        }
    }
}
