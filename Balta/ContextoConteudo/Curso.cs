using Balta.ContextoConteudo.Enumeradores;

namespace Balta.ContextoConteudo
{
    public class Curso : Conteudo
    {
        public Curso()
        {
            Modulos = new List<Modulo>();
        }

        public string Tag { get; set; }  //Tag(etiqueta) do curdo, ex.: 2802

        public IList<Modulo> Modulos { get; set; }

        public int DuracaoAulaEmMinutos { get; set; }

        public ENivelConteudo Nivel { get; set; }
        
    }

   
}