using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            //to find the length of a string foreach on nagu otsing, otsime ühte sõna mingi hulga seest.
            /*Console.WriteLine("Please enter string: ");
            string userString = Console.ReadLine();

            int counter = 0;

            foreach (char letter in userString)
            {
                counter++;
            }

            Console.WriteLine($"Your name is {counter} letters long.");
            Console.ReadLine();*/

            /// Teine võimalus foreach kasutada:  
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine().ToLower();
            bool letterFound = false;

            foreach (char letter in userName)
            {
                if (letter == 'a')
                {
                    letterFound = true;
                    break;
                }

            }

            string result = letterFound ? "a täht on olemas" : "a täht ei ole olemas"; ///seda saab kasutada, kui on kaks valikut.
            Console.WriteLine(result);

            /*if (letterFound) 
            {
                Console.WriteLine("'a' täht on olemas sõnas");
            }
            else
            {
                Console.WriteLine("'a' täht ei ole sõnas olemas");
            }*/

            Console.ReadLine();


            //To separate the individual characters from a string
            /*Console.WriteLine("Please enter word: ");
            string userWord = Console.ReadLine();

            foreach (char letter in userWord)
            {
                Console.Write($"{letter} ");
            }



            Console.ReadLine();*/






        }
    }
}
