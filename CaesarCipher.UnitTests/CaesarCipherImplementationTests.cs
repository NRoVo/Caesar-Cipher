using CaesarCipher.Core;
using CaesarCipher.Core.Alphabet;
using FluentAssertions;
using Xunit;

namespace CaesarCipher.UnitTests
{
    public class CaesarCipherImplementationTests
    {
        private readonly CaesarCipherImplementation _cipher = new CaesarCipherImplementation(new EnglishAlphabet(), new RussianAlphabet());

        [Theory]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", 1, "TQIJOY PG CMBDL RVBSUA, KVEHF NZ WPX")]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", -1, "ROGHMW NE AKZBJ PTZQSY, ITCFD LX UNV")]
        [InlineData("sphinx of black quartz, judge my vow", 1, "tqijoy pg cmbdl rvbsua, kvehf nz wpx")]
        [InlineData("sphinx of black quartz, judge my vow", -1, "roghmw ne akzbj ptzqsy, itcfd lx unv")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", 1, "ЕСФД НПК ЮМЭХ! АЩЛЁ В ТГЖИ РУЙЧ ЯЗОЬЦ ШБЪ!")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", -1, "ГПТВ ЛНИ ЬКЫУ! ЮЧЙД А РБЕЖ ОСЗХ ЭЁМЪФ ЦЯШ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", 1, "есфд нпк юмэх! ащлё в тгжи руйч язоьц шбъ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", -1, "гптв лни ькыу! ючйд а рбеж осзх эёмъф цяш!")]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", 0, "SPHINX OF BLACK QUARTZ, JUDGE MY VOW")]
        [InlineData("sphinx of black quartz, judge my vow", 0, "sphinx of black quartz, judge my vow")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", 0, "ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", 0, "друг мой эльф! яшке б свёз птиц южных чащ!")]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", 26, "SPHINX OF BLACK QUARTZ, JUDGE MY VOW")]
        [InlineData("sphinx of black quartz, judge my vow", 26, "sphinx of black quartz, judge my vow")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", 33, "ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", 33, "друг мой эльф! яшке б свёз птиц южных чащ!")]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", 27, "TQIJOY PG CMBDL RVBSUA, KVEHF NZ WPX")]
        [InlineData("SPHINX OF BLACK QUARTZ, JUDGE MY VOW", -27, "ROGHMW NE AKZBJ PTZQSY, ITCFD LX UNV")]
        [InlineData("sphinx of black quartz, judge my vow", 27, "tqijoy pg cmbdl rvbsua, kvehf nz wpx")]
        [InlineData("sphinx of black quartz, judge my vow", -27, "roghmw ne akzbj ptzqsy, itcfd lx unv")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", 34, "ЕСФД НПК ЮМЭХ! АЩЛЁ В ТГЖИ РУЙЧ ЯЗОЬЦ ШБЪ!")]
        [InlineData("ДРУГ МОЙ ЭЛЬФ! ЯШКЕ Б СВЁЗ ПТИЦ ЮЖНЫХ ЧАЩ!", -34, "ГПТВ ЛНИ ЬКЫУ! ЮЧЙД А РБЕЖ ОСЗХ ЭЁМЪФ ЦЯШ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", 34, "есфд нпк юмэх! ащлё в тгжи руйч язоьц шбъ!")]
        [InlineData("друг мой эльф! яшке б свёз птиц южных чащ!", -34, "гптв лни ькыу! ючйд а рбеж осзх эёмъф цяш!")]
        public void CipherTests(string input, int steps, string output)
        {
            _cipher.Encrypt(input, steps).Should().Be(output);
            _cipher.Decrypt(output, steps).Should().Be(input);
        }
    }
}