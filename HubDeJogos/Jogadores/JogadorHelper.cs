using System;

namespace HubDeJogos.Jogadores
{
    public class JogadorHelper
    {
        public static string CriarJogador(string jogador1 = null)
        {
            string jogador = Console.ReadLine();

            do
            {
                if (jogador.Equals(jogador1, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Esse nome já está cadastrado no banco de dados, tente outro!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dica: Pode utilizar números e símbolos.");
                    Console.ResetColor();
                    jogador = Console.ReadLine();
                }
                else
                    break;

            } while (jogador.Equals(jogador1, StringComparison.InvariantCultureIgnoreCase));

            return jogador;
        }
    }
}
