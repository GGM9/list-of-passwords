using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace list_of_random_passwords
{
    class Program
    {

        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
            string userInput = "";
            string lengthString = "";
            int lengthInt = 0;
            string amountString = "";
            int amountInt = 0;

            Console.WriteLine("Input password length");
            lengthString = Console.ReadLine();
            lengthInt = Convert.ToInt32(lengthString);
            Console.Clear();

            Console.WriteLine("Input amount of passwords");
            amountString = Console.ReadLine();
            amountInt = Convert.ToInt32(amountString);
            Console.Clear();

            while (userInput != "stop")
            {
                for (int i = 0; i < amountInt; i++)
                {
                    string password = CreatePassword(lengthInt);
                    Console.WriteLine(password);
                    Thread.Sleep(20);
                }

                userInput = Console.ReadLine();
            }
        }
    }
}
