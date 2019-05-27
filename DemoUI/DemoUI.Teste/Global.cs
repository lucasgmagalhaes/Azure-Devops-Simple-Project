using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoUI.Componente.Comum;
using System.IO;

namespace DemoUI.Teste
{
    [SetUpFixture]
    public static class Global
    {
        [OneTimeSetUp]
        public static void Setup()
        {
            WhiteUtils.Iniciar(@"demo.exe");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            WhiteUtils.Finalizar();
        }
    }
}
