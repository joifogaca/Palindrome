using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program2
    {
        public static void Main(string[] args)
        {
            string line;
            do
            {
                Console.WriteLine("Enter with a String or Write 'end' for exit ...");
                line = Console.ReadLine();

                if (line != "end")
                {
                    string word = line;

                    Console.WriteLine("Result = " + solution(word));
                }

            } while (line != "end");


            Console.ReadKey();
        }

        public static int solution(string s)
        {
            int result = 1;

            char[] arrayLetters = s.ToArray();
            List<Letra> listaLetras = new List<Letra>();
            listaLetras.Add(new Letra() { letra = arrayLetters[0], qtd = 1 });
            bool estaNaLista = false;

            for (int i = 1; i < arrayLetters.Count(); i++)
            {
                estaNaLista = false;
                foreach (Letra item in listaLetras)
                {
                    if (arrayLetters[i] == item.letra)
                    {
                        item.qtd = item.qtd + 1;
                        estaNaLista = true;
                        break;
                    }
                }

                if (!estaNaLista)
                {
                    Letra letra = new Letra();
                    letra.letra = arrayLetters[i];
                    letra.qtd = 1;
                    listaLetras.Add(letra);
                }
            }

            int qtdLetrasImpar = listaLetras.Where(l => l.qtd % 2 == 1).Count();

            if (qtdLetrasImpar > 1)
            {
                result = 0;
            }
            


            return result;

        }


        
    }
}
