namespace Balta.ContextoNotificacao
{
    public sealed class Notificacao
    {
        public Notificacao()
        {

        }

        public Notificacao(string propriedade, string mensagemErro)
        {
            Propriedade = propriedade;
            MensagemErro = mensagemErro;
        }

        public string Propriedade { get; set; }

        public string MensagemErro { get; set; }

      
    }
}