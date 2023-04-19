using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioAmigo : RepositorioMae
    {
        private int contadorAmigos = 0;
        public void Inserir(Amigo amigo)
        {
            
            contadorAmigos++;

            amigo.id = contadorAmigos;

            listaRegistros.Add(amigo);

            
        }
        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }
   
        public void Editar(int id, Amigo amigoAtualizado)
        {
            foreach(Amigo a in listaRegistros)
            {
                if (a.id == id)
                {
                    a.id = amigoAtualizado.id;
                    a.nome = amigoAtualizado.nome;
                    break;
                }
            }
        }

        public void Excluir(int id)
        {
            Amigo amigoSelecionado = null;

            foreach (Amigo a in listaRegistros)
            {
                if (a.id == id)
                {
                    amigoSelecionado = a;
                    break;
                }
            }
            listaRegistros.Remove(amigoSelecionado);

        }
    }
}