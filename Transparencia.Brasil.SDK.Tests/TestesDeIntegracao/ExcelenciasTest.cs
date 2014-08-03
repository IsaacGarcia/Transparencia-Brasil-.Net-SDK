using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;

namespace Transparencia.Brasil.SDK.Tests.TestesDeIntegracao
{
    [TestClass]
    public class ExcelenciasTest
    {
        private Excelencias excelencias;

        public ExcelenciasTest()
        {
            excelencias = new Excelencias();
        }

        [TestMethod]
        public void obter_todas_as_excelencias_com_sucesso()
        {
            var listaDeExcelencias = excelencias.Todas("1");

            Assert.IsTrue(listaDeExcelencias.Count > 0);
        }

        [TestMethod]
        public void obter_uma_excelencia_pelo_seu_id()
        {
            Assert.IsTrue(excelencias.PorId(8362) != null);
        }

        [TestMethod]
        public void obter_os_bens_de_uma_excelencia()
        {
            Assert.IsTrue(excelencias.Bens(8362).Count > 0);
        }
    }
}
