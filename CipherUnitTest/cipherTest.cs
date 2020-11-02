using Microsoft.VisualStudio.TestTools.UnitTesting;
using TU_homework;

namespace CipherUnitTest
{
    [TestClass]
    public class CipherTest
    {
        [TestMethod]
        public void TestMethod1()
        {   
            string text = "ABC";
            string encryptedText = "CDE";
            int shift = 2;
            _CaesarCipher cipher = new _CaesarCipher();
            string encryptedT = cipher.encryptText(text, shift);
            Assert.AreEqual(encryptedText, encryptedT, "Encryption was unsuccessful");
            string decryptedT = cipher.decryptText(encryptedText, shift);
            Assert.AreEqual(text, decryptedT, "Decryption was unsuccessful");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string text = "Long sentence. With symbols! And 1 number?";
            string encryptedText = "Nqpi ugpvgpeg. Ykvj uaodqnu! Cpf 1 pwodgt?";
            int shift = 28;
            _CaesarCipher cipher = new _CaesarCipher();
            string encryptedT = cipher.encryptText(text, shift);
            Assert.AreEqual(encryptedText, encryptedT, "Encryption was unsuccessful");
            string decryptedT = cipher.decryptText(encryptedText, shift);
            Assert.AreEqual(text, decryptedT, "Decryption was unsuccessful");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string text = "Long sentence. With symbols! And 1 number?";
            string encryptedText = "Jmle qclrclac. Ugrf qwkzmjq! Ylb 1 lskzcp?";
            int shift = -28;
            _CaesarCipher cipher = new _CaesarCipher();
            string encryptedT = cipher.encryptText(text, shift);
            Assert.AreEqual(encryptedText, encryptedT, "Encryption was unsuccessful");
            string decryptedT = cipher.decryptText(encryptedText, shift);
            Assert.AreEqual(text, decryptedT, "Decryption was unsuccessful");
        }

    }
}
