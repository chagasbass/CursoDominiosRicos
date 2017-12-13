using Compartilhados.Comandos;
using Compartilhados.Handlers;
using Dominio.Comandos;
using Dominio.Entidades;
using Dominio.ObjetosDeValor;
using Dominio.Repositorios;
using Flunt.Notifications;

namespace Dominio.Handlers
{
    public class EstudanteHandler : Notifiable, IHandler<CriarEstudanteComando>
    {
        private readonly IEstudanteRepositorio _repositorio;

        public EstudanteHandler(IEstudanteRepositorio repo)
        {
            _repositorio = repo;
        }

        public IComandoResultado Handle(CriarEstudanteComando comando)
        {
            //fail fast

            comando.ValidarComando();
            if (comando.Invalid)
            {
                AddNotifications(comando);
                return new ComandoResultado(false, "não foi possível realizar seu cadastro");
            }

            //verificar se user existe
            if(_repositorio.ListarPorEmail(comando.Email) == null)
                AddNotifications(comando);

            //gerar as vos
            var nome = new Nome(comando.PrimeiroNome, comando.Sobrenome);
            var email = new Email(comando.Email);
            var doc = new Documento(comando.Numero, Dominio.Enums.ETipoDocumento.CPF);
            var endereco = new Endereco("A", "21", "Niteroi", "23130110", "Fonseca", "Rio De Janeiro");

            //gerar a entidade
            var estudante = new Estudante(nome, doc, email);

            //validar os dados
            AddNotifications(estudante);

            //cadastrar estudante
            _repositorio.CriarEstudante(estudante);

            //retornar comando de resultado.
            return new ComandoResultado(true, "Cadastro efetuado com sucesso");

        }
    }
}
