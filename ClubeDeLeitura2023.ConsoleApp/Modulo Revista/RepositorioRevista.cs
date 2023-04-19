using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioRevista : RepositorioMae
    {
        int contadorRevistas = 0;
        public void Inserir(Revista revista)
        {
            contadorRevistas++;

            revista.id = contadorRevistas;

            listaRegistros.Add(revista);
            
        }

        public Revista SelecionarPorId(int id)
        {
            Revista revista = null;

            foreach (Revista r in listaRegistros)
            {
                if (r.id == id)
                {
                    revista = r;
                    break;
                }
            }

            return revista;


        }
        public void Editar(int id, Revista revistaAtualizada)
        {
            foreach (Revista r in listaRegistros)
            {
                if (r.id == id)
                {
                    r.colecao = revistaAtualizada.colecao;
                    r.ano = revistaAtualizada.ano;
                    break;
                }
            }

        }

        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }

        public void Excluir(int id)
        {
            Revista revistaSelecionada = null;

            foreach (Revista r in listaRegistros)
            {
                if (r.id == id)
                {
                    revistaSelecionada = r;
                    break;
                }
            }
            listaRegistros.Remove(revistaSelecionada);
        }
    }
}