namespace ClubeDeLeitura2023.ConsoleApp
{
    public class Caixa
    {
        public int id;
        public string cor;
        public string etiqueta;

        public Caixa() 
        {
        }

        public Caixa(string cor, string etiqueta)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
        }

    }
}