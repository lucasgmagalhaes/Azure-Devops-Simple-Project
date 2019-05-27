using demo;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class Form1UnitTest
    {
        [Test]
        public void TestMethod1()
        {
            Form1 form = new Form1();
           Assert.AreEqual(form.CalcularSomar(3, 2), 5);
        }
    }
}