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
        
    }

    public class Modulo
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

    public class Aula
    {
        public int Ordem { get; set; }

        public string Titulo { get; set; }
    }
}