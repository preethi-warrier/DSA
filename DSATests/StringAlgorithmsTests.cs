using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Tests
{
    //AAA
    //Arrange
    //Act
    //Assert
    [TestClass()]
    public class StringAlgorithmsTests
    {
        [TestMethod()]
        public void IsCharAtEvenIndexTest_PositiveCase()
        {
            var stringInput = "Rolando";
            var actual = StringAlgorithms.IsCharAtEvenIndex(stringInput, 'o');
            Assert.IsTrue(actual);
            stringInput = "way2222sms55";
            actual = StringAlgorithms.IsCharAtEvenIndex(stringInput, '2');
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsCharAtEvenIndexTest_NegativeCase()
        {
            var stringInput = "Bangalore";
            var actual = StringAlgorithms.IsCharAtEvenIndex(stringInput, 'g');
            Assert.IsFalse(actual);
            stringInput = "way2222sms55";
            actual = StringAlgorithms.IsCharAtEvenIndex(stringInput, 's');
            Assert.IsFalse(actual);
            stringInput = null;
            Assert.IsFalse(StringAlgorithms.IsCharAtEvenIndex(stringInput, 'x'));
            stringInput = "Chicago";
            Assert.IsFalse(StringAlgorithms.IsCharAtEvenIndex(stringInput, 'x'));

        }

        [TestMethod()]
        public void ReverseStringTest()
        {
            var input = "Reverse";
            var expected = new string(input.Reverse().ToArray());
            var actual = StringAlgorithms.ReverseString(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReverseStringUsingStringBuilderTest()
        {
            var input = "Reverse";
            var expected = new string(input.Reverse().ToArray());
            var actual = StringAlgorithms.ReverseStringUsingStringBuilder(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReverseSentenceTest()
        {
            var input = "This is a long sentence";
            var expected = "sihT si a gnol ecnetnes";
            var actual = StringAlgorithms.ReverseSentence(input);
            Assert.AreEqual(expected, actual);

            input = null;
            Assert.IsNull(StringAlgorithms.ReverseSentence(input));

            input = "";
            Assert.AreEqual(input, StringAlgorithms.ReverseSentence(input));

        }

        [TestMethod()]
        public void FindCamelCaseWordsTest()
        {
            var input = "camelCaseString";
            var actual = StringAlgorithms.FindCamelCaseWords(input);
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void MinimumNumberTest()
        {
            var input = "passWord";
            var actual = StringAlgorithms.MinimumNumber(8, input);
            Assert.AreEqual<int>(2, actual);

            input = null;
            Assert.AreEqual(0, StringAlgorithms.MinimumNumber(2, input));
        }

        [TestMethod()]
        public void AnagramTest()
        {
            var input = "aaabbb";
            var actual = StringAlgorithms.Anagram(input);
            Assert.AreEqual(3, actual);
        }
    }
}