using Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public  class Endereco:ObjetoDeValor
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Cidade { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string rua, string numero, string cidade, string cep, string bairro, string estado)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Cep = cep;
            Bairro = bairro;
            Estado = estado;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Rua, "Rua", "Rua inválida"));
        }
    }
}