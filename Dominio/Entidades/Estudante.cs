using Compartilhados.Entidades;
using Dominio.ObjetosDeValor;
using Flunt.Validations;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class Estudante:Entidade
    {

        public Nome Nome { get; set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public string Endereco { get; private set; }

        private IList<Assinatura> _assinaturas;
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }

        public Estudante(Nome nome ,Documento documento, Email email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();

        }

        public  override void Validate()
        {
            AddNotifications(Nome, Email, Documento);
        }

        public void InserirAssinatura(Assinatura assinatura)
        {
            var temAssinatura = false;

            foreach (var item in Assinaturas)
                if (item.Ativo)
                    temAssinatura = true;

            _assinaturas.Add(assinatura);

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(temAssinatura,"Assinatura","O aluno já tem uma assinatura ativa"));

        }
    }
}