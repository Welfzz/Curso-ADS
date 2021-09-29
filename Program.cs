using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //codigo principal
            int decisao;

            do
            {

                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar evento");
                Console.WriteLine("2. Pesquisar evento (deverá retornar os dados do evento + participantes)");
                Console.WriteLine("3. Listar eventos (informar dados básicos do evento + qtde participantes)");
                Console.WriteLine("4. Adicionar participante (retornando o status da operação com mensagem)");
                Console.WriteLine("5. Pesquisar participante (utilizar o e-mail como critério de pesquisa)");
                Console.WriteLine("6. Informar quantidade total de participantes nos eventos da semana");
                Console.WriteLine();

                decisao = int.Parse(Console.ReadLine());


                if(decisao == 1)
                {
                    int dia;

                    Console.Write("Escolha o dia da semana(1=SEG, 2=TER, ..., 6=SAB): ");
                    dia = int.Parse(Console.ReadLine());

                    Eventos eventos = new Eventos();

                    eventos.adicionarEvento(/*dia*/);

                }

                if (decisao == 4)
                {
                    Participante participante = new Participante();

                    Console.Write("Entre com o nome do participante: ");
                    string nome = Console.ReadLine();
                    participante.setNome(nome);

                    Console.Write("Entre com o email do participante: ");
                    string email = Console.ReadLine();
                    participante.setNome(email);

                }


            } while (decisao != 0);

            Console.WriteLine("FIM DO PROGRAMA");
            Console.ReadLine();


        }
    }
}
