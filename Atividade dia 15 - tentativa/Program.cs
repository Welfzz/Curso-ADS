using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int dec;

            do
            {
                Veiculo veiculo = new Veiculo();
                Veiculos veiculos = new Veiculos();
                Garagem garagem = new Garagem();

                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2. Cadastrar garagem");
                Console.WriteLine("3. Iniciar jornada");
                Console.WriteLine("4. Encerrar jornada");
                Console.WriteLine("5. Liberar viagem de uma determinada origem para um determinado destino");
                Console.WriteLine("6. Listar veículos em determinada garagem");
                Console.WriteLine("7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino");

                Console.WriteLine();
                Console.Write("Qual decisão deseja tomar? ");
                Console.WriteLine();

                dec = int.Parse(Console.ReadLine());

                if (dec == 1)
                {
                    Console.Write("Entre com o ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Entre com a placa: ");
                    string placa = Console.ReadLine();
                    Console.Write("Entre com a locação: ");
                    int locacao = int.Parse(Console.ReadLine());

                    veiculo.setId(id);
                    veiculo.setPlaca(placa);
                    veiculo.setLocacao(locacao);
                    veiculos.incluir(veiculo);

                    Console.WriteLine();
                    Console.WriteLine("Id: " + veiculo.getId());
                    Console.WriteLine("Placa: " + veiculo.getId());
                    Console.WriteLine("Locação: " + veiculo.getId());
                    Console.WriteLine();
                }

                if (dec == 2)
                {
                    Console.Write("Entre com o ID da garagem: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o local: ");
                    string local = Console.ReadLine();

                    garagem.setId(id);
                    garagem.setLocal(local);

                    Console.WriteLine();
                    Console.WriteLine("Id garagem: " + garagem.getId());
                    Console.WriteLine("Local garagem: " + garagem.getLocal());
                    Console.WriteLine();
                }

            } while (dec > 0 && dec < 10);

        }
    }
}
