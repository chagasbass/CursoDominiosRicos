using Dominio.Comandos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes.Comandos
{
    /// <summary>
    /// Descrição resumida para CriarEstudanteComandoTeste
    /// </summary>
    [TestClass]
    public class CriarEstudanteComandoTeste
    {

        [TestMethod]
        public void DeveRetornarErroQuandoNomeDeEstudandeNaoForPreenchido()
        {
            var comando = new CriarEstudanteComando();
            comando.Email = "teste@teste.com";
            comando.Numero = "123456";
            comando.Tipo = "Tipo";
            comando.PrimeiroNome = "Teste";
            comando.Sobrenome = "";

            comando.ValidarComando();

            Assert.AreEqual(false, comando.Valid);

        }

        [TestMethod]
        public void DeveRetornarErroQuandoSobrenomeDeEstudandeNaoForPreenchido()
        {
            var comando = new CriarEstudanteComando();
            comando.Email = "teste@teste.com";
            comando.Numero = "123456";
            comando.Tipo = "Tipo";
            comando.PrimeiroNome = "";
            comando.Sobrenome = "Teste";

            comando.ValidarComando();

            Assert.AreEqual(false, comando.Valid);

        }
    }
}
