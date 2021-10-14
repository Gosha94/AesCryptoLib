using JsonConfigParser.Api.PublicAPI;
using JsonConfigParser.Core.Contracts;
using JsonConfigParser.Core.FileConfigs;
using AesCryptoLib.BusinessLogic.Services;

namespace AesCryptoLib.Api.PublicApi
{

    /// <summary>
    /// Контроллер для работы с AES шифрованием
    /// </summary>
    public sealed class CryptoApiController
    {

        #region Private Fields

        private IFileConfiguration _jsonConfiguration;

        private AesCryptoService _cryptoService;
        private JsonParsingApi _jsonParsingApi;

        #endregion

        #region Public Properties

        public IFileConfiguration JsonConfiguration
        {
            get => this._jsonConfiguration;
            private set => this._jsonConfiguration = value;
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CryptoApiController()
        {
            JsonConfiguration = new JsonSaltFileConfiguration();
        }

        /// <summary>
        /// Дополнительный конструктор для внедрения конфигурации извне
        /// </summary>
        /// <param name="jsonConfig"></param>
        public CryptoApiController(IFileConfiguration jsonConfig)
        {
            JsonConfiguration = jsonConfig;
        }

        #endregion

        #region Public Controller Api

        /// <summary>
        /// Метод получения расшифрованных данных
        /// </summary>
        /// <param name="mysteryString">Шифрограмма</param>
        /// <returns></returns>
        public string GetDeclassifiedData(string mysteryString)
        {
            var secret = GetSecretFromJsonParsingApi();
            this._cryptoService = new AesCryptoService(secret);
            var encryptedData = mysteryString;
            var resultData = this._cryptoService.Decrypt(encryptedData);
            return resultData;
        }

        /// <summary>
        /// Метод получения шифрованных данных
        /// </summary>
        /// <param name="openString"></param>
        /// <returns></returns>
        public string GetMysteryData(string openString)
        {
            var secret = GetSecretFromJsonParsingApi();
            this._cryptoService = new AesCryptoService(secret);
            var decryptedData = openString;
            var resultData = this._cryptoService.Encrypt(decryptedData);
            return resultData;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Метод получения секретного ключа из JSON файла конфигурации
        /// </summary>
        /// <returns></returns>
        private string GetSecretFromJsonParsingApi()
        {
            this._jsonParsingApi = new JsonParsingApi();
            var result = this._jsonParsingApi.GetSecretJsonData(JsonConfiguration);
            return result;
        }

        #endregion

    }
}