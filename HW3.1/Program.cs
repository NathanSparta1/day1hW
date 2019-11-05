using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            Console.WriteLine("Select  Game...");
            GameSelector GS = new GameSelector();
            Console.ReadKey();
            while (k < 10)
            {
                GS.GameSelector1();

            }


        }
    }

    public class GameSelector
    {
        public string UserInput()
        {
            return Console.ReadLine();
        }

        public void GameSelector1()
        {
            
             String Input = (string)UserInput();


            //try
                switch (Input)
                {
                    case "1":
                    Console.WriteLine("You have selected Cube attack");
                        break;
                    case "2":
                    Console.WriteLine("You have selected Battle Ship");
                        break;
                    case "3":
                    Console.WriteLine("You have selected Save the Goat");
                        break;
                default:
                    Console.WriteLine("This is not an option");
                    break;
                }
               
            //catch anything but a number
        }  
       
                

    }

    public class ExceptionWord : Exception
    {

    }
}
