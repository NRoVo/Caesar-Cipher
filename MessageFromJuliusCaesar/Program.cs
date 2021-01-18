using System.Collections.Generic;
using System.Threading.Tasks;
using CaesarCipher.Core;
using CaesarCipher.Core.Alphabet;
using cOOnsole.ArgumentParsing;
using cOOnsole.Handlers.Base;
using static System.Console;
using static cOOnsole.Shortcuts;

namespace MessageFromJuliusCaesar
{
    internal static class Program
    {
        public class CaesarCipherArgument
        {
            [Argument("--steps", "-s", Description = "The amount of letters to shift.")]
            public int Steps { get; set; }

            [Argument("--text", "-t", Description = "The text to work on.")]
            public string Text { get; set; }

            [Argument("--english", "-e", Description = "Use English alphabet")]
            public bool UseEnglishAlphabet { get; set; }

            [Argument("--russian", "-r", Description = "Use Russian alphabet")]
            public bool UseRussianAlphabet { get; set; }
        }

        internal static Task<int> Main(string[] cliArgs) => Cli(
            PrintUsageIfNotMatched(
                Fork(
                    Token("encrypt",
                        Action(delegate(CaesarCipherArgument arg, IHandlerContext _)
                        {
                            WriteLine(CreateCipher(arg).Encrypt(arg.Text, arg.Steps));
                        })),
                    Token("decrypt",
                        Action(delegate(CaesarCipherArgument arg, IHandlerContext _)
                        {
                            WriteLine(CreateCipher(arg).Decrypt(arg.Text, arg.Steps));
                        }))
                ))).HandleAndGetExitCode(cliArgs);

        private static CaesarCipherImplementation CreateCipher(CaesarCipherArgument arg)
        {
            var alphabets = new List<IAlphabet>();
            if (arg.UseRussianAlphabet)
            {
                alphabets.Add(new RussianAlphabet());
            }

            if (arg.UseEnglishAlphabet)
            {
                alphabets.Add(new EnglishAlphabet());
            }

            return new CaesarCipherImplementation(alphabets.ToArray());
        }
    }
}