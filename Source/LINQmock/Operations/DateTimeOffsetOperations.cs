// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;

namespace LinqMock.Operations
{
    public static class DateTimeOffsetOperations
    {
        public static int DateDiffYear(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffYear(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffMonth(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffMonth(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffDay(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffDay(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffHour(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffHour(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffMinute(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffMinute(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffSecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffSecond(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffMillisecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffMillisecond(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffMicrosecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffMicrosecond(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int DateDiffNanosecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return DateTimeOperations.DateDiffNanosecond(startDate.UtcDateTime, endDate.UtcDateTime);
        }

        public static int? DateDiffYear(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffYear(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffMonth(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMonth(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffDay(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffDay(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffHour(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffHour(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffMinute(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMinute(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffSecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffSecond(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffMillisecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMillisecond(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffMicrosecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMicrosecond(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }

        public static int? DateDiffNanosecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffNanosecond(startDate.Value.UtcDateTime, endDate.Value.UtcDateTime);
        }
    }
}