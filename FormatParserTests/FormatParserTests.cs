using FormatParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FormatParserTests
{
    [TestClass]
    public class FormatParserTests
    {
        [TestMethod]
        public void ProcessFile()
        {
            string[] files = new string[] {"test.JsOn", "test.html", "test.TXT", "test" };

            FileProcessor fp = new FileProcessor();

            foreach (string filename in files)
            {
                fp.ProcessFile(filename);
            }

            //Assert.AreEqual()
            // Как написать тесты, если все выводится в консоль?
        }
    }
}
