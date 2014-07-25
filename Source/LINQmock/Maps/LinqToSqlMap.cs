// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using LinqMock.Operations;

namespace LinqMock.Maps
{
    public sealed class LinqToSqlMap : BaseLinqMap
    {
        private LinqToSqlMap()
        {
            Add("SqlMethods.Like",
                (Func<string, string, bool>)StringOperations.SqlLike,
                (Func<string, string, char, bool>)StringOperations.SqlLike);

            Add("SqlMethods.DateDiffYear",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffYear,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffYear,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffYear,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffYear);

            Add("SqlMethods.DateDiffMonth",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffYear,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffYear,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffYear,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffYear);

            Add("SqlMethods.DateDiffDay",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffDay,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffDay,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffDay,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffDay);

            Add("SqlMethods.DateDiffHour",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffHour,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffHour,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffHour,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffHour);

            Add("SqlMethods.DateDiffMinute",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffMinute,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffMinute,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffMinute,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffMinute);

            Add("SqlMethods.DateDiffSecond",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffSecond,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffSecond,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffSecond,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffSecond);

            Add("SqlMethods.DateDiffMillisecond",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffMillisecond,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffMillisecond,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffMillisecond,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffMillisecond);

            Add("SqlMethods.DateDiffMicrosecond",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffMicrosecond,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffMicrosecond,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffMicrosecond,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffMicrosecond);

            Add("SqlMethods.DateDiffNanosecond",
                (Func<DateTime, DateTime, int>)DateTimeOperations.DateDiffNanosecond,
                (Func<DateTime?, DateTime?, int?>)DateTimeOperations.DateDiffNanosecond,
                (Func<DateTimeOffset, DateTimeOffset, int>)DateTimeOffsetOperations.DateDiffNanosecond,
                (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateTimeOffsetOperations.DateDiffNanosecond);
        }

        public static readonly LinqToSqlMap Instance = new LinqToSqlMap();
    }
}