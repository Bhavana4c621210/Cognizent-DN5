using System;
using System.Collections.Generic;
using System.Text;

namespace CognizantDN5.DesignPatterns
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Opened");
        }
    }
}
