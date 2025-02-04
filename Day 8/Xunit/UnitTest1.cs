using SampleTestDemo;
using Moq;
namespace TestProjectXunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Employee em = new Employee("Neha", 25);
            string actual = em.name;
            int actual2 = em.age;
            Assert.Equal("Neha", actual);
            Assert.Equal(20, actual2);


        }
        [Fact]
        public void PassingTestAdd()
        {
             Mock<MathOp> calculator = new Mock<MathOp>();
            calculator.Setup(x => x.Add(5,5)).Returns(10);
            Assert.Equal(10, calculator.Object.Add(5, 5));
        }
    }
}
