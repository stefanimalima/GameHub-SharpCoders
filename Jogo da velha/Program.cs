using System;

namespace jogoDaVelha01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instruções iniciais
            Console.WriteLine("JOGO DA VELHA - STEFANI LIMA\n" +
               "Instruções: Para começar, escolha um número no tabuleiro [Esse número representa a sua posição]. \n\n" +
                "1° Jogador - 'você será X' \n" +
                "2° Jogador - 'você será O' \n");


            // Variáveis e arrays
            int jogada1, jogada2;
            String[,] tabuleiro = new String[3, 3];
            bool ganhou = true;

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

                // AQUI COMEÇA O 1° JOGADOR ;) 

                try
                {
                    Console.Write("Sua vez, 1° Jogador: ");
                    jogada1 = int.Parse(Console.ReadLine());


                    // Parte superior do tabuleiro 
                    if (jogada1 == 1)
                    {
                        tabuleiro[0, 0] = "X";
                    }
                    else if (jogada1 == 2)
                    {
                        tabuleiro[0, 1] = "X";
                    }
                    else if (jogada1 == 3)
                    {
                        tabuleiro[0, 2] = "X";
                    }

                    // Parte central do tabuleiro 
                    else if (jogada1 == 4)
                    {
                        tabuleiro[1, 0] = "X";
                    }
                    else if (jogada1 == 5)
                    {
                        tabuleiro[1, 1] = "X";
                    }
                    else if (jogada1 == 6)
                    {
                        tabuleiro[1, 2] = "X";
                    }

                    // Parte inferior do tabuleiro 
                    else if (jogada1 == 7)
                    {
                        tabuleiro[2, 0] = "X";
                    }
                    else if (jogada1 == 8)
                    {
                        tabuleiro[2, 1] = "X";
                    }
                    else if (jogada1 == 9)
                    {
                        tabuleiro[2, 2] = "X";
                    }

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

                    // Caso tenha empate
                    if ((tabuleiro[0, 0] == "X" | tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "X" | tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "X" | tabuleiro[0, 2] == "O") &&
                        (tabuleiro[1, 0] == "X" | tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "X" | tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "X" | tabuleiro[1, 2] == "O") &&
                        (tabuleiro[2, 0] == "X" | tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "X" | tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "X" | tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Vocês empataram!");
                        break;
                    }


                    // Caso o "X" ganhe na horizontal 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[0, 1] == "X") && (tabuleiro[0, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[1, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "X") && (tabuleiro[2, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }

                    // Caso "X" ganhe na vertical 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 0] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 1] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 2] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }

                    // Caso "X" ganhe na diagonal 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }


                    // AQUI COMEÇA O 2° JOGADOR -------------------------- ;)

                    Console.Write("Sua vez, 2° Jogador: ");
                    jogada2 = int.Parse(Console.ReadLine());

                    // Parte superior do tabuleiro 
                    if (jogada2 == 1)
                    {
                        tabuleiro[0, 0] = "O";
                    }
                    else if (jogada2 == 2)
                    {
                        tabuleiro[0, 1] = "O";
                    }
                    else if (jogada2 == 3)
                    {
                        tabuleiro[0, 2] = "O";
                    }

                    // Parte central do tabuleiro
                    else if (jogada2 == 4)
                    {
                        tabuleiro[1, 0] = "O";
                    }
                    else if (jogada2 == 5)
                    {
                        tabuleiro[1, 1] = "O";
                    }
                    else if (jogada2 == 6)
                    {
                        tabuleiro[1, 2] = "O";
                    }

                    // Parte inferior do tabuleiro
                    else if (jogada2 == 7)
                    {
                        tabuleiro[2, 0] = "O";
                    }
                    else if (jogada2 == 8)
                    {
                        tabuleiro[2, 1] = "O";
                    }
                    else if (jogada2 == 9)
                    {
                        tabuleiro[2, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Atenção ao jogo...");
                    }

                    // Caso o "O" ganhe na horizontal 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }

                    // Caso o "O" ganhe na vertical 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 0] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 1] == "OX"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 2] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }

                    // Caso o "O" ganhe na diagonal 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    // Caso tenha empate - 2° possibilidade 
                    if ((tabuleiro[0, 0] == "X" | tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "X" | tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "X" | tabuleiro[0, 2] == "O") &&
                        (tabuleiro[1, 0] == "X" | tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "X" | tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "X" | tabuleiro[1, 2] == "O") &&
                        (tabuleiro[2, 0] == "X" | tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "X" | tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "X" | tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Vocês empataram!");
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Atenção! Apenas os números que constam no tabuleiro.");
                }

            } while (ganhou);

            Console.WriteLine("\n\n Muito obrigada por jogar! Pressione qualquer tecla para sair :)");
            Console.ReadKey();



        }
    }
}