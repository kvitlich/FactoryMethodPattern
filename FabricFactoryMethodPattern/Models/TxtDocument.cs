using System;
using System.Collections.Generic;
using System.Text;

namespace FabricFactoryMethodPattern.Models
{
    public class TxtDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Close");
        }

        public void Open()
        {
            Console.WriteLine("Open");

        }

        public void Print()
        {
            Console.WriteLine("Print");

        }

        public void Save()
        {
            Console.WriteLine("Save");

        }

        public void SaveAs()
        {
            Console.WriteLine("SaveAs");

        }
    }
}
