using AesCryptoLib.Core.CommonModels;
using System.Collections.Generic;

namespace AesCryptoLib.Core.Contracts
{

    /// <summary>
    /// Интерфейс описывает Репозиторий для read-only доступа к JSON файлу с пользовательскими данными
    /// </summary>
    public interface IReadOnlyUserDataRepository
    {

        /// <summary>
        /// Метод получения всех данных из файла
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserData> GetAllUserDataFromSource();

        /// <summary>
        /// Метод получения конкретных данных по Id
        /// </summary>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        UserData GetUserDataById(int userDataId);

    }
}
