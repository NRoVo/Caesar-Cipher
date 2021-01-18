﻿using System;
using CaesarCipher.Core;

namespace MessageFromJuliusCaesar
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var cipher = new CaesarCipherImplementation();
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
                    Console.WriteLine(cipher.Encrypt(userMessage, userKey));
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
                    Console.WriteLine(cipher.Decrypt(userMessage, userKey));
                }
                else
                {
                    Console.WriteLine("Invalid key! During the next program launch, please specify the correct key!");
                }
            }
            else
            {
                Console.WriteLine("There is no such option! Please specify correct next time!");
            }

            Console.ReadKey();
        }
    }
}