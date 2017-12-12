using Compartilhados.Entidades;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class Assinatura:Entidade
    {
        private IList<Pagamento> _pagamentos;
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public DateTime? DataExpiracao { get; private set; }
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get { return _pagamentos.ToArray(); } }
      
        public Assinatura(DateTime? dataExpiracao)
        {
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            DataExpiracao = dataExpiracao;
            Ativo = true;
            _pagamentos = new List<Pagamento>();
        }

        public void InserirPagamento(Pagamento pagamento)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, pagamento.DataPagamento, "Data pagamento", "A data do pagamento deve ser futura"));

            _pagamentos.Add(pagamento);
        }
        
        public void TornarAssinaturaAtiva()
        {
            Ativo = true;
            DataAtualizacao = DateTime.Now;
        }

        public void TornarAssinaturaInativa()
        {
            Ativo = false;
            DataAtualizacao = DateTime.Now;
        }
    }
}