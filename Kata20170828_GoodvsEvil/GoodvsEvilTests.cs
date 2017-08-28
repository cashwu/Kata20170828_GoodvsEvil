using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170828_GoodvsEvil
{
    [TestClass]
    public class GoodvsEvilTests
    {
        [TestMethod]
        public void input_good_1_and_evil_1_should_return_no_victor()
        {
            GoodvsEvilShouldBeNoVictor("1 0 0 0 0 0", "1 0 0 0 0 0 0");
        }

        private static void GoodvsEvilShouldBeNoVictor(string good, string evil)
        {
            var actual = new Kata().GoodVsEvil(good, evil);
            Assert.AreEqual("Battle Result: No victor on this battle field", actual);
        }
    }

    public class Kata
    {
        public string GoodVsEvil(string good, string evil)
        {
            return "Battle Result: No victor on this battle field";
        }
    }
}
