// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using LinqMock.Operations;
using System;
using Xunit;

namespace LinqMock.Tests.Operations
{
    public class DateTimeOperationsTests
    {
        private readonly DateTime firstDayOf2010 = new DateTime(2010, 01, 01);
        private readonly DateTime lastDayOf2010 = new DateTime(2010, 12, 31);
        private readonly DateTime? nullableFirstDayOf2010 = new DateTime(2010, 01, 01);

        [Fact]
        public void DiffYearForSameDateIsZero()
        {
            var actual = DateTimeOperations.DateDiffYear(firstDayOf2010, firstDayOf2010);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void DiffYearForSameYearIsZero()
        {
            var actual = DateTimeOperations.DateDiffYear(firstDayOf2010, lastDayOf2010);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void DiffYearForNextYearIsOne()
        {
            var lastDayOf2009 = firstDayOf2010.Subtract(TimeSpan.FromDays(1));

            var actual = DateTimeOperations.DateDiffYear(lastDayOf2009, firstDayOf2010);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffYearForLastYearIsOne()
        {
            var lastDayOf2009 = firstDayOf2010.Subtract(TimeSpan.FromDays(1));

            var actual = DateTimeOperations.DateDiffYear(firstDayOf2010, lastDayOf2009);

            Assert.Equal(-1, actual);
        }

        [Fact]
        public void DiffYearForExactlyFiveYearFromNowIsFive()
        {
            var wasToday = new DateTime(2014, 7, 24, 18, 58, 05);
            var fiveYearsFromNow = wasToday.AddYears(2);

            var actual = DateTimeOperations.DateDiffYear(wasToday, fiveYearsFromNow);

            Assert.Equal(2, actual);
        }

        [Fact]
        public void DiffMonthForSameDateIsZero()
        {
            var actual = DateTimeOperations.DateDiffMonth(firstDayOf2010, firstDayOf2010);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void DiffMonthCrossingSingleMonthIsOne()
        {
            var startDate = new DateTime(2014, 01, 24);
            var endDate = new DateTime(2014, 02, 01);

            // SELECT DATEDIFF(MM, '2014-01-24 ', '2014-02-01') 
            var actual = DateTimeOperations.DateDiffMonth(startDate, endDate);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffMonthCrossingYearBoundaryIsOne()
        {
            var startDate = new DateTime(2014, 12, 31);
            var endDate = new DateTime(2015, 01, 01);

            // SELECT DATEDIFF(MM, '2014-12-31 ', '2015-01-01') 
            var actual = DateTimeOperations.DateDiffMonth(startDate, endDate);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffYearForAnyNullValueIsNull()
        {
            Assert.Null(DateTimeOperations.DateDiffYear(null, null));
            Assert.Null(DateTimeOperations.DateDiffYear(null, nullableFirstDayOf2010));
            Assert.Null(DateTimeOperations.DateDiffYear(nullableFirstDayOf2010, null));
        }

        [Fact]
        public void DiffYearForSameNullableDateTimeIsZero()
        {
            var actual = DateTimeOperations.DateDiffYear(nullableFirstDayOf2010, nullableFirstDayOf2010);

            Assert.Equal(0, actual);
        }
    }
}