using Balta.ContextoCompartilhado;

namespace Balta.ContextoAssinatura
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }

        public DateTime? DataFinal { get; set; }

        public bool EstaInativo => DataFinal? <= DateTime.Now;
    }
}