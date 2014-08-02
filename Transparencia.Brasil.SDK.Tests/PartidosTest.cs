using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class PartidosTest
    {
        [TestMethod]
        public void obter_todos_os_partidos_test()
        {
            Partidos partidos = new Partidos();

            var listaDePartidos = partidos.Todos();

            Assert.IsTrue(listaDePartidos.Count > 0);
        }
    }
}
