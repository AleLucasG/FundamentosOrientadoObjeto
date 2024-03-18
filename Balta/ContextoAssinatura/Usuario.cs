using Balta.ContextoCompartilhado;

namespace Balta.ContextoAssinatura
{
    public class Usuario : Base
    {
        // informações para autenticação de appp
        public string NomeUsuario { get; set; }

        public string Senha { get; set; }
    }
    
}