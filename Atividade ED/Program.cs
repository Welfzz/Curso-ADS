using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int decisao;
            Ambiente ambiente = new Ambiente();
            Usuario usuario = new Usuario();
            Cadastro cadastro = new Cadastro();


            do
            {

                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar ambiente");
                Console.WriteLine("2. Consultar ambiente");
                Console.WriteLine("3. Excluir ambiente");
                Console.WriteLine("4. Cadastrar usuario");
                Console.WriteLine("5. Consultar usuario");
                Console.WriteLine("6. Excluir usuario");
                Console.WriteLine("7. Conceder permissão de acesso ao usuario");
                Console.WriteLine("8. Revogar permissão de acesso ao usuario");
                Console.WriteLine("9. Registrar acesso");
                Console.WriteLine("10. Consultar logs de acesso");
                Console.WriteLine();
                Console.WriteLine("Qual decisão deseja tomar? ");
                decisao = int.Parse(Console.ReadLine());


                if (decisao == 1)
                {
                    Console.Write("Entre com o ID do ambiente: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome do ambiente: ");
                    string nome = Console.ReadLine();



                    ambiente.setID(id);
                    ambiente.setNome(nome);
                }

                if (decisao == 4)
                {
                    Console.Write("Entre com o ID do usuário: ");
                    int id_user = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome do usuário: ");
                    string nome_user = Console.ReadLine();

                    usuario.setID(id_user);
                    usuario.setNome(nome_user);

                }
                if (decisao == 0)
                {
                    break;
                }


            } while (decisao > 10 || decisao < 0);


            Console.ReadLine();

        }
    }
}
