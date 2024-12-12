using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    [TestFixture]
    public class StringProcessorTests
    {
        private StringProcessor _stringProcessor;

        [SetUp]
        public void SetUp()
        {
            _stringProcessor = new StringProcessor();
        }

        [Test]
        public void GetStringLength_ShouldReturnCorrectLength_WhenStringIsNotNull()
        {
            string input = "Hello";

            int result = _stringProcessor.GetStringLength(input);

            Assert.Equals(5, result);
        }
    }
}

