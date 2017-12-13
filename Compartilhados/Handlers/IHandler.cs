using Compartilhados.Comandos;

namespace Compartilhados.Handlers
{
    public interface IHandler<T> where T:IComando
    {
        IComandoResultado Handle(T comando);
    }
}
