using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileReading.Tests
{
    [TestClass]
    public class FileReadingTest
    {
        IFileReading fileReading;

        [TestInitialize]
        public void Initialize()
        {
            fileReading = DependencyResolver.Resolve<IFileReading>();
        }

        [TestMethod]
        public void Read_TextFile_Test()
        {
            // Arrange
            var filePath = "test.txt";
            // Act
            var readTextFileResult = fileReading.Read(filePath);
            // Assert
            Assert.AreEqual("Text file reading....", readTextFileResult);
        }
    }
}
