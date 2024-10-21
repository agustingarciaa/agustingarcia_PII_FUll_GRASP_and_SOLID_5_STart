using System;

namespace Full_GRASP_And_SOLID
{
    
    public class ConsolePrinter : IPrinter
    {
        public void Print(ITextPrint print)
        {
            Console.WriteLine(print.GetTextToPrint());
        }
    }
}