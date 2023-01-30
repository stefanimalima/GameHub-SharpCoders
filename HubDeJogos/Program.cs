using HubDeJogos.Jogos;
using System;

namespace HubDeJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("...........................");
                Console.ResetColor();
                Console.WriteLine(". Bem-vindo(a) ao GameHub! .");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("...........................\n");
                Console.ResetColor();
                Console.WriteLine("Selecione o Jogo Desejado:");
                Console.WriteLine("1: Jogo da Velha");
                Console.WriteLine("2: Batalha Naval");

                string jogo = Console.ReadLine();

                if (jogo.Equals("1"))
                {
                    Console.Clear();
                    JogoDaVelha jogoDaVelha = new JogoDaVelha();
                    jogoDaVelha.JogarJogoDaVelha();
                }
                else if (jogo.Equals("2"))
                {
                    Console.Clear();
                    BatalhaNaval batalhaNaval = new BatalhaNaval();
                    batalhaNaval.JogarBatalhaNaval();
                }
                else
                {
                    Console.WriteLine("Essa opção não está cadastrada! Escolha entre o jogo 1 e 2.");
                }
            } while (true);

        }
    }
}
