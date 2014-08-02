using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class EstadosTest
    {
        [TestMethod]
        public void obter_todos_os_estados_test()
        {
            Estados estados = new Estados();

            var listaDeTodosOsEstados = estados.Todos();

            Assert.IsTrue(listaDeTodosOsEstados.Count > 0);
        }
    }
}
