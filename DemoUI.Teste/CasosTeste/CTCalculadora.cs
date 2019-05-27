using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoUI.Componente.PageObjects;

namespace DemoUI.Teste.CasosTeste
{
    class CTCalculadora
    {
        [Test]
        [TestCase(TestName = "Soma simples")]
        public void CT001()
        {
            FCalculadora form = new FCalculadora();

            string num1 = "5";
            string num2 = "2";
            string resultado = form.SomarNumeros(num1, num2);

            Assert.AreEqual("7", resultado);
        }
    }
}
