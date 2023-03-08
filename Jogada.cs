namespace JogoDaForca
{
    public partial class Program
    {
        public class Jogada
        {
            public string Palavra { get; set; }
            public string Dica { get; set; }


            public Jogada(string palavra, string dica)
            {
                this.Palavra = palavra;
                this.Dica = dica;
            }


            public static Jogada SortearJogada(List<Jogada> jogadas)
            {
                var random = new Random();
                int index = random.Next(jogadas.Count);
                return jogadas[index];
            }

            public static List<Jogada> ConstruirJogadas()
            {
                List<Jogada> jogadas = new List<Jogada>();

                jogadas.Add(new Jogada("padaria", "Fabrica sabores e sonhos."));
                jogadas.Add(new Jogada("edredom", "Companheiro inserparável no inverno."));
                jogadas.Add(new Jogada("automovel", "Alguns tem cor de prata outros de ouro, mas todos tem bocharra."));
                jogadas.Add(new Jogada("maionese", "É fácil de fazer mas vezes não da certo."));

                return jogadas;
            }
        }
    }
}

