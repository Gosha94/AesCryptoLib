using AesCryptoLib.Core.Contracts;

namespace AesCryptoLib.Core.FileConfigs
{

    /// <summary>
    /// Класс с настройками парсинга Конфигурации дешифровки
    /// </summary>
    public sealed class JsonSaltFileConfiguration : IFileConfiguration
    {

        public string FileDirectory { get; private set; }
        public string FileName { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        internal JsonSaltFileConfiguration()
        {
            this.FileDirectory = "/JsonSettings";
            this.FileName = "UserData.json";
        }

    }
}
