using AesCryptoLib.JsonParser.Repository;

namespace AesCryptoLib.ConsoleWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            var testCorrectFilePath = "D:\\UkTransmitterConfig\\JsonSecret\\TestUserData.json";
            var expectedSecretValue = "someTestData";

            // Act
            var checkedRepository = new UserDataRepository();
            var actualSecretValue = checkedRepository.GetSecretFromSource(testCorrectFilePath);
            System.Console.WriteLine();
        }
    }
}
