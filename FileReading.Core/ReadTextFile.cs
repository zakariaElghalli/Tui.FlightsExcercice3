﻿using System;
using System.IO;

namespace FileReading
{
    public class ReadTextFile 
        : IFileReading
    {
        public bool IsMatch(string filePath)
        {
            return Path.GetExtension(filePath).Equals(".txt", StringComparison.CurrentCultureIgnoreCase);
        }

        public string Read(string filePath)
        {
            return "Text file reading....";
        }
    }
}
