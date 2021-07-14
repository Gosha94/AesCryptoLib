using System;
using System.Collections.Generic;
using AesCryptoLib.DLL.Controller;

namespace CryptoWrapper.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cryptoMain = new CryptoManager();
            //var shifr = cryptoMain.Encrypt("1");
            //var clearText = cryptoMain.Decrypt("1");           

            Console.ReadLine();
        }
    }
}
