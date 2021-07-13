using AesCryptoLib.DLL;
using AesCryptoLib.DLL.Controller;

namespace CryptoWrapper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var cryptoMain = new CryptoManager();
            var shifr = cryptoMain.Encrypt("1");
            var clearText = cryptoMain.Decrypt("1");
            
            System.Console.WriteLine();
        }
    }
}
