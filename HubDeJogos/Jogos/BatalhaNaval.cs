using HubDeJogos.Jogadores;
using System;

namespace HubDeJogos.Jogos
{
    public class BatalhaNaval
    {
        public void JogarBatalhaNaval()
        {
            Console.Title = "Batalha Naval";
            Console.WriteLine("Digite o nome ou apelido do Jogador n° 1:");
            Jogador jogador1 = new Jogador() { Nome = JogadorHelper.CriarJogador() };

            Console.WriteLine("Digite o nome ou apelido do Jogador n° 2:");
            Jogador jogador2 = new Jogador() { Nome = JogadorHelper.CriarJogador(jogador1.Nome) };

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(".............. BATALHA NAVAL ..............\n");
            Console.ResetColor();

            Console.WriteLine();
            FuncionalidadesBatalhaNaval p = new FuncionalidadesBatalhaNaval();
            p.Aleatorizar();
            while (p.obterContagensAcertos() < 17)
            {
                EstruturaTabuleiro(p.ObterTabuleiro());
                Console.ResetColor();
                Console.WriteLine($"É a sua vez, {jogador1.Nome}.");
                p.coordenadas();
                EstruturaTabuleiro(p.ObterTabuleiro());
                Console.ResetColor();
                Console.WriteLine($"É a sua vez, {jogador2.Nome}.");
                p.coordenadas();
            }
            Console.WriteLine(" Parabéns! Você venceu e ganhou 100 pontos.\r\n");
            Console.WriteLine("Você errou: " + p.obterContagensErros() + " vezes\r\n");
            Console.WriteLine("Obrigada por jogar! Pressione enter para sair.");
            Console.ReadLine();
        }

        public void EstruturaTabuleiro(string[,] Tabuleiro)
        {
            int Row;
            int Column;
            Console.ResetColor();
            Console.WriteLine("    0   1   2   3   4   5   6   7   8   9\n");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.ResetColor();
                Console.Write((Row).ToString());
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" |---|---|---|---|---|---|---|---|---|---|");

                for (Column = 0; Column <= 9; Column++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(Tabuleiro[Column, Row] + "   ");
                }
                Console.WriteLine();
            }

        }
    }
}
