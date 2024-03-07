namespace Balta.ContextoConteudo
{
    //classe pai
    public class Conteudo
    {
        public Conteudo() //metodo construtor
        {
            Id = Guid.NewGuid();
        }
        
       
        //propriedade do tipo Guid que é inicializada com um novo identificador global único (Guid.NewGuid())
        //no construtor Cada instância de Conteudo terá um ID único.
        public Guid Id { get; set; } 

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}