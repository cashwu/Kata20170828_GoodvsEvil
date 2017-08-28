using System;
using System.Linq;
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

        [TestMethod]
        public void input_good_1_1_1_and_evil_1_1_1_should_return_good_triumph()
        {
            GoodvsEvilShouldBeGoodTriumph("1 1 1 0 0 0", "1 1 1 0 0 0 0");
        }

        private static void GoodvsEvilShouldBeNoVictor(string good, string evil)
        {
            var actual = new Kata().GoodVsEvil(good, evil);
            Assert.AreEqual("Battle Result: No victor on this battle field", actual);
        }

        private static void GoodvsEvilShouldBeGoodTriumph(string good, string evil)
        {
            var actual = new Kata().GoodVsEvil(good, evil);
            Assert.AreEqual("Battle Result: Good triumphs over Evil", actual);
        }
    }

    public class Kata
    {
        public string GoodVsEvil(string good, string evil)
        {
            var goodPeopleWorth = new[] { 1, 2, 3, 3, 4, 10 };
            var evilPeopleWorth = new[] { 1, 2, 2, 2, 3, 5, 10 };

            var goodWorth = good.Split(' ').Select((a, i) => goodPeopleWorth[i] * int.Parse(a)).Sum();
            var evilWorth = evil.Split(' ').Select((a, i) => evilPeopleWorth[i] * int.Parse(a)).Sum();

            if (goodWorth > evilWorth)
            {
                return "Battle Result: Good triumphs over Evil";
            }

            return "Battle Result: No victor on this battle field";
        }
    }
}
