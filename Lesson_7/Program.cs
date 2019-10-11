using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Korrutustabel:
            /*Console.WriteLine("Insert a number: ");
            int userNumber = int.Parse(Console.ReadLine());
           
            for (int i= 1; i <= 10; i++)
            {
                
                Console.WriteLine($"{userNumber} x {i} = {userNumber*i}");
            }

            Console.ReadLine();*/


            /*Console.WriteLine("Insert word: ");
            string userWord = Console.ReadLine().ToLower();
            
            int aTotal = 0;
           

            for (int i = 0; i< userWord.Length; i++)
            {
                if (userWord[i]== 'a')
                {
                    aTotal++;
                }
            }

            Console.WriteLine($"There are {aTotal} \"A\" letters in your name.");
            Console.ReadLine();*/


            //To separate the individual characters from a string

            /*Console.Write("Please enter word: ");
            string userWord = Console.ReadLine();



           for (int i = 0; i< userWord.Length; i++)
            {
                if (i == userWord.Length-1)
                {
                    Console.Write($"{userWord[i]}#");
                    break;
                }
                else
                {
                    Console.Write($"{userWord[i]}*");
                }
                     
               

            }
            Console.ReadLine();*/

            /* int i = 1;

             while (i <= 10)
             {
                 Console.WriteLine(i);
                 i++;
             }
             Console.ReadLine();*/

            string hello = "hello";
            int i = 0;

            while (i< hello.Length)
            {
                if (i== hello.Length - 1)
                {
                    Console.Write($"{hello[i]}");
                    break;
                }
            
                Console.Write($"{hello[i]}*");
                i++;
            }
            Console.ReadLine();


        }
    }
}
