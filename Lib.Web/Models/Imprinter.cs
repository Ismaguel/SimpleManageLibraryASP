using System.Collections.ObjectModel;

namespace Lib.Web.Models
{
    public class Imprinter:BaseModel
    {
        #region Fiels
        private string displayname;
        private string lastName;
        private string firstName;
        private DateTime datedeNaissance;
        private string profil;

        public int ImprintId { get; set; }
        public Imprint Imprint { get; set; }
        public Library Library { get; set; }
        public List<Book> ListBoookImprinter { get; set; }
        #endregion

        #region Properties

        public string Displayname
        {
            get { return displayname; }
            set { displayname = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Profil
        {
            get { return profil; }
            set { profil = value; }
        }
        public DateTime DatedeNaissance
        {
            get { return datedeNaissance; }
            set { datedeNaissance = value; }
        }
        //private ObservableCollection<Imprint> imprints;

        //public ObservableCollection<Imprint> Imprints
        //{
        //    get { return imprints; }
        //    set { imprints = value; }
        //}
        #endregion
    }
}
