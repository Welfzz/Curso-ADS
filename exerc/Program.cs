using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec;

            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                Console.WriteLine();
                Console.Write("Qual decisão deseja tomar? ");
                dec = int.Parse(Console.ReadLine());

                if (dec == 1)
                {
                    List<Contato> agenda;
                    agenda = new List<Contato>();

                    Contatos contatos = new Contatos();

                    Console.Write("Entre com o Email: ");
                    string e = Console.ReadLine();
                    Console.Write("Entre com o Nome: ");
                    string n = Console.ReadLine();
                    Console.Write("Entre com o Telefone: ");
                    string t = Console.ReadLine();



                    Data data = new Data();

                    Console.Write("Entre com o Dia: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o Mes: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o Ano: ");
                    int a = int.Parse(Console.ReadLine());

                    data.setData(d, m, a);
                    contatos.adicionar(e, n, t);


                }

                if (dec == 5)
                {
                    Contato contato = new Contato();
                    contato.ToString();

                }


             } while (dec >= 0 && dec <= 5);

            Console.ReadLine();
        }
    }
}
