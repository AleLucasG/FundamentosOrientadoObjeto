namespace Balta.ContextoConteudo
{
    public class Conteudo
    {
        public Conteudo(Parametros) //metodo construtor
        {
            Id = Guid.NewGuid();
        }
        //concentrar os itens que são comuns entre as classes aqui, para a herança.
        //propriedades/atributos
        public Guid Id { get; set; } // O struct Guid representa um identificador único global

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}