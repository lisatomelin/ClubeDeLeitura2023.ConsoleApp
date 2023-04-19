using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class TelaCaixa : Tela
    {
        //RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        public string ApresentarMenuCadastroCaixa()
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Cadastro Caixa \n");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Cadastro de Caixa");

            Console.WriteLine("Digite 2 para Visulizar Caixas");

            Console.WriteLine("Digite 3 para Editar uma Caixa");

            Console.WriteLine("Digite 4 para Excluir uma Caixa");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaCaixa(Caixa caixa)
        {
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            repositorioCaixa.Inserir(caixa);
            ObterCaixa();

            MostrarCabecalho("Inserindo uma nova Caixa...", ConsoleColor.Blue);

            MostrarCaixas(repositorioCaixa);

            ApresentarMensagem("Caixa inserida com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        public void MostrarCaixas(RepositorioCaixa repositorioCaixa)
        {
            ArrayList caixas = repositorioCaixa.SelecionarTodos();

            MostrarCabecalho("Visualizando Caixas...", ConsoleColor.Blue);

            ApresentarTabela(caixas);

            Console.ReadLine();

        }

        public void EditarCaixas(RepositorioCaixa repositorioCaixa)
        {
            MostrarCabecalho("Editando uma caixa já cadastrada", ConsoleColor.Blue);

            Console.WriteLine("Digite o id da caixa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Caixa caixaAtualizada = ObterCaixa();

            repositorioCaixa.Editar(id, caixaAtualizada);
        }
        public void ExcluirCaixas(RepositorioCaixa repositorioCaixa)
        {
            MostrarCabecalho("Excluindo uma caixa já cadastrada", ConsoleColor.Blue);

            Console.WriteLine("Digite o id da caixa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Caixa caixaAtualizada = ObterCaixa();

            repositorioCaixa.Excluir(id);

        }          
        private Caixa ObterCaixa()
        {
            Console.WriteLine("Digite a cor:");
            string cor = Console.ReadLine();

            Console.WriteLine("Digite a etiqueta:");
            string etiqueta = Console.ReadLine();

            Caixa caixa = new Caixa(cor, etiqueta);

            return caixa;

        }
        private void ApresentarTabela(ArrayList caixas)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10}", "Id", "Etiqueta", "Cor");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine("{0, -10} | {1, -10}  | {2, -10}", caixa.id, caixa.etiqueta, caixa.cor);
            }
        }
    }
}