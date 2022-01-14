using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Locacao
    {
        private int id;
        private bool avariado;
        private double valor_locacao;
        
        //id
        public void setTipo(int tipo)
        {
            this.id = tipo;
        }

        public int getTipo()
        {
            return this.id;
        }

        //nome
        public void setAvariado(bool ava)
        {
            this.avariado = ava;
        }

        public bool getAvariado()
        {
            return this.avariado;
        }

        //valor
        public void setValor(double valor)
        {
            this.valor_locacao = valor;
        }

        public double getValor()
        {
            return this.valor_locacao;
        }

        
    }
}
