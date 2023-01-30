using System;
namespace HubDeJogos.Jogos
{
    public class FuncionalidadesBatalhaNaval
    {
        string[,] tabuleiro = new string[10, 10];
        public int contagemAcertos = 0;
        public int contagemErros = 0;
        int horizontal = 0;
        int vertical = 0;

        public int obterContagensAcertos()
        {
            return contagemAcertos;
        }
        public int obterContagensErros()
        {
            return contagemErros;
        }
        public void coordenadas()
        {
            Console.WriteLine("Escolha 1 número na linha horizontal e aperte enter.");
            string linha = Console.ReadLine();
            int valor;
            if (int.TryParse(linha, out valor))
            {
                horizontal = valor;
            }
            else
            {
                Console.WriteLine("Não é um número inteiro!");
            }

            Console.WriteLine("Escolha 1 número na linha vertical e aperte enter.");
            linha = Console.ReadLine();
            if (int.TryParse(linha, out valor))
            {
                vertical = valor;
            }
            else
            {
                Console.WriteLine("Não é um número inteiro!");
            }

            try
            {
                if (tabuleiro[horizontal, vertical] != null)
                {
                    tabuleiro[horizontal, vertical] = "   <->";
                    Console.Clear();
                    Console.WriteLine("Acertou! Você atingiu o navio do seu oponente.\r\n");
                    contagemAcertos += 1;
                }
                else
                {
                    tabuleiro[horizontal, vertical] = "    x";
                    Console.Clear();
                    Console.WriteLine("Errou! Você não atingiu nenhum navio.\r\n");
                    contagemErros += 1;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Atenção! Você deve inserir um número de 0 a 9.");
            }
        }
        public string[,] ObterTabuleiro()
        {
            return tabuleiro;
        }
        public void DefinirNaviosTab(int h, int v)
        {
            tabuleiro[h, v] = "   ";
        }
        public void Aleatorizar()
        {
            Random r = new Random(2);

            DefinirNaviosTab(1, 2);
            DefinirNaviosTab(2, 2);
            DefinirNaviosTab(4, 3);
            DefinirNaviosTab(4, 4);
            DefinirNaviosTab(4, 5);
            DefinirNaviosTab(5, 0);
            DefinirNaviosTab(6, 0);
            DefinirNaviosTab(7, 0);
            DefinirNaviosTab(0, 8);
            DefinirNaviosTab(1, 8);
            DefinirNaviosTab(2, 8);
            DefinirNaviosTab(3, 8);
            DefinirNaviosTab(7, 4);
            DefinirNaviosTab(7, 5);
            DefinirNaviosTab(7, 6);
            DefinirNaviosTab(7, 7);
            DefinirNaviosTab(7, 8);
        }
    }
}
