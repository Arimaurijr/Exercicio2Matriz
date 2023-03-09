internal class Program
{
    private static void Main(string[] args)
    {
        const int ORDEM = 5;
        int[,] matriz = new int[ORDEM, ORDEM];

        int SomaLinha(int linha, int ordemMatriz)
        {
            int soma = 0;
            for(int coluna = 0; coluna < ordemMatriz; coluna++)
            {
                soma += matriz[linha, coluna];
            }

            return soma;
        }

        int SomaColuna(int coluna,int ordemMatriz)
        {
            int soma = 0;

            for(int linha = 0; linha < ordemMatriz; linha++) 
            {
                soma += matriz[linha, coluna];
            }

            return soma;
        }

        int SomaDiagonalPrincipal(int ordemMatriz)
        {
            int soma = 0;

            for(int i = 0; i < ordemMatriz; i++)
            {
                soma += matriz[i, i];
            }

            return soma;
        }
        int SomaDiagonalSecundario(int ordemMatriz)
        {
            int soma = 0;

            for(int linha = 0, coluna = ordemMatriz -1;linha < ordemMatriz; linha++, coluna--)
            {
                soma += matriz[linha, coluna];
            }

            return soma;
        }

        void EntradaDados(int ordemMatriz)
        {
            for(int linha = 0; linha < ordemMatriz; linha++)
            {
                Console.WriteLine("DIGITE OS ELEMENTOS DA " + (linha + 1) + " º LINHA");
                Console.WriteLine();
                for(int coluna = 0; coluna < ordemMatriz; coluna++)
                {
                    Console.WriteLine("DIGITE O ELEMENTO DA " + (coluna + 1) + " º COLUNA");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
        }

        void ExibirSomaLinha(int linha, int ordemMatriz)
        {
            Console.WriteLine("A SOMA DA " + (linha + 1) + " º É " + SomaLinha(linha, ordemMatriz));
        }

        void ExibirSomaColuna(int coluna, int ordemMatriz)
        {
            Console.WriteLine("A SOMA DA " + (coluna + 1) + " º É " + SomaColuna(coluna, ordemMatriz));
        }

        EntradaDados(ORDEM);

        Console.WriteLine("A SOMA DAS LINHAS");
        for(int i = 0; i < ORDEM; i++) 
        {
            ExibirSomaLinha(i, ORDEM);
        }

        Console.WriteLine();
        Console.WriteLine("A SOMA DAS COLUNAS");
        for(int i = 0; i < ORDEM; i++)
        {
            ExibirSomaColuna(i, ORDEM);
        }

        Console.WriteLine();
        Console.WriteLine("A SOMA DA DIAGONAL PRINCIPAL: " + SomaDiagonalSecundario(ORDEM));

        Console.WriteLine();
        Console.WriteLine("A SOMA DA DIAGONAL SECUNDÁRIA: " + SomaDiagonalSecundario(ORDEM));
    }
}