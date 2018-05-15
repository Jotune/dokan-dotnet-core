using System;
using DokanNet;

namespace DokanNetCoreMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mirror mirror = new Mirror("D:");
                mirror.Mount("n:\\", DokanOptions.DebugMode, 5);
            }
            catch (DokanException ex)
            {
                Console.WriteLine(@"Error: " + ex.Message);
            }
        }
    }
}
