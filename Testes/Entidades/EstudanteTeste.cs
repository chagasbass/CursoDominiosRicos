using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;
using Dominio.ObjetosDeValor;
using System;

namespace Testes.Entidades
{
    /// <summary>
    /// Descrição resumida para EstudanteTeste
    /// </summary>
    [TestClass]
    public class EstudanteTeste
    {
        [TestMethod]
        public void DeveRetornarErroQuandoTiverUmaAssinaturaValida()
        {
            var nome = new Nome("Thiago", "Chagas");
            var email = new Email("chagas.bass@gmail.com");
            var doc = new Documento("05492256769", Dominio.Enums.ETipoDocumento.CPF);
            var endereco = new Endereco("A", "21", "Niteroi","23130110", "Fonseca", "Rio De Janeiro");

            var estudante = new Estudante(nome, doc, email);

            var assinatura = new Assinatura(null);

            var pagamento = new PayPalPagamento("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Thiago", doc, endereco, email);

            assinatura.InserirPagamento(pagamento);
            estudante.InserirAssinatura(assinatura);
            estudante.InserirAssinatura(assinatura);

            Assert.IsTrue(estudante.Invalid);
        }

        [TestMethod]
        public void DeveRetornarErroQuandoNaoTiverUmaAssinaturaValida()
        {
            //var nome = new Nome("Thiago", "Chagas");
            //var email = new Email("chagas.bass@gmail.com");
            //var doc = new Documento("05492256769", Dominio.Enums.ETipoDocumento.CPF);

            //var estudante = new Estudante(nome, doc, email);

            //var assinatura = new Assinatura()

            Assert.Fail();
        }
    }
}