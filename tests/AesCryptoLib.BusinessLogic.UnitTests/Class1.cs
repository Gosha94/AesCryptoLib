namespace AesCryptoLib.BusinessLogic.UnitTests
{
    public class Class1
    {
        private CryptoManager _testedCryptoManager;
        public CryptoManagerTests()
        {
            this._testedCryptoManager = new CryptoManager();
        }

        [TestMethod]
        public void Decrypt_Test()
        {
            var shifr = "HNI4J6NqkHUOhgrSgoPv7rE4I0vfclHuYuj9iTMGkA==";
            var expected = "1";
            var actual = _testedCryptoManager.Decrypt(shifr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Encrypt_Test()
        {
            var clearText = "1";
            var expected = "HNI4J6NqkHUOhgrSgoPv7rE4I0vfclHuYuj9iTMGkA==";
            var actual = _testedCryptoManager.Encrypt(clearText);
            // Результаты не должны совпадать с предыдущим шифром, алгоритм работает
            Assert.AreNotEqual(expected, actual);
        }
    }
}
