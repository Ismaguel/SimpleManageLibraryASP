namespace Lib.Web.Models
{
    public class Library:BaseModel
    {
        public List<Book> ListBooks { get; set; }
        public List<Imprinter> ListImprinters { get; set;}
        List<Imprint> ListImprints { get; set; }
    }
}
