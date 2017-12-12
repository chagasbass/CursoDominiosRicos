using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Compartilhados.Entidades
{
    public abstract class Entidade:Notifiable,IValidatable
    {
        public Guid Id { get; private set; }

        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public virtual void Validate()
        {
            throw new NotImplementedException();
        }
    }
}