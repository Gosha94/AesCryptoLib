using NUnit.Framework;
using AesCryptoLib.BusinessLogic.Services;

namespace AesCryptoLib.BusinessLogic.UnitTests.Services
{

    [TestFixture]
    public class AesCryptoServiceTests
    {

        private string _cryptoKeyStub;
        private AesCryptoService _cryptoServiceUnderTests;

        public AesCryptoServiceTests()
        {
            this._cryptoKeyStub = "I'mTestKey";
            this._cryptoServiceUnderTests = new AesCryptoService(this._cryptoKeyStub);
        }

        [Test]
        public void DecryptMethodTest_PassedIfDecryptedDataIsEqualToExpected()
        {

            // Arrange
            var expectedDecryptedData = "helloTest";
            var testEncryptedStub = this._cryptoServiceUnderTests.Encrypt(expectedDecryptedData);

            // Act
            var actualDecryptedData = this._cryptoServiceUnderTests.Decrypt(testEncryptedStub);

            // Assert
            Assert.AreEqual(expectedDecryptedData, actualDecryptedData);

        }

        [Test]
        public void EncryptMethodTest_PassedIfEncryptedDataIsEqualToExpected()
        {

            // Arrange
            var expectedDecryptedData = "helloTest";

            // Act
            var testEncryptedData = this._cryptoServiceUnderTests.Encrypt(expectedDecryptedData);
            var actualDecryptedData = this._cryptoServiceUnderTests.Decrypt(testEncryptedData);

            // Assert
            Assert.AreEqual(expectedDecryptedData, actualDecryptedData);

        }
    }
}
