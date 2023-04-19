namespace ClubeDeLeitura2023.ConsoleApp
{
    public class Revista
    {
        public int id;
        public Caixa caixa;
        public int ano;
        public string colecao;



        public Revista()
        {

        }

        public Revista(int id, int ano, string colecao)
        {
            this.id = id;
            this.ano = ano;
            this.colecao = colecao;
        }
    }
    
}