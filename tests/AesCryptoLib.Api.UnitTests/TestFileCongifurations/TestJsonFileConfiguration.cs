using JsonConfigParser.Core.Contracts;

namespace AesCryptoLib.Api.UnitTests.TestFileCongifurations
{
    internal sealed class TestJsonFileConfiguration : IFileConfiguration
    {
        public string FileDirectory { get; private set; }

        public string FileName { get; private set; }

        public TestJsonFileConfiguration()
        {
            this.FileDirectory = "D:\\UkTransmitterConfig\\TestJson\\";
            this.FileName = "CorrectTest.json";
        }

    }
}
