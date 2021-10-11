using AesCryptoLib.Core.Contracts;

namespace AesCryptoLib.JsonParser.FileConfigs
{
    internal sealed class JsonDBaseConfiguration : IFileConfiguration
    {
        public string FileDirectory { get; private set; }
        public string FileName { get; private set; }

        public JsonDBaseConfiguration()
        {
            this.FileDirectory = "/JsonSettings";
            this.FileName = "ConnectionData";
        }

    }
}
