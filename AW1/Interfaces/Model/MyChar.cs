using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Interfaces.Model
{
    public class MyChar: ICommentable, IFlagable
    {
        public string Comment { get; set; }

        public void ClearComment()
        {
            Comment = string.Empty;
        }

        public void ClearFlag()
        {
            Flag = false;
        }

        public char Char { get; set; }
        public bool Flag { get; set; }

        public MyChar(char c)
        {
            Char = c;
        }
    }
}
