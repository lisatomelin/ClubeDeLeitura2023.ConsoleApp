using System.Collections;
using ClubeDeLeitura2023.ConsoleApp.Compartilhado;

namespace ClubeDeLeitura2023.ConsoleApp
{
    public class RepositorioCaixa : RepositorioMae
    {
        private int contadorCaixas = 0;

        public void Inserir(Caixa caixa)
        {
            contadorCaixas++;

            caixa.id = contadorCaixas;

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

        public ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }

        public void Editar(int id, Caixa caixaAtualizada)
        {
            foreach (Caixa c in listaRegistros)
            {
                if (c.id == id)
                {
                    c.cor = caixaAtualizada.cor;
                    c.etiqueta = caixaAtualizada.etiqueta;
                    break;
                }
            }
            
        }

       public void Excluir(int id)
       {
            Caixa caixaSelecionada = null;

            foreach (Caixa c in listaRegistros)
            {
                if (c.id == id)
                {
                    caixaSelecionada = c;
                    break;
                }
            }
            listaRegistros.Remove(caixaSelecionada);
       }
    }
}