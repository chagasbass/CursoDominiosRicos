using Dominio.ObjetosDeValor;
using System;

namespace Dominio.Entidades
{
    public class PayPalPagamento:Pagamento
    {
        public string CodigoTransacao { get; private set; }

        public PayPalPagamento(string codigoTransacao,
            DateTime dataPagamento,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            string pagador,
            Documento documento,
            Endereco endereco,
            Email email) : base(dataPagamento,
                dataExpiracao,total,
                totalPago,pagador,
                documento,
                endereco,
                email)
        {
            CodigoTransacao = codigoTransacao;
        }
    }
}