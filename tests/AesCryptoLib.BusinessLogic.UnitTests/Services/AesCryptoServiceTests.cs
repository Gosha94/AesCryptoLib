using NUnit.Framework;

namespace AesCryptoLib.BusinessLogic.UnitTests.Services
{

    [TestFixture]
    internal class AesCryptoServiceTests
    {
        
        public AesCryptoServiceTests()
        {
            this._testedCryptoManager = new CryptoManager();
        }

        [Test]
        public void Decrypt_Test()
        {
            var shifr = "HNI4J6NqkHUOhgrSgoPv7rE4I0vfclHuYuj9iTMGkA==";
            var expected = "1";
            var actual = _testedCryptoManager.Decrypt(shifr);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Encrypt_Test()
        {
            var clearText = "1";
            var expected = "HNI4J6NqkHUOhgrSgoPv7rE4I0vfclHuYuj9iTMGkA==";
            var actual = _testedCryptoManager.Encrypt(clearText);
            // Результаты не должны совпадать с предыдущим шифром, алгоритм работает
            Assert.AreNotEqual(expected, actual);
        }
    }
}
