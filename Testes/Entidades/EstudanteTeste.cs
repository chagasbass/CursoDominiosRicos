using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;

namespace Testes.Entidades
{
    /// <summary>
    /// Descrição resumida para EstudanteTeste
    /// </summary>
    [TestClass]
    public class EstudanteTeste
    {
        public EstudanteTeste()
        {
            //
            // TODO: Adicionar lógica de construtor aqui
            //
        }


        [TestMethod]
        public void TestMethod1()
        {
            var assinatura = new Assinatura(null);
            //var estudante = new Estudante("Joao","Silva","123456","joao@teste.com");
        }
    }
}