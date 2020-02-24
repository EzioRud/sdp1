using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange
            Program res = new Program();            
            //act
            string ans = res.Prefix("Hello");
            //Assert
            Assert.Pass(ans, "5,1:hello");
        }
        [Test]
        public void Test2()
        {
            //arrange
            Program res = new Program();            
            //act
            string ans = res.Prefix("");
            //Assert
            Assert.Pass(ans, "0,0:");
        }
        [Test]
        public void Test3()
        {
            //arrange
            Program res = new Program();            
            //act
            string ans = res.Prefix("what    ...  did you say??");
            //Assert
            Assert.Pass(ans, "27,5:what    ...  did you say?? ");
        }
    }
}