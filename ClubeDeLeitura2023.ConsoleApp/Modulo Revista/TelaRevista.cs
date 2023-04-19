using System;
using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class TelaRevista : Tela
    {
        RepositorioRevista repositorioRevista = new RepositorioRevista();
        public string ApresentarMenuCadastroRevista()
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Cadastro Revista \n");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Cadastro de Revista");

            Console.WriteLine("Digite 2 para Visulizar Revistas");

            Console.WriteLine("Digite 3 para Editar uma Revista");

            Console.WriteLine("Digite 4 para Excluir uma Revista");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaRevista(Revista revista)
        {
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            repositorioRevista.Inserir(revista);

            ObterRevista();

            ApresentarMensagem("Revista inserida com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        public void MostrarRevistas(RepositorioRevista repositorioRevista)
        {

            ArrayList revistas = repositorioRevista.SelecionarTodos();

            MostrarCabecalho("Visualizando revistas...", ConsoleColor.Blue);

            ApresentarTabela(revistas);

            Console.ReadLine();
        }

        public void EditarRevistas(RepositorioRevista repositorioRevista)
        {
            MostrarCabecalho("Editando uma revista já cadastrada", ConsoleColor.Blue);

            Console.WriteLine("Digite o id da revista: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Revista revistaAtualizada = ObterRevista();

            repositorioRevista.Editar(id, revistaAtualizada);
        }

        public void ExluirRevistas(RepositorioRevista repositorioRevista)
        {
            MostrarCabecalho("Excluindo uma revista já cadastrada", ConsoleColor.Blue);

            Console.WriteLine("Digite o id da revista: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Revista revistaAtualizada = ObterRevista();

            repositorioRevista.Excluir(id);
        }

        private Revista ObterRevista()
        {
            Console.WriteLine("Digite id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano da revista:");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a coleção da Revista: ");
            string colecao = Console.ReadLine();

            Revista revista = new Revista(id, ano, colecao);

            return revista;

        }

        private void ApresentarTabela(ArrayList revistas)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10}", "Id", "Caixa - Etiqueta", "Coleção");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Revista revista in revistas)
            {
                Console.WriteLine("{0, -10} | {1, -10}  | {2, -10}", revista.id, revista.caixa.etiqueta, revista.colecao);
            }
        }
    }
}