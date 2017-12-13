using Compartilhados.Comandos;
using Flunt.Notifications;
using Flunt.Validations;

namespace Dominio.Comandos
{
    public class CriarEstudanteComando: Notifiable,IComando
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }

        public string Numero { get; set; }
        public string Tipo { get; set; }

        public string Email { get; set; }

        public CriarEstudanteComando()
        {

        }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
                 .Requires()
                .IsNullOrEmpty(PrimeiroNome, "Nome", "Nome inválido")
                .IsNullOrEmpty(Sobrenome, "Sobrenome", "Sobrenome inválido")
                 .IsEmail(Email, "Email", "Email inválido"));
        }
    }
}