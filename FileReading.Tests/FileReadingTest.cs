using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileReading.Tests
{
    [TestClass]
    public class FileReadingTest
    {
        ReadFileBuilder readFileBuilder;

        [TestInitialize]
        public void Initialize()
        {
            readFileBuilder = DependencyResolver.Resolve<ReadFileBuilder>();
        }

        [TestMethod]
        public void Read_TextFile_Test()
        {
            // Arrange
            var filePath = "test.txt";
            // Act
            var readTextFileResult = readFileBuilder.ReadFile(filePath);
            // Assert
            Assert.AreEqual("Text file reading....", readTextFileResult);
        }
        [TestMethod]
        public void Read_XmlFile_Test()
        {
            // Arrange
            var filePath = "test.xml";
            // Act
            var readTextFileResult = readFileBuilder.ReadFile(filePath);
            // Assert
            Assert.AreEqual("Xml file reading....", readTextFileResult);
        }

    }
}
