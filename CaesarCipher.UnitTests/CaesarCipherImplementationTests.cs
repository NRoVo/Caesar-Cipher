using CaesarCipher.Core;
using FluentAssertions;
using Xunit;

namespace CaesarCipher.UnitTests
{
    public class CaesarCipherImplementationTests
    {
        [Fact]
        public void EncryptsCapsedStringForward()
        {
            CaesarCipherImplementation.Encrypt("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", 1).Should().Be("TQIJOY PG CMBDL RVBSUA, KVEHF NZ WPX");
        }
        [Fact]
        public void DecryptsCapsedStringForward()
        {
            CaesarCipherImplementation.Decrypt("TQIJOY PG CMBDL RVBSUA, KVEHF NZ WPX", 1).Should().Be("SPHINX OF BLACK QUARTZ, JUDGE MY VOW");
        }
    }
}