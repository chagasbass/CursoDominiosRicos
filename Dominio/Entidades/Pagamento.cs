using Compartilhados.Entidades;
using Dominio.ObjetosDeValor;
using Flunt.Validations;
using System;

namespace Dominio.Entidades
{
    public abstract class Pagamento:Entidade
    {
        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Pagador { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; private set; }

        public Pagamento(DateTime dataPagamento, DateTime dataExpiracao, decimal total,
            decimal totalPago, string pagador,Documento documento,Endereco endereco,Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPago = totalPago;
            Pagador = pagador;
            Documento = documento;
            Endereco = endereco;
            Email = email;

            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(0,Total,"Pagamento.Total","O total não pode ser 0")
                .IsGreaterOrEqualsThan(Total,TotalPago,"pagamento.TotalPago","O valor é menor que o pagamento total"));
        }
    }
}