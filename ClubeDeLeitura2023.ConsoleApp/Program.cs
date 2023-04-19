using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            TelaCaixa telaCaixa = new TelaCaixa();


            Revista revista = new Revista();
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            TelaRevista telaRevista = new TelaRevista();


            Amigo amigo = new Amigo();
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            TelaAmigo telaAmigo = new TelaAmigo();


            Emprestimo emprestimo = new Emprestimo();
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();


            while (true)
            {   Tela telaPrincipal = new Tela();
                
                string opcao = telaPrincipal. ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoCadastroAmigo = telaAmigo.ApresentarMenuCadastroAmigo();

                   
                    if (opcaoCadastroAmigo == "1")
                    {
                        telaAmigo.InserirNovoAmigo(amigo);

                    }
                    else if (opcaoCadastroAmigo == "2")
                    {
                        telaAmigo.MostrarAmigos(repositorioAmigo);
                    }
                    else if (opcaoCadastroAmigo == "3")
                    {
                        telaAmigo.EditarAmigo(repositorioAmigo);
                    }
                    else if (opcaoCadastroAmigo == "4")
                    {
                        telaAmigo.ExcluirAmigo(repositorioAmigo);
                    }
                    else if (opcaoCadastroAmigo == "s")
                    {
                        continue;
                    }
                    

                }
                if (opcao == "2")
                {
                    string opcaoCadastroCaixa = telaCaixa.ApresentarMenuCadastroCaixa();


                    if (opcaoCadastroCaixa == "1")
                    {
                        telaCaixa.InserirNovaCaixa(caixa);

                    }
                    else if (opcaoCadastroCaixa == "2")
                    {
                        telaCaixa.MostrarCaixas(repositorioCaixa);
                    }
                    else if (opcaoCadastroCaixa == "3")
                    {
                        telaCaixa.EditarCaixas(repositorioCaixa);
                    }
                    else if (opcaoCadastroCaixa == "4")
                    {
                        telaCaixa.ExcluirCaixas(repositorioCaixa);
                    }

                    else if (opcaoCadastroCaixa == "s")
                    {
                        continue;

                    }
                    

                }
                if (opcao == "3")
                {
                    string opcaoCadastroRevista = telaRevista.ApresentarMenuCadastroRevista();

                    
                    if (opcaoCadastroRevista == "1")
                    {
                        telaRevista.InserirNovaRevista(revista);
                    }
                    else if (opcaoCadastroRevista == "2")
                    {
                        telaRevista.MostrarRevistas(repositorioRevista);
                    }
                    else if (opcaoCadastroRevista == "3")
                    {
                        telaRevista.EditarRevistas(repositorioRevista);
                    }
                    else if (opcaoCadastroRevista == "4")
                    {
                        telaRevista.ExluirRevistas(repositorioRevista);
                    }
                    else if (opcaoCadastroRevista == "s")
                    {
                        continue;

                    }
                    

                }
                if (opcao == "4")
                {
                    string opcaoControleEmprestimo = telaEmprestimo.ApresentarMenuControledeEmprestimos();

                    if (opcaoControleEmprestimo == "1")
                    {
                        telaEmprestimo.InserirNovoEmprestimo(emprestimo);
                    }
                    else if (opcaoControleEmprestimo == "2")
                    {
                        telaEmprestimo.MostrarEmprestimos(repositorioEmprestimo);
                    }
                    else if (opcaoControleEmprestimo == "3")
                    {
                        telaEmprestimo.EditarEmprestimos(repositorioEmprestimo);
                    }
                    else if (opcaoControleEmprestimo == "4")
                    {
                        telaEmprestimo.ExcluirEmprestimos(repositorioEmprestimo);
                    }
                    else if (opcaoControleEmprestimo == "s")
                    {
                        continue;

                    }
                    Console.ReadLine();
                }
                

                
            }
            


        }

            




    }
}



