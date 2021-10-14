
using System;
using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestFileData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVersion1()
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            string transformed = assemblyInformation.Version(new string[] { "-v7", "" });
            Assert.IsNotNull(transformed);
        }

        [TestMethod]
        public void TestVersion2()
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            string transformed = assemblyInformation.Version(new string[] { "", "" });
            Assert.IsNotNull(transformed);
        }

        [TestMethod]
        public void TestVersion3()
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            string transformed = assemblyInformation.Version(new string[] { "-v" });
            Assert.IsNotNull(transformed);
        }

        [TestMethod]
        public void TestSize1()
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            int transformed = assemblyInformation.Size("-s");
            Assert.AreNotEqual(0, transformed);
        }

        [TestMethod]
        public void TestSize2()
        {
            AssemblyInformation assemblyInformation = new AssemblyInformation();
            int transformed = assemblyInformation.Size("-sg");
            Assert.AreNotEqual(0, transformed);
        }
    }
}
