namespace AW1.Interfaces.Model
{
    public interface ICommentable
    {
        string Comment { get; set; }
        void ClearComment();
    }
}
