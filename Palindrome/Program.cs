using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine("Result = " + solution(word));
            Console.ReadKey();
        }

        public static int solution(string s)
        {
            char[] letters = s.ToArray();
            int result = 0;

            

            if (result != 1)
            {
                for (int j = 0; j < letters.Count(); j++)
                {
                    if (compareLetter(letters))
                    { result = 1; }
                    else {
                        int lastPosicion = letters.Count() - 1;
                        int fisrtPosition = lastPosicion - j;
                        int lastPosicionMudada = lastPosicion - (j + 1);
                        if (fisrtPosition > 1)
                        {
                            
                            char aux;
                            aux = letters[fisrtPosition];
                            letters[fisrtPosition] = letters[lastPosicionMudada];
                            letters[lastPosicionMudada] = aux;

                            if (compareLetter(letters))
                            {
                                result = 1;
                                break;
                            }

                            if (lastPosicionMudada > 0)
                            {
                                letters = mudarPosicao(letters, lastPosicionMudada);
                            }
                        }

                    }
                    if (result == 1)
                    { return result;  }
                }
            }


            return result;

        }

        private static bool compareLetter(char[] letters)
        {
            bool isEqual = true;

            for (int i = 0; i < letters.Count(); i++)
            {
                if (letters[0 + i] != letters[(letters.Count() - 1) - i])
                {
                    isEqual = false;
                    break;
                }
            }

            return isEqual;
        }

        private static char [] mudarPosicao(char [] vetor, int posicao)
        {
            char aux = vetor[posicao];
            vetor[posicao] = vetor[posicao - 1];
            vetor[posicao - 1] = aux;

            if (compareLetter(vetor) || posicao == 1)
            { return vetor; }
            else
            { return mudarPosicao(vetor, posicao - 1); }
                
            

                


        }
    }
}
