using System.IO;
using Newtonsoft.Json;
using AesCryptoLib.Core.CommonModels;

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
            UserData resultData;
            using(var streamReader = new StreamReader(path))
            {
                string json = streamReader.ReadToEnd();
                resultData = JsonConvert.DeserializeObject<UserData>(json);
            }
            
            return resultData.AwesomeExternalData;
        }

    }
}
