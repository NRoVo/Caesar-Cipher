using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFromJuliusCaesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Caesar Cypher Manager 1.0! Please specify an action you would like to apply" + 
                          ": \"Encryption\", \"Decryption\", \"Brute Force Decryption\".");
            var userOption = Console.ReadLine();

            if (userOption == "Encryption")
            {
                Console.WriteLine("Please enter the message you would like to encrypt: ");
                var userMessage = Console.ReadLine();
                    
                Console.WriteLine("Please enter the key from 1 to 26: ");
                var userKey = Convert.ToInt32(Console.ReadLine());

                if (userKey >= 1 && userKey <= 26)
                {
                    Console.WriteLine(Encrypt(userMessage, userKey));
                }
                else
                {
                    Console.WriteLine("Invalid key! During the next program launch, please specify the correct key!");
                }
            }
            else if (userOption == "Decryption")
            {
                Console.WriteLine("Please enter the message you would like to decrypt: ");
                var userMessage = Console.ReadLine();
                    
                Console.WriteLine("Please enter the key from 1 to 26: ");
                var userKey = Convert.ToInt32(Console.ReadLine());

                if (userKey >= 1 && userKey <= 26)
                {
                    Console.WriteLine(Decrypt(userMessage, userKey));
                }
                else
                {
                    Console.WriteLine("Invalid key! During the next program launch, please specify the correct key!");
                }
            }
            else if (userOption =="Brute Force Decryption")
            {
                Console.WriteLine("Please enter the message on which you would like to apply Brute Force Decryption: ");
                var userMessage = Console.ReadLine();

                BruteForceDecrypt(userMessage);
            }
            else
            {
                Console.WriteLine("There is no such option! Please specify correct next time!");
            }

            Console.ReadKey();
        }

        public static string Encrypt(string message, int key)
        {
            message = message.ToUpper();
            var encryptedMessage = "";

            for (int index = 0; index < message.Length; index++)
            {
                encryptedMessage += Encrypt(message[index], key);
            }

            return encryptedMessage;
        }

        public static char Encrypt(char letter, int key)
        {
            if (letter < 'A' || letter > 'Z')
            {
                return letter;
            }
            var letterAsNumber = letter - 'A';
            var encryptedLetter = (letterAsNumber + key) % 26;

            return (char) (encryptedLetter + 'A');
        }

        public static string Decrypt(string message, int key)
        {
            message = message.ToUpper();
            var decryptedMessage = "";

            for (int index = 0; index < message.Length; index++)
            {
                decryptedMessage += Decrypt(message[index], key);
            }

            return decryptedMessage;
        }

        public static char Decrypt(char letter, int key)
        {
            if (letter < 'A' || letter > 'Z')
            {
                return letter;
            }

            var letterAsNumber = letter - 'A';
            var decryptedLetter = (letterAsNumber - key + 26) % 26;

            return (char) (decryptedLetter + 'A');
        }

        public static void BruteForceDecrypt(string messageToHack)
        {
            for (int index = 0; index <= 26; index++)
            {
                Console.WriteLine(Decrypt(messageToHack, index));
            }
        }
    }
}
