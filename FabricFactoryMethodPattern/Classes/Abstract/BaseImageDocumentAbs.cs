using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern.Classes.Abstract
{
    public abstract class BaseImageDocumentAbs
    {
        public abstract IDocument CreateImageDocument();
    }
}
