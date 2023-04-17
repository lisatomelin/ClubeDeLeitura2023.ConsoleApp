using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioAmigo : RepositorioMae
    {
        public void Inserir(Amigo amigo)
        {
            listaRegistros.Add(amigo);
        }
        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }
        public Amigo SelecionarPorNome(string nome)
        {
            Amigo amigo = null;

            foreach (Amigo a in listaRegistros)
            {
                if (a.nome == nome)
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;


        }
    }
}