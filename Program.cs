
namespace JogoDaForca
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Digite a palavra para jogar");
            string palavra = Console.ReadLine()!;

            char[] letrasOcultas = new char[palavra.Length];
            int tentativas = 0;

            for (int i = 0; i < letrasOcultas.Length; i++)
            {
                letrasOcultas[i] = '_';
            }

            while (tentativas != 6)
            {
                Console.Clear();

                foreach (var item in letrasOcultas)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\nDigite a letra escolhida");
                char letra = Convert.ToChar(Console.ReadLine()!);

                bool acertou = false;

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        letrasOcultas[i] = letra;
                        acertou = true;
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine($"Fim de jogo, {++tentativas} tentativas efetuadas.\nA palavra era {palavra}\n\n");
                }

                if (new string(letrasOcultas) == palavra)
                {
                    Console.WriteLine($"Parabéns, você acertou a palavra {palavra}!");
                    break;
                }
            }

        }
    }
}

