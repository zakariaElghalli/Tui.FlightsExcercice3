namespace FileReading
{
    public interface IFileReading
    {
        bool IsMatch(string filePath);
        string Read(string filePath);       
    }
}
