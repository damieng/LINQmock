// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using LinqMock.Operations;
using System;
using Xunit;

namespace LinqMock.Tests.Operations
{
    public class DateTimeOffsetOperationsTests
    {
        private readonly DateTimeOffset firstDayOf2010OneHourBehind = new DateTimeOffset(new DateTime(2010, 01, 01), TimeSpan.FromHours(-1));
        private readonly DateTimeOffset firstDayOf2010 = new DateTimeOffset(new DateTime(2010, 01, 01), TimeSpan.FromHours(0));
        private readonly DateTimeOffset firstDayOf2010OneHourAhead = new DateTimeOffset(new DateTime(2010, 01, 01), TimeSpan.FromHours(+1));
        private readonly DateTimeOffset? nullableFirstDayOf2010 = new DateTimeOffset(new DateTime(2010, 01, 01), TimeSpan.FromHours(0));

        [Fact]
        public void DiffYearForSameDateIsZero()
        {
            // SELECT DATEDIFF(YYYY, '2010-01-01 00:00:00-0:00','2010-01-01 00:00:00+0:00') = 0
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010, firstDayOf2010);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void DiffYearForSameYearIsZeroIfOneBehindTimezone()
        {
            // SELECT DATEDIFF(YYYY, '2010-01-01 00:00:00-1:00','2010-01-01 00:00:00+0:00') = 0
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010OneHourBehind, firstDayOf2010);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void DiffYearForSameYearIsMinusOneIfOneAheadTimezone()
        {
            // SELECT DATEDIFF(YYYY, '2010-01-01 00:00:00-0:00','2010-01-01 00:00:00+1:00') = -1
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010, firstDayOf2010OneHourAhead);

            Assert.Equal(-1, actual);
        }

        [Fact]
        public void DiffYearForSameYearIsOneIfMinusOneAheadAndOneBehind()
        {
            // SELECT DATEDIFF(YYYY, '2010-01-01 00:00:00-1:00','2010-01-01 00:00:00+1:00') = -1
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010OneHourAhead, firstDayOf2010OneHourBehind);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffYearForSameYearIsMinusOneIfOneBehindAndOneAhead()
        {
            // SELECT DATEDIFF(YYYY, '2010-01-01 00:00:00+1:00','2010-01-01 00:00:00-1:00') = 1
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010OneHourBehind, firstDayOf2010OneHourAhead);

            Assert.Equal(-1, actual);
        }

        [Fact]
        public void DiffYearForNextYearIsOne()
        {
            var lastDayOf2009 = firstDayOf2010.Subtract(TimeSpan.FromDays(1));

            // SELECT DATEDIFF(YYYY, '2009-12-31 00:00:00','2010-01-01 00:00:00-0:00') = 1
            var actual = DateTimeOffsetOperations.DateDiffYear(lastDayOf2009, firstDayOf2010);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffYearForSameDateWithDiffTimeZonesIsOne()
        {
            var startDate = new DateTimeOffset(new DateTime(2010, 01, 01, 00, 00, 00), TimeSpan.FromHours(1));
            var endDate = new DateTimeOffset(new DateTime(2010, 01, 01, 00, 00, 00), TimeSpan.FromHours(0));

            //  SELECT DATEDIFF(YYYY, '2010-01-01 00:01:00-2:00','2010-01-01 00:00:00-1:00')
            var actual = DateTimeOffsetOperations.DateDiffYear(startDate, endDate);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void DiffYearForLastYearIsOne()
        {
            var lastDayOf2009 = firstDayOf2010.Subtract(TimeSpan.FromDays(1));

            // SELECT DATEDIFF(YYYY, '2009-12-31 00:00:00','2010-01-01 00:00:00-0:00') = 1
            var actual = DateTimeOffsetOperations.DateDiffYear(firstDayOf2010, lastDayOf2009);

            Assert.Equal(-1, actual);
        }

        [Fact]
        public void DiffYearForAnyNullValueIsNull()
        {
            Assert.Null(DateTimeOffsetOperations.DateDiffYear(null, null));
            Assert.Null(DateTimeOffsetOperations.DateDiffYear(null, nullableFirstDayOf2010));
            Assert.Null(DateTimeOffsetOperations.DateDiffYear(nullableFirstDayOf2010, null));
        }

        [Fact]
        public void DiffYearForSameNullableDateTimeOffsetIsZero()
        {
            var actual = DateTimeOffsetOperations.DateDiffYear(nullableFirstDayOf2010, nullableFirstDayOf2010);

            Assert.Equal(0, actual);
        }
    }
}