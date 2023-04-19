using System.Collections;
using System.Reflection.Metadata.Ecma335;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class TelaAmigo : Tela
    {
        RepositorioAmigo repositorioAmigo = new RepositorioAmigo();

        public string ApresentarMenuCadastroAmigo()
        {

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Cadastro e Amigos \n");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Cadastro de Amigo");

            Console.WriteLine("Digite 2 para Visulizar Amigos");

            Console.WriteLine("Digite 3 para Editar um Amigo");

            Console.WriteLine("Digite 4 para Excluir um Amigo");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;

        }

        public void MostrarAmigos(RepositorioAmigo repositorioAmigo)
        {
            ArrayList amigos = repositorioAmigo.SelecionarTodos();

            ApresentarTabela(amigos);

            
        }

        public void InserirNovoAmigo(Amigo amigo)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();

            ObterAmigo();

            repositorioAmigo.Inserir(amigo);

            MostrarCabecalho("Inserindo um novo Amigo...", ConsoleColor.Blue);

            MostrarAmigos(repositorioAmigo);

            ApresentarMensagem("Amigo inserido com sucesso!", ConsoleColor.Green);

            Console.ReadLine();

        }


        public void EditarAmigo(RepositorioAmigo repositorioAmigo)
        {
            MostrarCabecalho("Editando um Amigo já cadastrado", ConsoleColor.Blue);

            Console.WriteLine("Digite o id do Amigo: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Amigo amigoAtualizado = ObterAmigo();

            repositorioAmigo.Editar(id, amigoAtualizado);
        }

        public void ExcluirAmigo(RepositorioAmigo repositorioAmigo)
        {
            MostrarCabecalho("Excluindo uma caixa já cadastrada", ConsoleColor.Blue);

            MostrarCabecalho("Editando uma caixa já cadastrada", ConsoleColor.Blue);

            Console.WriteLine("Digite o id da caixa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Amigo amigoAtualizada = ObterAmigo();

            repositorioAmigo.Excluir(id);
        }


        private Amigo ObterAmigo()
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone:");
            string telefone = Console.ReadLine();

            Amigo amigo = new Amigo(nome, telefone);

            return amigo;

        }

        private void ApresentarTabela(ArrayList amigos)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10}", "Id", "Nome", "Telefone");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Amigo amigo in amigos)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10}", amigo.id, amigo.nome, amigo.telefone);
            }
            Console.ReadLine();
        }


    }
}

