using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern
{
    public interface IImageDocument
    {
        void Open();
        void Save();
        void SaveAs();
        void Print();
        void Close();
    }
}
