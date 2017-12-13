using Dominio.Entidades;
using System;
using System.Linq.Expressions;

namespace Dominio.Queries
{
    public  static class EstudanteQueries
    {
        public static Expression<Func<Estudante,bool>>ListarEstudante(string email)
        {
            return x => x.Email.Endereco == email;
        }
    }
}