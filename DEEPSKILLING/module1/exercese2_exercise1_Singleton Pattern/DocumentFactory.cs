using System;
using System.Collections.Generic;
using System.Text;

namespace CognizantDN5.DesignPatterns
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
