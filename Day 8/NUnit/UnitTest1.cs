using Moq;
using SampleTestDemo;

namespace TestProjectnunit
{
    public class Tests
    {
        public int i = 50, j = 10;
        public bool result;

        [SetUp]
        public void CheckNonNegative()
        {
            if(i>0 && j>0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        [Test]
        public void TestAdd()
        {
            if(result)
            {
                MathOp mop = new MathOp();
                int res = mop.Add(i,j);
                Assert.AreEqual(20, res);

            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        [TestCase(100,2,50)]
        [TestCase(50,2,25)]
        public void TestDiv(int a,int b,int actual)
        {
            
            MathOp mth = new MathOp();
            int result = mth.Div(a,b);
            Assert.AreEqual(result, actual);

        }
        [Test]
        [Ignore("Not yet Implemented")]
        public void TestSub()
        {

        }

        [Test]
        public void TestPro()
        {
            //Arrange
            MathOp mh = new MathOp();
            //Act
            int res = mh.Mul(i, j);
            //Assert
            Assert.AreEqual(1000,res);
        }
        [Test]
        public void MockTest()
        {
            Mock<MathOp> m = new Mock<MathOp>();
            m.Setup(x=>x.CheckValues()).Returns(true);
            Assert.AreEqual(true, m.Object.CheckValues());
        }
    }
}
