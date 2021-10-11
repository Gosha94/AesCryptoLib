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

        private StartupDependencyConfigurator _configurator;
        private FileSearchService _searchService;

        private IReadOnlyUserDataRepository _jsonFileRepository;
        private IFileConfiguration _jsonFileConfiguration;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CryptoApiController()
        {
            _configurator = new StartupDependencyConfigurator();
            _configurator.RegisterAllInstancesInApplication();

            _jsonFileRepository = _configurator.GetRepositoryInstance();
            _jsonFileConfiguration = _configurator.GetJsonConfigurationInstance();

            _searchService = new FileSearchService(_jsonFileConfiguration);
        }

        /// <summary>
        /// Метод получения расшифрованных данных
        /// </summary>
        /// <param name="mysteryString">Шифрограмма</param>
        /// <returns></returns>
        public string GetDeclassifiedData(string mysteryString)
        {
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