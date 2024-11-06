//Utilizando Matrizes:
//Problema "cada_linha"
//Ler um inteiro N e uma matriz quadrada de ordem N (máximo = 10). Mostrar qual o maior elemento
//de cada linha. Suponha não haver empates. 

namespace MaiorNumeroDeCadaLinhaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maiorElemento = 0;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");
            for (int i = 0; i < n; i++)
            {
                maiorElemento = mat[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (mat[i, j] > maiorElemento)
                    { 
                        maiorElemento = mat[i, j];
                    }
                }
                Console.WriteLine(maiorElemento);
            }
        }
    }
}
