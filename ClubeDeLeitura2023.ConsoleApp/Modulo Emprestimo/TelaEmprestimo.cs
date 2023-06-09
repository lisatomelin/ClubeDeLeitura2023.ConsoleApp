﻿using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class TelaEmprestimo : Tela
    {
        RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
        
        public string ApresentarMenuControledeEmprestimos()
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Cadastro Empréstimo \n");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Cadastro de Empréstimo");

            Console.WriteLine("Digite 2 para Visulizar Empréstimos");

            Console.WriteLine("Digite 3 para Editar um Empréstimo");

            Console.WriteLine("Digite 4 para Excluir um Empréstimo");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoEmprestimo(Emprestimo emprestimo)
        {
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            repositorioEmprestimo.Inserir(emprestimo);

            //MostrarCabecalho("Cadastro de Emprestimo", "Inserindo Novo Emprestimo: ");
            ApresentarMensagem("Emprestimo inserido com sucesso!", ConsoleColor.Green);
        }

        public void MostrarEmprestimos(RepositorioEmprestimo repositorioEmprestimo)
        {
            ArrayList emprestimos = repositorioEmprestimo.SelecionarTodos();
            
            foreach (Emprestimo e in emprestimos)
            {
                Console.WriteLine(e.id + " - " + e.dataEmprestimo + " - " + e.dataDevolucao);
            }
            Console.ReadKey();
        }

        public void EditarEmprestimos(object repositorioEmprestimo)
        {
            throw new NotImplementedException();
        }

        public void ExcluirEmprestimos(object repositorioEmprestimo)
        {
            throw new NotImplementedException();
        }
    }
}