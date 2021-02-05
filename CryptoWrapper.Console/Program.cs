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
            var clearText = cryptoMain.Decrypt("HNI4J6NqkHUOhgrSgoPv7rE4I0vfclHuYuj9iTMGkA==");            
        }
    }
}
