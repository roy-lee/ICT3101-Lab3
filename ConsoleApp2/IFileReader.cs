using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
