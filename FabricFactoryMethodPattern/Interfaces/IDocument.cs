using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern
{
    public interface IDocument
    {
        void Open();
        void Save();
        void SaveAs();
        void Print();
        void Close();
    }
}
