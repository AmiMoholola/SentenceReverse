using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SentenceReverse.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void ReverseWords_SingleWord_ReturnsSameWord()
        {
            string result = Program.ReverseWords("hello");
            Assert.Equal("hello", result);
        }

        [Fact]
        public void ReverseWords_MultipleWords_ReturnsReversedOrder()
        {
            string result = Program.ReverseWords("this is a test");
            Assert.Equal("test a is this", result);
        }

        [Fact]
        public void ReverseWords_NullInput_ReturnsEmptyString()
        {
            string result = Program.ReverseWords(null);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReverseWords_EmptyInput_ReturnsEmptyString()
        {
            string result = Program.ReverseWords(string.Empty);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReadLines_InvalidInput_ReturnsEmptyList()
        {

            var input = new List<string> { "invalid1", "invalid2", "invalid3" };
            var expectedCount = 0;


            using (var stringReader = new StringReader(string.Join(Environment.NewLine, input)))
            {
                Console.SetIn(stringReader);

                List<string> lines = Program.ReadLines(expectedCount);


                Assert.Empty(lines);
            }
        }

        [Fact]
        public void ReadLines_ValidInput_ReturnsListWithCorrectNumberOfElements()
        {

            var input = new List<string> { "valid1", "valid2", "valid3" };
            var expectedCount = input.Count;

            using (var stringReader = new StringReader(string.Join(Environment.NewLine, input)))
            {
                Console.SetIn(stringReader);

                List<string> lines = Program.ReadLines(expectedCount);
                Assert.Equal(expectedCount, lines.Count);
            }

        }



        [Fact]
        public void IsValidLine_ValidInput_ReturnsTrue()
        {
            bool result = Program.IsValidLine("valid");
            Assert.True(result);
        }

        [Fact]
        public void IsValidLine_NullInput_ReturnsFalse()
        {
            bool result = Program.IsValidLine(null);
            Assert.False(result);
        }

        [Fact]
        public void IsValidLine_EmptyInput_ReturnsFalse()
        {
            bool result = Program.IsValidLine(string.Empty);
            Assert.False(result);
        }

        [Fact]
        public void IsValidLine_InputExceedsLength_ReturnsFalse()
        {
            bool result = Program.IsValidLine("12345678901234567890123456789");
            Assert.False(result);
        }
    }
}