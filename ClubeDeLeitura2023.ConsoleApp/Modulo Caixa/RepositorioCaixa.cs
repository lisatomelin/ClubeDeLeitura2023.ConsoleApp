using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioCaixa : RepositorioMae
    {
        

        public ArrayList SelecionarTodos()
        {
            ArrayList listaOrdenadaPelaCor = OrdenarLista();
            return listaOrdenadaPelaCor;           
        }

        private ArrayList OrdenarLista()
        {
            return listaRegistros;
        }

        public void Inserir(Caixa caixa)
        {
            listaRegistros.Add(caixa);
        }

        public Caixa SelecionarPorId(int id)
        {
            Caixa caixa = null;

            foreach (Caixa c in listaRegistros)
            {
                if (c.id == id)
                {
                    caixa = c;
                    break;
                }
            }

            return caixa;


        }
    }
}