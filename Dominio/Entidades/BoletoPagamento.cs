using Dominio.ObjetosDeValor;
using System;

namespace Dominio.Entidades
{
    public  class BoletoPagamento:Pagamento
    {
        public BoletoPagamento(string codigoDeBarra, string numeroBoleto,
            DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago, string pagador,Documento documento,Endereco endereco,Email email)
            : base(dataPagamento,
                dataExpiracao, total,
                totalPago, pagador,
                documento,
                endereco,
                email)
        {
            CodigoDeBarra = codigoDeBarra;
            NumeroBoleto = numeroBoleto;
        }

        public string CodigoDeBarra { get; private set; }
        public string NumeroBoleto { get; private set; }
    }
}