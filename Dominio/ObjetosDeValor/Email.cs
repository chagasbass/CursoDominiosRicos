using Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Email: ObjetoDeValor
    {
        public string Endereco { get; set; }

        public Email(string endereco)
        {
            Endereco = endereco;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Endereco, "Email", "Email inválido"));
        }
    }
}
