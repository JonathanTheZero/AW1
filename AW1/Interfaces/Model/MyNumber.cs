namespace AW1.Interfaces.Model
{
    public class MyNumber : ICommentable
    {
        public string Comment { get; set; }

        public bool Flag { get; set; }

        public void ClearComment()
        {
            Comment = string.Empty;
        }

        public void ClearFlag()
        {
            Flag = false;
        }

        public int Number { get; set; }

        public MyNumber(int number)
        {
            Number = number;
        }
    }
}
