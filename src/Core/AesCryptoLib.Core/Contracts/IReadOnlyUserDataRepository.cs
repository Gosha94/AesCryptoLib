using AesCryptoLib.Core.CommonModels;

namespace AesCryptoLib.Core.Contracts
{

    /// <summary>
    /// Интерфейс описывает Репозиторий для read-only доступа к JSON файлу с пользовательскими данными
    /// </summary>
    public interface IReadOnlyUserDataRepository
    {

        /// <summary>
        /// Метод получения данных из Json файла
        /// </summary>
        /// <param name="filePath">Путь к Json файлу</param>
        /// <returns></returns>
        string GetSecretFromSource(string filePath);

    }
}
