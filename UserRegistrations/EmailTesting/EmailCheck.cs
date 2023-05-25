using UserRegistrations;

namespace EmailTesting
{
    [TestClass]
    public class EmailCheck
    {
        private Registration obj;
        [TestInitialize]
        public void SetUp()
        {
            obj = new Registration();
        }

        [TestMethod]
        [DataRow("abc@yahoo.com" , "Valid")]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]
        //[DataRow("abc@yahoo.com", true)]

        public void IsValid_WhenCalledWithAGivenPattern_ReturnExpectedResult(string mail , string expectedResult)
        {
            //act
            bool result = expectedResult.Equals(mail);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}