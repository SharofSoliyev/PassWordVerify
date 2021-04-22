using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVerifyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            string password = "2woRDsss";
            int score = 0;
            if ((score) >= (minLength))
            {
                score++;
            }

            if (Contains(password, uppercase))
            {
                score++;
            }

            if (Contains(password, lowercase))
            {
                score++;
            }

            if (Contains(password, digits))
            {
                score++;
            }

            if (Contains(password, specialChars))
            {
                score++;
            }

            Console.WriteLine(password);
            Console.WriteLine(score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("This is an extremely strong password");
                    break;
                case 3:
                    Console.WriteLine("This is a strong password");
                    break;
                case 2:
                    Console.WriteLine("This is an average password");
                    break;
                case 1:
                    Console.WriteLine("This is a weak password");
                    break;
                default:
                    Console.WriteLine("This password doesn't meet the standards");
                    break;
            }
            Console.ReadLine();
        }
        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
