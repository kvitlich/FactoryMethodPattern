using FabricFactoryMethodPattern.Classes.Abstract;
using FabricFactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern.ModelsCreator
{
    public class TxtCreator : BaseDocumentAbs
    {
        public override IDocument CreateDocument()
        {
            return new TxtDocument();
        }
    }
}
