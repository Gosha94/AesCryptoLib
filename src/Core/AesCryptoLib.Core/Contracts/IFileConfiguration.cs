namespace AesCryptoLib.Core.Contracts
{

    /// <summary>
    /// Интерфейс описывает конфигурацию файла
    /// </summary>
    public interface IFileConfiguration
    {
        
        /// <summary>
        /// Директория файла
        /// </summary>
        string FileDirectory { get; }

        /// <summary>
        /// Имя файла
        /// </summary>
        string FileName { get; }
    }
}