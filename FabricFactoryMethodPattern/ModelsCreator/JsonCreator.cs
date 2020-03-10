using FabricFactoryMethodPattern.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FabricFactoryMethodPattern.ModelsCreator
{
    public class JsonCreator : BaseDocumentAbs
    {
        public override IDocument CreateDocument()
        {
            return new JsonDocument();
        }
    }
}
