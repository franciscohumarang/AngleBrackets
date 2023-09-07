using AngleBrackets;
namespace AngleBracketsUnitTest
{
    using NUnit.Framework;


    namespace UnitTest
    {

        [TestFixture]
        public class AngleBracketsUnitTest
        {
            [Test]
            public void Empty_String_Test()
            {
                Assert.IsTrue(Util.MatchingTest(""));
            }

            [Test]
            public void Open_Close_Match_Braket_Test()
            {
                Assert.IsTrue(Util.MatchingTest("<>"));
            }

            [Test]
            public void Close_Open_Mismtmatch_Braket_Test()
            {
                Assert.IsFalse(Util.MatchingTest("><"));
            }

            [Test]
            public void Mismtmatching_Braket_Test()
            {
                Assert.IsFalse(Util.MatchingTest("<<>"));
            }

            [Test]
            public void Open_Close_With_Characters_Inside_Test()
            {
                Assert.True(Util.MatchingTest("<abc...xyz>"));
            }

        }
    }
}