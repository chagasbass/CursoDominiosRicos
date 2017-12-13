using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Repositorios
{
    public interface IEstudanteRepositorio
    {
        void CriarEstudante(Estudante estudante);
        void AtualizarEstudante(Estudante estudante);
        Estudante ListarPorEmail(string email);
        List<Estudante> ListarEstudantes();
    }
}
