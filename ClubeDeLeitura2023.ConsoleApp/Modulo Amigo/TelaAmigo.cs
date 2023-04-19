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

            foreach (Amigo a in amigos)
            {
                Console.WriteLine(a.id + ", " + a.nomeResponsavel + ", " + a.nome);

                Console.ResetColor();
            }
            Console.ReadKey();
        }

        public void InserirNovoAmigo(Amigo amigo)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            repositorioAmigo.Inserir(amigo);
            //MostrarCabecalho("Cadastro de Amigos", "Inserindo Novo Amigo: ");
            ApresentarMensagem("Amigo inserido com sucesso!", ConsoleColor.Green);
        }

        public void EditarAmigo(object repositorioAmigo)
        {
            throw new NotImplementedException();
        }

        public void ExcluirAmigo(object repositorioAmigo)
        {
            throw new NotImplementedException();
        }
    }
}

