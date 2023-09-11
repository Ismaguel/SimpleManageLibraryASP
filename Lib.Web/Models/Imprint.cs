using System.Collections.ObjectModel;

namespace Lib.Web.Models
{
    public class Imprint:BaseModel
    {

        #region Fiels
        private DateTime _imprintDate = DateTime.Now;
        private DateTime remiseDate;
        private bool remisOuPas;
        private Imprinter _emprinteur = new Imprinter();
        private Book _book;
        #endregion
        #region Properties

        public DateTime ImprintDate
        {
            get { return _imprintDate; }
            set { _imprintDate = value; }
        }
        public DateTime RemiseDate
        {
            get { return remiseDate; }
            set { remiseDate = value; }
        }

        public bool RemisOuPas
        {
            get { return remisOuPas; }
            set { remisOuPas = value; }
        }

        public Imprinter Emprinteur
        {
            get { return _emprinteur; }
            set
            {
                _emprinteur = value;

            }
        }
        public Book Book
        {
            get { return _book; }
            set
            {
                _book = value;
                if (Book.Exemplaire != 0)
                    Book.Exemplaire--;
                else
                    if (Book.Exemplaire == 0)
                    return;
                //MessageBox.Show("Vous n'avez plus ce type de livre disponible");
            }
        }
        private  ObservableCollection<Book> books = new ObservableCollection<Book>();

        public  ObservableCollection<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        private  ObservableCollection<Imprinter> imprinters = new ObservableCollection<Imprinter>();

        public ObservableCollection<Imprinter> Imprinters
        {
            get { return imprinters; }
            set { imprinters = value; }
        }

        #endregion
    }
}
