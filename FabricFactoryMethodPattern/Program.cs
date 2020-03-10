using FabricFactoryMethodPattern.Models;
using FabricFactoryMethodPattern.ModelsCreator;
using System;
using System.Numerics;
using System.Text.Json;

namespace FabricFactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonCreator creatorJson = new JsonCreator();
            PngCreator creatorPng = new PngCreator();
            TxtCreator creatorTxt = new TxtCreator();

            Console.WriteLine("Создание файлов с помощью фабрик: ");
            IDocument txt_1 = creatorTxt.CreateDocument();

            IDocument json_1 = creatorTxt.CreateDocument();

            IImageDocument png_1 = creatorPng.CreateImageDocument();

            Console.ReadKey();
        }
    }
}
