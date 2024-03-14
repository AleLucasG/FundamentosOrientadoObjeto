namespace Balta.ContextoNotificacao
{
    // classe pai (notifiable)
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes { get; set; }

        public void Add(Notificacao notificacao)
        {
             Notificacoes.Add(notificacao);
        }

        public void AddRange(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.Add(notificacoes);
        }
    }
}