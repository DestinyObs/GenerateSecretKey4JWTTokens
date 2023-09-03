using System;

namespace GenerateSecretKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can call the GenerateSecretKey method here
            string secretKey = GenerateSecretKey(50); // Adjust the length as needed
            Console.WriteLine($"Generated Secret Key: {secretKey}");
        }

        static string GenerateSecretKey(int length)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(chars);
        }
    }
}
