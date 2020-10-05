using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MethodThatReturnsValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse;
            userResponse = DisplayGetFavoriteGame();
            DisplayFavoriteGame(userResponse);
        }

        private static string DisplayGetFavoriteGame()
        {
            string a;
            Console.WriteLine("Hello please enter your favorite game.");
            a = Console.ReadLine();
            Console.Clear();
            return a;
        }

        private static void DisplayFavoriteGame(string response)
        {
            Console.WriteLine($"So your favorite game is {response}");
            Thread.Sleep(5000);

        }
    }
}
