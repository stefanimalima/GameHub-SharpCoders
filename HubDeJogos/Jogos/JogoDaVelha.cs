using HubDeJogos.Jogadores;
using System;

namespace HubDeJogos.Jogos
{
    public class JogoDaVelha
    {
        public void JogarJogoDaVelha()
        {

            Console.WriteLine("Digite o nome ou apelido do Jogador n° 1:");
            Jogador jogador1 = new Jogador() { Nome = JogadorHelper.CriarJogador() };

            Console.WriteLine("Digite o nome ou apelido do Jogador n° 2:");
            Jogador jogador2 = new Jogador() { Nome = JogadorHelper.CriarJogador(jogador1.Nome) };

            Console.Clear();
            Console.WriteLine($"{jogador1.Nome}: você será X!");
            Console.WriteLine($"{jogador2.Nome}: você será O!");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("............................... JOGO DA VELHA .......................................\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Instruções:");
            Console.ResetColor();
            Console.WriteLine("Para começar, escolha um número no tabuleiro [Esse número representa a sua posição].\n");

            // Variáveis e arrays
            int jogada;
            String[,] tabuleiro = new String[3, 3];
            bool ganhou = false;

            // Casas no tabuleiro
            tabuleiro[0, 0] = "1";
            tabuleiro[0, 1] = "2";
            tabuleiro[0, 2] = "3";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "7";
            tabuleiro[2, 1] = "8";
            tabuleiro[2, 2] = "9";

            do
            {
                // 1° estrutura do tabuleiro 
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" -------------");

                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[0, t]);
                }
                Console.Write(" | \n");

                // 2° estrutura do tabuleiro 
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[1, t]);
                }
                Console.Write(" | \n");

                // 3° estrutura do tabuleiro 
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[2, t]);
                }
                Console.Write(" | \n");

                Console.WriteLine(" -------------");
                Console.ResetColor();


                // AQUI COMEÇA O 1° JOGADOR ;) 

                try
                {

                    Console.Write($"Sua vez, {jogador1.Nome}: ");
                    jogada = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Jogadas(jogada, tabuleiro, "X");
                    Console.Clear();

                    // 1° estrutura do tabuleiro - 2
                    Console.WriteLine(" -------------");

                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[0, t]);
                    }
                    Console.Write(" | \n");

                    // 2° estrutura do tabuleiro - 2 
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[1, t]);
                    }
                    Console.Write(" | \n");

                    // 3° estrutura do tabuleiro - 2
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[2, t]);
                    }
                    Console.Write(" | \n");

                    Console.WriteLine(" -------------");
                    Console.ResetColor();

                    ganhou = WinCases(tabuleiro, "X", "O");

                    if (ganhou)
                    {
                        Console.WriteLine($"{jogador1.Nome} ganhou 100 pontos!");
                        Console.WriteLine($"{jogador2.Nome} não ganhou nada :(");
                        jogador1.Pontuacao += 100;
                        break;
                    }

                    // AQUI COMEÇA O 2° JOGADOR -------------------------- ;)
                    Console.Write($"Sua vez, {jogador2.Nome}: ");
                    jogada = int.Parse(Console.ReadLine());
                    Jogadas(jogada, tabuleiro, "O");
                    Console.Clear();

                    ganhou = WinCases(tabuleiro, "O", "X");

                    if (ganhou)
                    {
                        Console.WriteLine($"{jogador2.Nome} ganhou 100 pontos!");
                        Console.WriteLine($"{jogador1.Nome} não ganhou nada :(");
                        jogador2.Pontuacao += 100;
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Atenção! Apenas os números que constam no tabuleiro.");
                }

            } while (!ganhou);

            Console.WriteLine("Muito obrigada por jogar! Pressione 1 para jogar novamente, 2 para voltar ao menu inicial");
            string decisao = Console.ReadLine();

            if (decisao.Equals("1"))
                JogarJogoDaVelha();
        }

        private bool WinCases(string[,] tabuleiro, string v, string y)
        {
            // Caso o "O" ganhe na horizontal 
            if ((tabuleiro[0, 0] == v) && (tabuleiro[0, 1] == v) && (tabuleiro[0, 2] == v))
                return true;
            else if ((tabuleiro[1, 0] == v) && (tabuleiro[1, 1] == v) && (tabuleiro[1, 2] == v))
                return true;
            else if ((tabuleiro[2, 0] == v) && (tabuleiro[2, 1] == v) && (tabuleiro[2, 2] == v))
                return true;

            // Caso o "O" ganhe na vertical 
            if ((tabuleiro[0, 0] == v) && (tabuleiro[1, 0] == v) && (tabuleiro[2, 0] == v))
                return true;
            else if ((tabuleiro[0, 1] == v) && (tabuleiro[1, 1] == v) && (tabuleiro[2, 1] == v))
                return true;
            else if ((tabuleiro[0, 2] == v) && (tabuleiro[1, 2] == v) && (tabuleiro[2, 2] == v))
                return true;

            // Caso o "O" ganhe na diagonal 
            if ((tabuleiro[0, 0] == v) && (tabuleiro[1, 1] == v) && (tabuleiro[2, 2] == v))
                return true;
            else if ((tabuleiro[0, 2] == v) && (tabuleiro[1, 1] == v) && (tabuleiro[2, 0] == v))
                return true;

            if ((tabuleiro[0, 0] == y | tabuleiro[0, 0] == v) && (tabuleiro[0, 1] == y | tabuleiro[0, 1] == v) && (tabuleiro[0, 2] == y | tabuleiro[0, 2] == v) &&
                        (tabuleiro[1, 0] == y | tabuleiro[1, 0] == v) && (tabuleiro[1, 1] == y | tabuleiro[1, 1] == v) && (tabuleiro[1, 2] == y | tabuleiro[1, 2] == v) &&
                        (tabuleiro[2, 0] == y | tabuleiro[2, 0] == v) && (tabuleiro[2, 1] == y | tabuleiro[2, 1] == v) && (tabuleiro[2, 2] == y | tabuleiro[2, 2] == v))
                return false;

            return false;
        }

        private static void Jogadas(int jogada1, string[,] tabuleiro, string valor)
        {
            // Parte superior do tabuleiro 
            if (jogada1 == 1)
                tabuleiro[0, 0] = valor;
            else if (jogada1 == 2)
                tabuleiro[0, 1] = valor;
            else if (jogada1 == 3)
                tabuleiro[0, 2] = valor;

            // Parte central do tabuleiro 
            else if (jogada1 == 4)
                tabuleiro[1, 0] = valor;
            else if (jogada1 == 5)
                tabuleiro[1, 1] = valor;
            else if (jogada1 == 6)
                tabuleiro[1, 2] = valor;

            // Parte inferior do tabuleiro 
            else if (jogada1 == 7)
                tabuleiro[2, 0] = valor;
            else if (jogada1 == 8)
                tabuleiro[2, 1] = valor;
            else if (jogada1 == 9)
                tabuleiro[2, 2] = valor;
        }
    }
}
