using AesCryptoLib.Api.Config;
using AesCryptoLib.Core.Contracts;
using AesCryptoLib.JsonParser.Helpers;
using AesCryptoLib.BusinessLogic.Services;

namespace AesCryptoLib.Api.PublicApi
{

    /// <summary>
    /// Контроллер для работы с AES шифрованием
    /// </summary>
    public sealed class CryptoApiController : IAesController
    {

        #region Private Fields
        private readonly FileSearchService _fileService;

        private readonly IReadOnlyUserDataRepository _jsonFileRepository;
        private readonly IFileConfiguration _jsonFileConfiguration;

        private AesCryptoService _cryptoService;

        #endregion

        #region Constructor

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CryptoApiController(IReadOnlyUserDataRepository jsonFileRepository, IFileConfiguration jsonFileConfiguration)
        {
            this._jsonFileRepository = jsonFileRepository;
            this._jsonFileConfiguration = jsonFileConfiguration;

            this._fileService = new FileSearchService(this._jsonFileConfiguration);
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
            var secret = GetSecretFromRepository();

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
            var secret = GetSecretFromRepository();

            this._cryptoService = new AesCryptoService(secret);
            var decryptedData = openString;

            var resultData = this._cryptoService.Encrypt(decryptedData);

            return resultData;
        }

        #endregion

        #region Private Methods

        private string GetSecretFromRepository()
        {
            var pathToJsonConfig = this._fileService.GetFullPathToJsonFile();
            var result = this._jsonFileRepository.GetSecretFromSource(pathToJsonConfig);
            return result;
        }

        #endregion

    }
}