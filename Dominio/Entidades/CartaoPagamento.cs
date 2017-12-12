using Dominio.ObjetosDeValor;
using System;

namespace Dominio.Entidades
{
    public class CartaoPagamento:Pagamento
    {
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string UltimaTransacao { get; private set; }
     

        public CartaoPagamento(string nomeCartao, string numeroCartao, string ultimaTransacao,
            DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago,
            string pagador, Documento documento, Endereco endereco, Email email)
            : base(dataPagamento,
                dataExpiracao, total,
                totalPago, pagador,
                documento,
                endereco,
                email)
        {
            NomeCartao = nomeCartao;
            NumeroCartao = numeroCartao;
            UltimaTransacao = ultimaTransacao;
        }
    }
}