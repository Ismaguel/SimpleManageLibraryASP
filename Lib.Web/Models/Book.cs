using System.ComponentModel.DataAnnotations;

namespace Lib.Web.Models
{
    public class Book:BaseModel
    {
        #region Fiels
       
        private string? title;
        private string? type;
        private string? author;
        private int exemplaire;
        // Clé étrangère vers l'Imprint associée à ce Book
        public int ImprintId { get; set; }
        public Imprint Imprint { get; set; }
        #endregion
        #region Properties

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; ; }
        }
        private string edition;

        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        private int numpage;

        public int Numpage
        {
            get { return numpage; }
            set { numpage = value; }
        }

        public int Exemplaire
        {
            get
            {
                return exemplaire;
            }
            set { exemplaire = value; }
        }

        public override string ToString()
        {
            return $"{Title} / {Type}";
        }


        #endregion
    }
}
