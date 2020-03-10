using FabricFactoryMethodPattern.Classes.Abstract;
using FabricFactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern.ModelsCreator
{
    public class PngCreator : BaseImageDocumentAbs
    {
        public override IImageDocument CreateImageDocument()
        {
            return new PngDocument();
        }
    }
}
