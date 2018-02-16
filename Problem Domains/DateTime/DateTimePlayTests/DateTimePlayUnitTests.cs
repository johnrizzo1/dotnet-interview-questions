using DateTimePlay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DateTimePlayTests
{
    [TestClass]
    public class DateTimePlayUnitTests
    {
        [ClassInitialize]
        public static void PreTestClass(TestContext context)
        {
            DateRangeTestData = new List<IDateRange>
            {
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now },
                new DateRange { Start = DateTime.Now, End = DateTime.Now }
            };
        }

        [TestMethod]
        public void TestDayCounting()
        {
            // start = end
            IDateRange range = new DateRange { Start = DateTime.Now, End = DateTime.Now };
            Assert.AreEqual(0, range.DayCount());

            // end before start
            range = new DateRange { Start = DateTime.Now, End = DateTime.Now.AddDays(-1) };
            Assert.AreEqual(0, range.DayCount());

            // end after start
            range = new DateRange { Start = DateTime.Now, End = DateTime.Now.AddDays(5) };
            Assert.AreEqual(5, range.DayCount());

            //throw new System.NotImplementedException();
        }

        [TestMethod]
        public void TestBusinessDayCounting()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void TestIfDatesOverlap()
        {
            /*
             * There are 13 possibilities
             *  - ACE THE PROGRAMMING INTERVIEW - 160 QUESTIONS AND ANSWERS FOR SUCCESS,
             *      Pages 151-155
             *      Edward Guiness
             */
            //Assert.IsTrue(rangeTwo.Overlaps(rangeOne));

            throw new System.NotImplementedException();
        }

        private static IList<IDateRange> DateRangeTestData { get; set; }
    }
}