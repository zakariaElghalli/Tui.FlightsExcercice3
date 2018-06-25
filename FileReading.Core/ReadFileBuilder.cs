using System.Collections.Generic;
using System.Linq;

namespace FileReading
{
    public class ReadFileBuilder
    {
        readonly IEnumerable<IFileReading> _filesReading;

        public ReadFileBuilder(IEnumerable<IFileReading> filesReading)
        {
            _filesReading = filesReading;
        }

        public string ReadFile(string filePath) {
           return _filesReading.FirstOrDefault(i => i.IsMatch(filePath)).Read(filePath);
        }
    }
}
