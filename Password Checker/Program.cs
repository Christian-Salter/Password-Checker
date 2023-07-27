
using System;


namespace Password_Checker
{
    internal class Program : Tools
    {
        public static void Main(string[] args)
        {
            int minLength = 7;
            string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowercase = uppercase.ToLower();
            string digits = "0123456789";
            string specialChars = "!@#$%&*_?";
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength)
            {
                score = score + 1;
            }
            if (Tools.Contains(password, uppercase))
            {
                score = score + 1;
            }
            if (Tools.Contains(password, lowercase))
            {
                score = score + 1;
            }
            if (Tools.Contains(password, digits))
            {
                score = score + 1;
            }
            if (Tools.Contains(password, specialChars))
            {
                score = score + 1;
            }

            Console.WriteLine(score);
        }
    }

    public class Tools()
    {

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }

}