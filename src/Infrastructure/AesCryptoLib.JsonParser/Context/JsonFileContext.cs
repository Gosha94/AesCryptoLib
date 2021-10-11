using System.IO;
using Newtonsoft.Json;
using AesCryptoLib.Core.CommonModels;
using AesCryptoLib.Core.CustomExceptions;

namespace AesCryptoLib.JsonParser.Context
{
    /// <summary>
    /// Контекст данных, получаемых из JSON файла с конфигурацией
    /// </summary>
    internal sealed class JsonFileContext
    {

        /// <summary>
        /// Метод получает данные пользователя из файла
        /// </summary>
        /// <returns></returns>
        internal string GetSecretFromJson(string path)
        {
            CheckFilePath(path);

            Root resultData;
            using(var streamReader = new StreamReader(path))
            {
                string json = streamReader.ReadToEnd();
                resultData = JsonConvert.DeserializeObject<Root>(json);
            }
            
            return resultData.UserData.AwesomeExternalData;
        }

        private void CheckFilePath(string filePath)
        {
            if ( !File.Exists(filePath) )
            {
                throw new JsonSecretNotFoundException($"Json файл не существует, либо некорректный путь к файлу: {filePath}, метод CheckFilePath(), слой: Infrastructure, контекст: JsonFileContext");
            }
        }

    }
}
