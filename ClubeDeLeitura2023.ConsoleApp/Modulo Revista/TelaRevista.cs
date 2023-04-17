﻿using System.Collections;
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

            Console.WriteLine("Cadastro Revista");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir um Novo Cadastro de Revista");

            Console.WriteLine("Digite 2 para Visulizar Revistas");

            Console.WriteLine();

            Console.WriteLine("Digite s para voltar para o menu principal");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaRevista(Revista revista)
        {
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            repositorioRevista.Inserir(revista);

            MostrarCabecalho("Cadastro de Revistas", "Inserindo Nova Revista: ");
            ApresentarMensagem("Revista inserida com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        public void MostrarRevistas(RepositorioRevista repositorioRevista)
        {

            ArrayList revistas = repositorioRevista.SelecionarTodos();

            foreach (Revista r in revistas)
            {
                Console.WriteLine(r.id + ", " + r.colecao + ", " + r.caixa.etiqueta);
            }
            Console.ReadKey();
        }
    }
}