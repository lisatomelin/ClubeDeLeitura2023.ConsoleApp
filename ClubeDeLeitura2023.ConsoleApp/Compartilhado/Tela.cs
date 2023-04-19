using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDeLeitura2023.ConsoleApp.Compartilhado
{
    public class Tela
    {


        public string ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Clube de Leitura 2023");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Acessar Cadastro Amigos");

            Console.WriteLine("Digite 2 para Acessar Cadastro Caixa");

            Console.WriteLine("Digite 3 para Acessar Cadastro Revistas");

            Console.WriteLine("Digite 4 para Acessar Controle de Emprestimos");

            Console.WriteLine();

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;

        }
        public void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }

        public void MostrarCabecalho(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();

        }




    }
}
