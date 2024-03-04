namespace Balta.ContextoConteudo
{
    public class Conteudo
    {
        public Conteudo(Parametros) //metodo construtor
        {
            Id = Guid.NewGuid();
        }
        //concentrar os itens que são comuns entre as classes aqui, para a herança.
       
        //propriedade do tipo Guid que é inicializada com um novo identificador global único (Guid.NewGuid())
        //no construtor. Cada instância de Conteudo terá um ID único.
        public Guid Id { get; set; } 

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}