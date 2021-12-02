using AW1.Interfaces.Model;
using System;

namespace AW1.Interfaces
{
    public static class CS01
    {
        public static void TaskB()
        {
            MyNumber num = new MyNumber(42)
            {
                Comment = "Answer to the Ultimate Question of Life, The Universe, and Everything"
            };
            Console.WriteLine("Num: " + num.Number);
            Console.WriteLine("Comment: " + num.Comment);
            num.ClearComment();
            Console.WriteLine("Num: " + num.Number);
            Console.WriteLine("Comment: " + num.Comment);
        }

        public static void TaskC()
        {
            MyChar c = new MyChar('b')
            {
                Comment = "Answer to the Ultimate Question of Life, The Universe, and Everything"
            };

            Console.WriteLine("Char: " + c.Char);
            Console.WriteLine("Comment: " + c.Comment);
            c.ClearComment();
            Console.WriteLine("Char: " + c.Char);
            Console.WriteLine("Comment: " + c.Comment);
        }

        public static void TaskD()
        {
            MyNumber num = new MyNumber(42)
            {
                Comment = "Answer to the Ultimate Question of Life, The Universe, and Everything",
                Flag = true
            };
            Console.WriteLine("Num: " + num.Number);
            Console.WriteLine("Comment: " + num.Comment);
            Console.WriteLine("Flag: " +  num.Flag);
            MyChar c = new MyChar('b')
            {
                Comment = "Answer to the Ultimate Question of Life, The Universe, and Everything",
                Flag = true
            };

            Console.WriteLine("Char: " + c.Char);
            Console.WriteLine("Comment: " + c.Comment);
            Console.WriteLine("Flag: " + c.Flag);
            num.ClearComment();
            num.ClearFlag();
            c.ClearFlag();
            c.ClearComment();

            Console.WriteLine("Num: " + num.Number);
            Console.WriteLine("Comment: " + num.Comment);
            Console.WriteLine("Flag: " + num.Flag);

            Console.WriteLine("Char: " + c.Char);
            Console.WriteLine("Comment: " + c.Comment);
            Console.WriteLine("Flag: " + c.Flag);
        }
    }
}
