using System;

namespace AesCryptoLib.Core.CustomExceptions
{
    /// <summary>
    /// Исключение, создаваемое при отсутствии Json файла в директории (D:\UkTransmitterConfig\JsonSecret)
    /// </summary>
    public class JsonSecretNotFoundException : Exception
    {
        public JsonSecretNotFoundException()
        { }

        public JsonSecretNotFoundException(string message)
            : base(message)
        {

        }

    }
}
