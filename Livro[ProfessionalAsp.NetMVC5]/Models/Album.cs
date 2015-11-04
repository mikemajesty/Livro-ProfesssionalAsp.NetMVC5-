namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public class Album
    {
        public int AlbumId {get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Artist Artist { get; internal set; }
        public Genre Genre { get; internal set; }
    }
}
