using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Medicamentos
    {

        private List<Medicamento> listaMedicamentos;

        public Medicamentos() { }

        public void adicionar(Medicamento Medicamento)
        {
            listaMedicamentos.Add(Medicamento);
        }

        public bool deletar(Medicamento Medicamento)
        {
            listaMedicamentos.Remove(Medicamento);
            return true;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            return medicamento;
        }

    }
}
