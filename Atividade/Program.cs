using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {


            int decisao;

            Medicamento remedio;


            do
            {

                Console.WriteLine("0.  Finalizar processo");
                Console.WriteLine("1.  Cadastrar medicamento");
                Console.WriteLine("2.  Consultar medicamento (sintético: informar dados1)");
                Console.WriteLine("3.  Consultar medicamento (analítico: informar dados1 + lotes2)");
                Console.WriteLine("4.  Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5.  Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6.  Listar medicamentos (informando dados sintéticos)");
                Console.WriteLine();
                Console.WriteLine("Qual ação deseja tomar? ");
                decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    

                    Console.WriteLine("Entre com o ID do remédio: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o Nome do remédio: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Entre com o Laboratório produzido: ");
                    string lab = Console.ReadLine();

                    remedio = new Medicamento(id, nome, lab);

                    remedio.qtdeDisponivel(1);

                }
                if (decisao == 2)
                {
                    Console.WriteLine("Medicamento: " + remedio.ToString());
                }


            } while (decisao < 0 || decisao > 6);

        }
    }
}
