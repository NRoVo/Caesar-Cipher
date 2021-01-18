using CaesarCipher.Core.Alphabet;

namespace CaesarCipher.Core
{
    public class CaesarCipherImplementation
    {
        private readonly IAlphabet[] _alphabets;

        public CaesarCipherImplementation(params IAlphabet [] alphabets)
        {
            _alphabets = alphabets;
        }

        public string Encrypt(string message, int steps)
        {
            var result = message.ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                var currentCharacter = message[i];
                for (var j = 0; j < _alphabets.Length; j++)
                {
                    var currentAlphabet = _alphabets[j];
                    if (currentAlphabet.IsApplicable(currentCharacter))
                    {
                        result[i] = currentAlphabet.GetWithOffset(currentCharacter, steps);
                        break;
                    }
                }
            }
            return new string(result);
        }

        public string Decrypt(string message, int steps)
        {
            var result = message.ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                var currentCharacter = message[i];
                for (var j = 0; j < _alphabets.Length; j++)
                {
                    var currentAlphabet = _alphabets[j];
                    if (currentAlphabet.IsApplicable(currentCharacter))
                    {
                        result[i] = currentAlphabet.GetWithOffset(currentCharacter,currentAlphabet.AlphabetLength - steps);
                        break;
                    }
                }
            }
            return new string(result);
        }
    }
}