using Compartilhados.ObjetosDeValor;
using Dominio.Enums;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Documento: ObjetoDeValor
    {
        public string Numero { get; set; }
        public ETipoDocumento Tipo { get; set; }

        public Documento(string numero,ETipoDocumento tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(ValidarDocumento(), "Numero", "Documento inválido");

        }

        private bool ValidarDocumento()
        {
            if (Tipo == ETipoDocumento.CNPJ && Numero.Length == 14)
                return true;
            if (Tipo == ETipoDocumento.CPF && Numero.Length == 11)
                return true;

            return false;
        }
    }
}