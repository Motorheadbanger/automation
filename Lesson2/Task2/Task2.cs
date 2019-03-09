using System;

namespace Task2
{
    class Task2
    {
        const string existingLogin = "Login", existingPassword = "Password";
        static string userLogin = "", userPassword = "";

        static void Main(string[] args)
        {
            int attemptsLeft = 3;
            while (attemptsLeft > 0)
            {
                Console.Write("Login: ");
                userLogin = Console.ReadLine();
                Console.Write("Password: ");
                ReadPassword();

                if (existingLogin.Equals(userLogin) && existingPassword.Equals(userPassword))
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else
                {
                    attemptsLeft--;
                    if (attemptsLeft > 0)
                    {
                        userPassword = "";
                        Console.WriteLine($"Login unsuccessful. You have {attemptsLeft} attempts left. Please try again...");
                    }
                    else Console.WriteLine($"Login unsuccessful. You have {attemptsLeft} attempts left. Exiting...");
                }
            }
            Console.ReadKey();
        }

        private static void ReadPassword()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            while (key.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                userPassword += key.KeyChar;
                key = Console.ReadKey(true);
            }
            Console.WriteLine();
        }
    }
}
