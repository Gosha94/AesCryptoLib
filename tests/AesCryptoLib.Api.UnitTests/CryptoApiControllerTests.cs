using NUnit.Framework;
using AesCryptoLib.Api.PublicApi;
using JsonConfigParser.Core.Contracts;
using AesCryptoLib.Api.UnitTests.TestFileCongifurations;

namespace AesCryptoLib.Api.UnitTests
{

    [TestFixture]
    public class CryptoApiControllerTests
    {

        private CryptoApiController _cryptoApiUnderTests;
        private IFileConfiguration _fileCongifurationStub;

        public CryptoApiControllerTests()
        {
            this._fileCongifurationStub = new TestJsonFileConfiguration();
            this._cryptoApiUnderTests = new CryptoApiController(this._fileCongifurationStub);
        }

        [Test]
        public void GetMysteryDataMethodTest_PassedIfOpenDataCorrectAfterEncrypt()
        {

            // Arrange
            var expectedOpenData = "testDataStub";
            var mysteryOfOpenData = this._cryptoApiUnderTests.GetMysteryData(expectedOpenData);

            // Act
            var actualOpenData = this._cryptoApiUnderTests.GetDeclassifiedData(mysteryOfOpenData);

            // Assert
            Assert.AreEqual(expectedOpenData, actualOpenData);

        }

    }
}