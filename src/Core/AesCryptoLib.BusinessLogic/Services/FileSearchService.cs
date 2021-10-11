using System.Text;
using AesCryptoLib.Core.Contracts;

namespace AesCryptoLib.JsonParser.Helpers
{

    /// <summary>
    /// Служба предназначена для поиска файла в директории
    /// </summary>
    public sealed class FileSearchService
    {
        private IFileConfiguration _configuration;

        public FileSearchService(IFileConfiguration configFromDi)
        {
            #region Dependency Injection

            this._configuration = configFromDi;

            #endregion
        }

        /// <summary>
        /// Метод возвращает полный путь к директории с файлом из настроек
        /// </summary>
        /// <returns></returns>
        public string GetFullPathToJsonFile()
            => new StringBuilder()
                .Append(this._configuration.FileDirectory)
                .Append(this._configuration.FileName)
                .ToString();
    }
}
