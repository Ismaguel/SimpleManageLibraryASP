namespace Lib.Web.Models
{
    public class BaseModel
    {
        #region Fields
        private int _id;
        private DateTime _createAt = DateTime.Now.ToUniversalTime();
        private DateTime? _deleteAt;
        private DateTime? _updateAt;
        //private Statut _statut;
        #endregion

        #region Properties

        //[RegularExpression(@"^((\d)*(\D)(.)*)$", ErrorMessage = "invalid input format")]
        public virtual string? DisplayName { get; set; }

        public  int Id { get => _id; set => _id = value; }
        public virtual DateTime CreateAt { get => _createAt; set => _createAt = value; }
        public virtual DateTime? DeleteAt { get => _deleteAt; set => _deleteAt = value; }
        public virtual DateTime? UpdateAt { get => _updateAt; set => _updateAt = value; }
        //public virtual Statut Statut { get => _statut; set => _statut = value; }
        #endregion

        #region Methode overrided
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is BaseModel)
                {
                    if (
                    ((BaseModel)obj).Id == Id ||
                    (!string.IsNullOrEmpty(DisplayName) && ((BaseModel)obj).DisplayName == DisplayName))
                        return true;
                }
                return base.Equals(obj);
            }
            return false;
        }
        #endregion
    }
}
