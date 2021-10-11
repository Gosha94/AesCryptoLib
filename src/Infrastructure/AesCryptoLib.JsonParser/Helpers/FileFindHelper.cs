using System.Reflection;
using AesCryptoLib.Core.Contracts;

namespace AesCryptoLib.JsonParser.Helpers
{

    /// <summary>
    /// Класс описывает Поисковик файла в директории
    /// </summary>
    internal sealed class FileFindHelper
    {
        private IFileConfiguration _configuration;

        public FileFindHelper(IFileConfiguration configFromDi)
        {
            #region Dependency Injection

            this._configuration = configFromDi;

            #endregion

            

        }

        /// <summary>
        /// Метод возвращает полный путь к директории с файлом из настроек
        /// </summary>
        /// <returns></returns>
        internal string GetFullPathToJsonFile()
            =>  Assembly.GetAssembly(typeof(IFileConfiguration)).Location + this._configuration.FileName;



    }
}
