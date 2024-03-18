using Balta.ContextoCompartilhado;

namespace Balta.ContextoConteudo
{
    //classe pai
    public class Conteudo : Base
    {
        public Conteudo(string titulo, string url) //metodo construtor
        {
            Titulo = titulo;
            Url = url;
        }
       

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}