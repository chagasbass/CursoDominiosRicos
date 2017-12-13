namespace Compartilhados.Comandos
{
    public class ComandoResultado:IComandoResultado
    {
        public ComandoResultado(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public ComandoResultado()
        {

        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}