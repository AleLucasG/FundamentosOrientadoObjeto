namespace Balta.ContextoConteudo
{
    //classe pai
    public class Conteudo
    {
        public Conteudo(string titulo, string url) //metodo construtor
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Url = url;
        }
        
       
        //propriedade do tipo Guid que é inicializada com um novo identificador global único (Guid.NewGuid())
        //no construtor Cada instância de Conteudo terá um ID único.
        public Guid Id { get; set; } 

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}