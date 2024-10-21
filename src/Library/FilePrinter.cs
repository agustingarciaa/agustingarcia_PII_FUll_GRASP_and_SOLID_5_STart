using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void Print(ITextPrint print)
        {
            File.WriteAllText("print.txt", print.GetTextToPrint());
        }
    }
}