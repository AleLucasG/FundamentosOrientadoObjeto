using Balta.ContextoConteudo.Enumeradores;

namespace Balta.ContextoConteudo
{
     public class Aula
    {
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public int DuracaoAulaEmMinutos { get; set; }

        public ENivelConteudo Level { get; set; }
    }
}