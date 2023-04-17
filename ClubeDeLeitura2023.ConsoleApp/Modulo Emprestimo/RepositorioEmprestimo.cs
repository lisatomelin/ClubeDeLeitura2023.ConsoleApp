using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioEmprestimo : RepositorioMae
    {
        
        public void Inserir(Emprestimo emprestimo)
        {
            listaRegistros.Add(emprestimo);
        }
        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }

        public Emprestimo SelecionarPorDataEmprestimo(int dataEmprestimo)
        {
            Emprestimo emprestimo = null;

            foreach (Emprestimo e in listaRegistros)
            {
                if (e.dataEmprestimo == dataEmprestimo)
                {
                    emprestimo = e;
                    break;
                }
            }

            return emprestimo;
        }
        

    }
}