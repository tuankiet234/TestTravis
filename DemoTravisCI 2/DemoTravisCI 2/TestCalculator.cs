using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTravisCI_2
{
    [TestFixture]
    public class TestCalculator
    {
        private CalculatorSample _cal;

        [SetUp]
        public void SetUp()
        {
            _cal = new CalculatorSample();
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 6, 8)]
        [TestCase(-1, 9, 8)]
        public void TestCong(int a, int b, int kq)
        {
            Assert.AreEqual(kq, _cal.Cong(a, b));
        }

        [TestCase(0, 3, 0)]
        [TestCase(3, 0, 0)]
        [TestCase(-1, 5, -5)]
        [TestCase(5, -5, -25)]
        [TestCase(4, 2, 8)]
        public void TestNhan(int a, int b, int kq)
        {
            Assert.AreEqual(kq, _cal.Nhan(a, b));
        }
    }
}
