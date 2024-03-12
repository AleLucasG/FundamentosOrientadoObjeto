using Balta.ContextoConteudo;

namespace Balta.ContextoConteudo
{
    public class Carreira : Conteudo
    {
        // inicializando a lista
        public Carreira(string titulo, string url)
        : base(titulo, url)
        {
            Items = new List<ItemCarreira>();
        }

        // public int Totalcursos => Itams.Count;   = Expression Body
        public IList<ItemCarreira> Items { get; set;}

        public int TotalCursos 
        { 
            get
            {
                return Items.Count;
            }
        }
        
        
    }
}