namespace AW1.Interfaces.Model
{
    public class Boxed<T> : IFlagable, ICommentable
    {
        public string Comment { get; set; }
        public bool Flag { get; set; }
        public T Value { get; set; }

        public void ClearComment()
        {
            Comment = string.Empty;
        }

        public void ClearFlag()
        {
            Flag = false;
        }

        public Boxed(T value)
        {
            Value = value;
        }
    }
}
