using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;


        public Medicamento() { }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
        }

        public int qtdeDisponivel(int c)
        {
            int qtde = c + 1;

            return qtde;
        }

        public void comprar(Lote lote){

        }

        public bool vender(int qtde)
        {
            return false;
        }

        public override string ToString()
        {
            return this.id + "-" + this.nome + "-" + this.laboratorio + "-";
        }

        public bool Equals(object obj)
        {
            return false;
        }



    }
}
