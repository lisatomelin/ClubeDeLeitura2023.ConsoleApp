using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class TelaCaixa : Tela
    {
        RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        public string ApresentarMenuCadastroCaixa()
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Cadastro Caixa");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Novo Cadastro de Caixa");

            Console.WriteLine("Digite 2 para Visulizar Caixas");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaCaixa(Caixa caixa)
        {
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            repositorioCaixa.Inserir(caixa);

            MostrarCabecalho("Cadastro de Caixas", "Inserindo Nova Caixa: ");
            ApresentarMensagem("Caixa inserida com sucesso!", ConsoleColor.Green);
        }

        public void MostrarCaixas(RepositorioCaixa repositorioCaixa)
        {
            ArrayList caixas = repositorioCaixa.SelecionarTodos();

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine(caixa.id + ", " + caixa.cor + ", " + caixa.etiqueta);
            }
            Console.ReadKey();
        }
    }
}