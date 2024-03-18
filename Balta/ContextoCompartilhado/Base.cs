using Balta.ContextoNotificacao;

namespace Balta.ContextoCompartilhado
{
    public abstract class Base : Notificavel
    {

        public Base()
        {
             Id = Guid.NewGuid();
        }
        public Guid Id { get; set; } 
    }

}