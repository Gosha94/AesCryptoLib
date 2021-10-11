using AesCryptoLib.Core.Contracts;
using System.Configuration;

namespace AesCryptoLib.JsonParser.FileConfigs
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
            this.FileDirectory = "";
            this.FileName = ConfigurationManager.AppSettings.Get("pathTestUserData");
        }

    }
}
