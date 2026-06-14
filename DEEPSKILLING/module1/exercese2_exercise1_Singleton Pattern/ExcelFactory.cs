using System;
using System.Collections.Generic;
using System.Text;

namespace CognizantDN5.DesignPatterns
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}


