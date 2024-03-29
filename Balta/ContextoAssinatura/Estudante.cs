using System.Security.Cryptography.X509Certificates;
using Balta.ContextoCompartilhado;

namespace Balta.ContextoAssinatura
{
    // usuario e separado de aluno, pois nem sempre um usuario é um aluno
    public class Estudante : Base
    {   
        public string Nome { get; set; }

        public string Email { get; set; }

        // porém um aluno sempre sera um usuario
        public Usuario Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set; }

        public bool EPrimium => Assinatura.Any(x=> !x.EstaInativo);

    }
}