namespace Balta.ContextoNotificacao
{
    // classe pai (notifiable)
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes { get; set; }

        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AdicionarNotificacao(Notificacao notificacao)
        {
             Notificacoes.Add(notificacao);
        }

        public void AdicionarNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }

        // esse metodo vai ser valido pela quantidade de notificações que ele tiver
        public bool Invalido => Notificacoes.Any();
    }
}