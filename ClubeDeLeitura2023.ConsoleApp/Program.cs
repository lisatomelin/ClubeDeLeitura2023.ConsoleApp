using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ClubeDeLeitura2023.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            caixa.id = 1;
            caixa.etiqueta = "abc-123";
            caixa.cor = "vermelha";

            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            repositorioCaixa.Inserir(caixa);

            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.MostrarCaixas(repositorioCaixa);


            Revista revista = new Revista();
            revista.colecao = "Turma da Mônica";
            revista.ano = 2023;
            revista.caixa = repositorioCaixa.SelecionarPorId(1);

            RepositorioRevista repositorioRevista = new RepositorioRevista();
            repositorioRevista.Inserir(revista);

            TelaRevista telaRevista = new TelaRevista();
            telaRevista.MostrarRevistas(repositorioRevista);

            Amigo amigo = new Amigo();
            amigo.id = 1;
            amigo.nome = "Zeca";
            amigo.nomeResponsavel = "Maria";
            amigo.telefone = "222-222";
            amigo.endereco = "R.01 n. 01 B.01 - ";


            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            repositorioAmigo.Inserir(amigo);

            TelaAmigo telaAmigo = new TelaAmigo();
            telaAmigo.MostrarAmigos(repositorioAmigo);

            Emprestimo emprestimo = new Emprestimo();
            emprestimo.id = 1;
            emprestimo.dataEmprestimo = 200122;
            emprestimo.dataDevolucao = 200222;
           
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            repositorioEmprestimo.Inserir(emprestimo);

            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
            telaEmprestimo.MostrarEmprestimos(repositorioEmprestimo);


            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoCadastroAmigo = telaAmigo.ApresentarMenuCadastroAmigo();

                    if (opcaoCadastroAmigo == "s")
                        continue;

                    if (opcaoCadastroAmigo == "1")
                    {
                        telaAmigo.InserirNovoAmigo(amigo);

                    }
                    else if (opcaoCadastroAmigo == "2")
                    {
                        telaAmigo.MostrarAmigos(repositorioAmigo);
                    }

                    else if (opcaoCadastroAmigo == "s")
                    {
                        continue;
                    }

                }
                Console.ReadLine();

                if (opcao == "2")
                {
                    string opcaoCadastroCaixa = telaCaixa.ApresentarMenuCadastroCaixa();

                    if (opcaoCadastroCaixa == "s")
                        continue;

                    if (opcaoCadastroCaixa == "1")
                    {
                        telaCaixa.InserirNovaCaixa(caixa);

                    }
                    else if (opcaoCadastroCaixa == "2")
                    {
                        telaCaixa.MostrarCaixas(repositorioCaixa);
                    }

                    else if (opcaoCadastroCaixa == "s")
                    {
                        continue;

                    }

                }
                Console.ReadLine();

                if (opcao == "3")
                {
                    string opcaoCadastroRevista = telaRevista.ApresentarMenuCadastroRevista();

                    if (opcaoCadastroRevista == "s")
                        continue;

                    if (opcaoCadastroRevista == "1")
                    {
                        telaRevista.InserirNovaRevista(revista);
                    }
                    if (opcaoCadastroRevista == "1")
                    {
                        telaRevista.MostrarRevistas(repositorioRevista);
                    }
                    else if (opcaoCadastroRevista == "s")
                    {
                        continue;

                    }

                }
                Console.ReadLine();

                if (opcao == "4")
                {
                    string opcaoControleEmprestimo = telaEmprestimo.ApresentarMenuControledeEmprestimos();

                    if (opcaoControleEmprestimo == "s")
                        continue;

                    if (opcaoControleEmprestimo == "1")
                    {
                        telaEmprestimo.InserirNovoEmprestimo(emprestimo);
                    }
                    if (opcaoControleEmprestimo == "2")
                    {
                        telaEmprestimo.MostrarEmprestimos(repositorioEmprestimo);
                    }
                    else if (opcaoControleEmprestimo == "s")
                    {
                        continue;

                    }
                }
                Console.ReadLine();

                
            }
            static string ApresentarMenuPrincipal()
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


        }

            




    }
}



