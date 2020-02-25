namespace DevApp.Business.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string mesagem)
        {
            Mensagem = mesagem;
        }

        public string Mensagem { get; }
    }
}
