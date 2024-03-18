using Balta.ContextoCompartilhado;

namespace Balta.ContextoConteudo
{
    public class Modulo : Base
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }

        public int Ordem { get; set; } //ordem dos modulos. Ex.: 1,2,3

        public string Titulo { get; set; }

        // aulas do modulo
        public IList<Aula> Aulas { get; set; } // aulas do modulo
    }
    
}