using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transparencia.Brasil.SDK.Resources;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class CandidatosTest
    {
        [TestMethod]
        public void obter_todos_os_candidatos_com_sucesso_test()
        {
            Candidatos candidatos = new Candidatos();

            var lista = candidatos.ObterTodosOsCandidatos("sp", "3");
        }
    }
}
