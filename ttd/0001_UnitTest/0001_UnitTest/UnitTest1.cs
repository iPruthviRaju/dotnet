///----------------------------------------------------------------------
/// <File>UnitTest1</File>
/// <Author>Pruthvi</Author>
/// <Date>August 5th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0001_UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ClassLibrary1;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponents mathsComponents = new MathsComponents();
            int result = mathsComponents.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubstract()
        {
            MathsComponents mathsComponents = new MathsComponents();
            int result = mathsComponents.Substract(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
