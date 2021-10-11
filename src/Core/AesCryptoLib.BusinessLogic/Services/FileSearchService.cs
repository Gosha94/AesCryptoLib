﻿using System.Reflection;
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
        internal string GetFullPathToJsonFile()
            =>  Assembly.GetAssembly(typeof(IFileConfiguration)).Location + this._configuration.FileName;



    }
}