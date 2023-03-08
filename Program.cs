namespace JogoDaForca
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            List<Jogada> jogadas = Jogada.ConstruirJogadas();
            Jogada jogada = Jogada.SortearJogada(jogadas);

            char[] letrasOcultas = new char[jogada.Palavra.Length];
            int tentativas = 0;

            for (int i = 0; i < letrasOcultas.Length; i++)
            {
                letrasOcultas[i] = '_';
            }

            while (tentativas != 6)
            {
                Console.Clear();

                System.Console.WriteLine($"A dica é: {jogada.Dica} \n\n");

                foreach (var item in letrasOcultas)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\n\nDigite a letra escolhida");
                char letra = Convert.ToChar(Console.ReadLine()!);

                bool acertou = false;

                for (int i = 0; i < jogada.Palavra.Length; i++)
                {
                    if (jogada.Palavra[i] == letra)
                    {
                        letrasOcultas[i] = letra;
                        acertou = true;
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine($"Fim de jogo, {tentativas++} tentativas efetuadas.\nA palavra era {jogada.Palavra}\n\n");
                }

                if (new string(letrasOcultas) == jogada.Palavra)
                {
                    Console.WriteLine($"Parabéns, você acertou a palavra {jogada.Palavra}!\n\n");
                    break;
                }
            }

        }
    }
}

