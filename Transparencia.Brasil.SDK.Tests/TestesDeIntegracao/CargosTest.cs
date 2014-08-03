using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class CargosTest
    {
        [TestMethod]
        public void obter_todos_os_cargos_test()
        {
            Cargos cargos = new Cargos();

            var listaDeCargos = cargos.Todos();

            Assert.IsTrue(listaDeCargos.Count > 0);
        }
    }
}
