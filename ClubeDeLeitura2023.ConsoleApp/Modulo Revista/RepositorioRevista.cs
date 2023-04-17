using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioRevista : RepositorioMae
    {
        public void Inserir(Revista revista)
        {
            listaRegistros.Add(revista);
        }

        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }
    }
}