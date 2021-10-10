using System.Collections.Generic;
using AesCryptoLib.Core.Contracts;

namespace AesCryptoLib.Core.CommonModels
{
    public sealed class UserDataRepository : IReadOnlyUserDataRepository
    {
        public IEnumerable<UserData> GetAllUserDataFromSource()
        {
            throw new System.NotImplementedException();
        }

        public UserData GetUserDataById(int userDataId)
        {
            throw new System.NotImplementedException();
        }
    }
}
