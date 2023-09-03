using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParolClass;

namespace ParolTests
{
    [TestClass]
    public class ParolValidatorTests
    {
        private string TestPassword;

        [TestInitialize]
        public void Initialize()
        {
            TestPassword = "8wwwwwwwW&"; // Установка пароля
        }

        [TestMethod]
        public void TestPasswordScore1_Numeric() //проверка на наличие Цифр
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(1, testScores[0]);
        }

        [TestMethod]
        public void TestPasswordScore2_ComplexPassword() //проверка на наличие строчных символов
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(1, testScores[1]);
        }

        [TestMethod]
        public void TestPasswordScore3_Uppercase() //проверка на наличие заглавных символов
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(1, testScores[2]);
        }

        [TestMethod]
        public void TestPasswordScore4_SpecialCharacters() //проверка на наличие спец символов
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(1, testScores[3]);
        }

        [TestMethod]
        public void TestPasswordScore5_TooShort() //проверка на наличие минимум 7 символов
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(1, testScores[4]);
        }

        [TestMethod]
        public void TestPasswordScore6_Allcorrect() //тест на то, что все тесты выполнены
        {
            ParolValidator validator = new ParolValidator();
            int[] testScores = validator.ValidatePassword(TestPassword);
            Assert.AreEqual(5, testScores[5]);
        }
    }

}


