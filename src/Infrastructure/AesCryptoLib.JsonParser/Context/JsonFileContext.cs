using AesCryptoLib.JsonParser.Helpers;

namespace AesCryptoLib.JsonParser.Context
{
    /// <summary>
    /// Контекст данных, получаемых из JSON файла с конфигурацией
    /// </summary>
    public sealed class JsonFileContext
    {
        private JsonParseHelper _jsonParser;

        public JsonFileContext()
        {
            this._jsonParser = new JsonParseHelper();
            this._jsonParser.GetDataFromJson();
        }
    }
}
