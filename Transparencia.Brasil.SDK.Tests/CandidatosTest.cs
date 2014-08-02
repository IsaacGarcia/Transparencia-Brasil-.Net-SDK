using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Transparencia.Brasil.SDK.Entities;
using Transparencia.Brasil.SDK.InfraStructure;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class CandidatosTest
    {
        private Candidatos candidatos;

        public CandidatosTest()
        {
            candidatos = new Candidatos();
        }

        [TestMethod]
        public void obter_todos_os_candidatos_com_sucesso_test()
        {
            var lista = candidatos.Todos("sp", "3");

            Assert.IsTrue(lista.Count > 0);
        }

        [TestMethod]
        public void obter_um_candidadato_pelo_id()
        {
            var candidato = candidatos.PorId(1682111);

            Assert.AreEqual("GERALDO JOSE RODRIGUES ALCKMIN FILHO", candidato.nome);
        }

        [TestMethod]
        public void obter_todos_os_bens_do_candidato_pelo_seu_id()
        {
            var bens = candidatos.Bens(1682111);

            Assert.IsTrue(bens.Count > 0);
        }

        [TestMethod]
        public void obter_todos_os_doadores_do_candidato_pelo_seu_id()
        {
            var doadores = candidatos.Doadores(1682111);

            Assert.IsTrue(doadores.Count > 0);
        }

        [TestMethod]
        public void obter_todos_as_candidaturas_do_candidato_pelo_seu_id()
        {
            var candidaturas = candidatos.Candidaturas(1682111);

            Assert.IsTrue(candidaturas.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(TransparenciaBrasilException))]
        public void obter_todos_as_estatisticas_do_candidato_pelo_seu_id()
        {
            var estatisticas = candidatos.Estatisticas(1682111);

            Assert.IsTrue(estatisticas.Count > 0);
        }
    }
}
