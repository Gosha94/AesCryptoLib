using NUnit.Framework;
using AesCryptoLib.Core.CustomExceptions;
using AesCryptoLib.JsonParser.Repository;

namespace AesCryptoLib.Infrastructure.NUnit.IntegrationTests
{

    [TestFixture]
    public class UserDataRepositoryTests
    {
        
        //[SetUp]
        //public void SetupBeforeEachTest()
        //{

        //}

        [Test]
        public void GetSecretFromSource_CorrectPath_ReturnCorrectSecret()
        {
            // Arrange
            var testCorrectFilePath = "D:\\UkTransmitterConfig\\JsonSecret\\TestUserData.json";
            var expectedSecretValue = "someTestData";

            // Act
            var checkedRepository = new UserDataRepository();
            var actualSecretValue = checkedRepository.GetSecretFromSource(testCorrectFilePath);

            // Assert
            Assert.AreEqual(expectedSecretValue, actualSecretValue);

        }

        [Test]
        public void r()
        {
            //JsonSecretNotFoundException
            Assert.Pass();
        }

    }
}
