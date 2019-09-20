using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int sünniaasta;
            {
                Console.WriteLine("Sisesta palun oma sünniaasta.");
                sünniaasta = Int32.Parse(Console.ReadLine());
            }

            if (sünniaasta % 4 == 0)
            {
                Console.WriteLine($"{sünniaasta} on liigaasta.");

            }
            
            else
            { 
                Console.WriteLine($"{sünniaasta} ei ole liigaasta.");
             }



            Console.ReadLine();
            */












            //Ternary Operator

            /*
               string answer = (sünniaasta % == 0) ? "Liigaasta." : "Ei ole liigaasta.";


            Console.WriteLine(answer);
                Console.ReadLine();
                */


            Console.WriteLine("Choose your poison:Whiskey or Wine?");
            string userChoice = Console.ReadLine();


            string choice = userChoice == "Whiskey" ? "Here is your whiskey" : "Here is your wine.";
            Console.WriteLine(choice);
            Console.ReadLine();













        }
















    }



















}







 







