using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            const string existingLogin = "Login";
            const string existingPassword = "Password";
            string userLogin = "";
            string userPassword = "";

            for (int attemptsLeft = 2; attemptsLeft >= 0; attemptsLeft--)
            {
                Console.Write("Login: ");
                userLogin = Console.ReadLine();
                Console.Write("Password: ");
                ConsoleKeyInfo key = Console.ReadKey(true);

                while (key.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    userPassword += key.KeyChar;
                    key = Console.ReadKey(true);
                }
                Console.WriteLine();

                if (existingLogin.Equals(userLogin) && existingPassword.Equals(userPassword))
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else
                {
                    if (attemptsLeft > 0)
                    {
                        userLogin = "";
                        userPassword = "";
                        Console.WriteLine($"Login unsuccessful. You have {attemptsLeft} attempts left. Please try again...");
                    }
                    else Console.WriteLine($"Login unsuccessful. You have {attemptsLeft} attempts left. Exiting...");
                }
            }
            Console.ReadKey();
        }
    }
}
