using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FxMind_AnagramTest 
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("Wo!rd N3ver Cha_nges", "dr!oW r3evN seg_nahC")]
        [DataRow("Go@d d@y S#rr", "do@G y@d r#rS")]
        [DataRow("_One_ two ThrE9", "_enO_ owt ErhT9")]
        public void Reverse_ReverseAllWordsWithChars_ReverseWords(string text, string expectedText)
        { 
            string expected = expectedText;

            FxMind_Anagram.Anagram anagram = new FxMind_Anagram.Anagram();
            string actual = anagram.Reverse(text);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_StringNull_ExpectedException()
        {
            FxMind_Anagram.Anagram anagram = new FxMind_Anagram.Anagram();
            anagram.Reverse(null);
        }
    }
}
