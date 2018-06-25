using System;
using System.IO;

namespace FileReading
{
    public class ReadXmlFile
        : IFileReading
    {
        public bool IsMatch(string filePath)
        {
            return Path.GetExtension(filePath).Equals(".xml", StringComparison.CurrentCultureIgnoreCase);
        }

        public string Read(string filePath)
        {
            return "Xml file reading....";
        }
    }
}
