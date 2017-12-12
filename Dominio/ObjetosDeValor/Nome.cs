using Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Nome: ObjetoDeValor
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(PrimeiroNome, "Nome", "Nome inválido"))
                .IsNullOrEmpty(Sobrenome, "Sobrenome", "Sobrenome inválido");

           
                
        }
    }
}