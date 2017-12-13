using Dominio.ObjetosDeValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes.ObjetosDeValor
{
    [TestClass]
    public class DocumentoTeste
    {
        //red,green, refactor
        //testes falham, testes passam , refatorar

        [TestMethod]
        public void DeveRetornarErrorQuandoCNPJForInvalido()
        {
            var doc = new Documento("123", Dominio.Enums.ETipoDocumento.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void DeveRetornarErrorQuandoCNPJForValido()
        {
            var doc = new Documento("34110468000150", Dominio.Enums.ETipoDocumento.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void DeveRetornarErrorQuandoCPFForInvalido()
        {
            var doc = new Documento("123", Dominio.Enums.ETipoDocumento.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void DeveRetornarErrorQuandoCPFForValido()
        {
            var doc = new Documento("05492256769", Dominio.Enums.ETipoDocumento.CPF);
            Assert.IsTrue(doc.Valid);
        }

    }
}
