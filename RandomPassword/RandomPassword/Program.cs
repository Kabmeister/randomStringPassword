using System;

namespace RandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PasswordLength = 10;
            var random = new Random();
            var buffer = new char[PasswordLength];

            for (int i = 0; i < PasswordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
