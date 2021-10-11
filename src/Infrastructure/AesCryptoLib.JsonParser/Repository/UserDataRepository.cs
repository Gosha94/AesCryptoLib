using AesCryptoLib.Core.Contracts;
using AesCryptoLib.JsonParser.Context;

namespace AesCryptoLib.JsonParser.Repository
{
    public sealed class UserDataRepository : IReadOnlyUserDataRepository
    {

        private readonly JsonFileContext _jsonFileContext;

        public UserDataRepository()
        {
            _jsonFileContext = new JsonFileContext();
        }

        public string GetSecretFromSource(string filePath)
            => this._jsonFileContext.GetSecretFromJson(filePath);

    }
}
