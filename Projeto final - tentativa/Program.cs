using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {


            Locacao locacao = new Locacao();
            Contrato contrato = new Contrato();

            // computadores, impressoras, datashows

            

            int perm;
            do
            {

                Console.WriteLine("1. Cadastrar tipo de equipamento");
                Console.WriteLine("2. Consultar tipo de equipamento");
                Console.WriteLine("3. Cadastrar equipamento");
                Console.WriteLine("4. Registrar Contrato de Locação");
                Console.WriteLine("5. Consultar Contratos de Locação");
                Console.WriteLine("6. Liberar de Contrato de Locação");
                Console.WriteLine("7. Consultar Contratos de Locação liberados");
                Console.WriteLine("8. Devolver equipamentos de Contrato de Locação liberado");
                Console.WriteLine();
                Console.Write("Qual decisão deseja tomar? ");
                perm = int.Parse(Console.ReadLine());


                if(perm == 1)
                {
                    Console.WriteLine();
                    Console.Write("ID equipamento: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Valor locação: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("Avariado: ");
                    bool ava = bool.Parse(Console.ReadLine());
                    Console.WriteLine();


                    locacao.setTipo(id);
                    locacao.setValor(valor);
                    locacao.setAvariado(ava);
                }

                if (perm == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID (Tipo): " + locacao.getTipo());
                    Console.WriteLine("Avariado (true/false): " + locacao.getAvariado());
                    Console.WriteLine("Valor da Locação: " + locacao.getValor());
                    Console.WriteLine();
                }

                if (perm == 4)
                {
                    Console.WriteLine();
                    Console.Write("Nome equipamento: ");
                    string nome = Console.ReadLine();
                    Console.Write("Quantidade de itens: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    contrato.setNome(nome);
                    contrato.setQtde(quantidade);
                    Console.WriteLine();
                }

                if (perm == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome: " + contrato.getNome());
                    Console.WriteLine("Quantidade: " + contrato.getQtde());
                    Console.WriteLine();
                }

                if (perm == 6)
                {
                    contrato.setNome("Sem Itens disponíveis");
                    contrato.setQtde(0);

                    Console.WriteLine();
                    Console.WriteLine("Nome: " + contrato.getNome());
                    Console.WriteLine("Quantidade: " + contrato.getQtde());
                    Console.WriteLine();
                }

            } while (perm > 0 && perm < 9);
            
            

            Console.ReadLine();
        }
    }
}
