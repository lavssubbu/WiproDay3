using SampleTestDemo;
namespace TestMathOP
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]//Test Attribute
        public void TestMethod1()
        {
            //3 A's - Arrange, Act and Assert
            //test for Add method
            MathOp mth = new MathOp();//Arrange
           int res = mth.Add(20, 20); //Act
            Assert.AreEqual(res, 40);//Assert Passed if expected(res) matches with actual value
        }
        [TestMethod]//Test Attribute
        public void TestMethodSub()
        {
            //test for Add method
            MathOp mth = new MathOp();
            int res = mth.Sub(50, 20);
            Assert.AreEqual(res, 30);//Passed if expected(res) matches with actual value
        }
        [TestMethod]//Test Attribute
        public void TestMethodProd()
        {
            //test for Add method
            MathOp mth = new MathOp();
            int res = mth.Mul(50, 40);
            Assert.AreEqual(res, 500);//Passed if expected(res) matches with actual value
        }
    }
}
