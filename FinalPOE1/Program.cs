using System;
using System.Media;

namespace POE
{
    class Program
    {
        static void Main()
        {
            // Calling the PlaySound method
            PlaySound();
            // Changing the colour to Red for the ASCII art
            Console.ForegroundColor = ConsoleColor.Red;
            // Logo for the bot
            Console.WriteLine("  ____      _           _     _   _            ____                           \r\n / ___|   _| |__   ___ | |_  | |_| |__   ___  / ___|  ___  ___ _   _ _ __ ___ \r\n| |  | | | | '_ \\ / _ \\| __| | __| '_ \\ / _ \\ \\___ \\ / _ \\/ __| | | | '__/ _ \\\r\n| |__| |_| | |_) | (_) | |_  | |_| | | |  __/  ___) |  __/ (__| |_| | | |  __/\r\n \\____\\__, |_.__/ \\___/ \\__|  \\__|_| |_|\\___| |____/ \\___|\\___|\\__,_|_|  \\___|\r\n      |___/  ");
            Console.ResetColor();
            // Calling the welcomeMessageDisplayed method
            welcomeMessageDisplayed();
            // Calling the ResponseSystem method
            ResponseSystem();
        }

        // Method to play the sound file
        static void PlaySound()
        {
            // Path to the sound file
            string filePath = @"C:\Users\yusuf\source\repos\FinalPOE1\Greeting.wav";
            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: Could not locate the sound");
            }
        }
        static void welcomeMessageDisplayed()
        {
            //Displaying a welcome banner
            string welcomeMessage = @"
            |-------------------------------------------------------------|
            |                                                             |
            |       Welcome to your personal Cybersecurity expert!        |
            |-------------------------------------------------------------|                                                                                                                            
        ";
            // Changing the colour to Blue for the Welcome message
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(welcomeMessage);
            // Ressetting the colour so that the stars pop out to show the seperation
            Console.ResetColor();
            Console.WriteLine("*****************************************************************************");
        }
        static void ResponseSystem()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            //Prompts the user to enter their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Yo, {name}! Im here to help you with your Cybersecurity problems!");
            Console.ResetColor();
            Console.WriteLine();
            bool running = true;
            while (running)
            {
                Console.WriteLine("*****************************************************************************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nFeel free to ask me about the following cybersecurity problems:");
                Console.WriteLine("- Password safety");
                Console.WriteLine("- Phishing attacks");
                Console.WriteLine("- Safe browsing");
                Console.WriteLine("Type 'exit' to quit.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("*****************************************************************************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.Write("Enter your question: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Contains("how are you"))
                {
                    Console.WriteLine();
                    Console.WriteLine($"I'm doing great, {name}! How are you doing?");
                }
                else if (userInput.Contains("what's your purpose") || userInput.Contains("what is your purpose"))
                {
                    Console.WriteLine();
                    Console.WriteLine("To strengthen your understanding of topics of CyberSecurity, mainly Password safety, Phishing attacks and safe browsing");
                }
                else if (userInput.Contains("what can i ask you about") || userInput.Contains("what can i ask"))
                {
                    Console.WriteLine();
                    Console.WriteLine("You can ask me about:\n- Password safety\n- Phishing attacks\n- Safe browsing\nFeel free to ask any questions related to these topics!");
                }
                else if (userInput.Contains("password safety"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Password safety is how a user limits access to their accounts.\nUsing different passwords for different accounts and enabling 2 factor authentication is a good practice of password safety.");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Phishing attacks are when people send you emails/sms's with the hopes of you giving them sensitive information");
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Safe browsing includes avoiding suspicious websites, ensuring your browser is up-to-date, and using HTTPS whenever possible. You should also consider using a VPN for added privacy.");
                }
                else if (userInput == "exit")
                {
                    running = false;
                    Console.WriteLine("Goodbye, stay safe online!");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("*****************************************************************************");
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that. could you rephrase? \n type 'exit' to quit!");
                }
            }
        }
    }