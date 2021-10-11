using AesCryptoLib.Api.Config;
using AesCryptoLib.Core.Contracts;
using AesCryptoLib.JsonParser.Helpers;

namespace AesCryptoLib.Api.PublicApi
{

    /// <summary>
    /// Контроллер для работы с AES шифрованием
    /// </summary>
    public sealed class CryptoApiController : IAesController
    {

        private readonly StartupDependencyConfigurator _configurator;
        private readonly FileSearchService _searchService;

        private readonly IReadOnlyUserDataRepository _jsonFileRepository;
        private readonly IFileConfiguration _jsonFileConfiguration;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CryptoApiController()
        {
            this._configurator = new StartupDependencyConfigurator();
            this._configurator.RegisterAllInstancesInApplication();

            this._jsonFileRepository = _configurator.GetRepositoryInstance();
            this._jsonFileConfiguration = _configurator.GetJsonConfigurationInstance();

            this._searchService = new FileSearchService(this._jsonFileConfiguration);
        }

        /// <summary>
        /// Метод получения расшифрованных данных
        /// </summary>
        /// <param name="mysteryString">Шифрограмма</param>
        /// <returns></returns>
        public string GetDeclassifiedData(string mysteryString)
        {
            var pathToJsonConfig = this._searchService.GetFullPathToJsonFile();
            this._jsonFileRepository.GetUserDataById(0);
            
            return "There will be your clearText";
        }

        /// <summary>
        /// Метод получения шифрованных данных
        /// </summary>
        /// <param name="openString"></param>
        /// <returns></returns>
        public string GetMysteryData(string openString)
        {
            return "There will be your mysteryText";
        }

    }
}