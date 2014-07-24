// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using LinqMock.Operations;

namespace LinqMock.Maps
{
    public sealed class LinqToSqlMap : BaseLinqMap
    {
        private LinqToSqlMap()
        {
            Add("SqlMethods.Like", (Func<string, string, bool>)StringOperations.SqlLike);
            Add("SqlMethods.Like", (Func<string, string, char, bool>)StringOperations.SqlLike);

            Add("SqlMethods.DateDiffDay", (Func<DateTime, DateTime, int>)DateOperations.DateDiffDay);
            Add("SqlMethods.DateDiffDay", (Func<DateTime?, DateTime?, int?>)DateOperations.DateDiffDay);
            Add("SqlMethods.DateDiffDay", (Func<DateTimeOffset, DateTimeOffset, int>)DateOperations.DateDiffDay);
            Add("SqlMethods.DateDiffDay", (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateOperations.DateDiffDay);

            Add("SqlMethods.DateDiffHour", (Func<DateTime, DateTime, int>)DateOperations.DateDiffHour);
            Add("SqlMethods.DateDiffHour", (Func<DateTime?, DateTime?, int?>)DateOperations.DateDiffHour);
            Add("SqlMethods.DateDiffHour", (Func<DateTimeOffset, DateTimeOffset, int>)DateOperations.DateDiffHour);
            Add("SqlMethods.DateDiffHour", (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateOperations.DateDiffHour);

            Add("SqlMethods.DateDiffMinute", (Func<DateTime, DateTime, int>)DateOperations.DateDiffMinute);
            Add("SqlMethods.DateDiffMinute", (Func<DateTime?, DateTime?, int?>)DateOperations.DateDiffMinute);
            Add("SqlMethods.DateDiffMinute", (Func<DateTimeOffset, DateTimeOffset, int>)DateOperations.DateDiffMinute);
            Add("SqlMethods.DateDiffMinute", (Func<DateTimeOffset?, DateTimeOffset?, int?>)DateOperations.DateDiffMinute);
        }

        public static readonly LinqToSqlMap Instance = new LinqToSqlMap();
    }
}