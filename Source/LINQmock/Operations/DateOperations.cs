using System;

namespace LinqMock.Operations
{
    public static class DateOperations
    {
        public static int DateDiffDay(DateTime startDate, DateTime endDate)
        {            
            return (int)startDate.Subtract(endDate).TotalDays;
        }

        public static int? DateDiffDay(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffDay(startDate.Value, endDate.Value);
        }

        public static int DateDiffDay(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return (int)startDate.Subtract(endDate).TotalDays;
        }

        public static int? DateDiffDay(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffDay(startDate.Value, endDate.Value);
        }

        public static int DateDiffHour(DateTime startDate, DateTime endDate)
        {
            return (int)startDate.Subtract(endDate).TotalHours;
        }

        public static int? DateDiffHour(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffHour(startDate.Value, endDate.Value);
        }

        public static int DateDiffHour(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return (int)startDate.Subtract(endDate).TotalHours;
        }

        public static int? DateDiffHour(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffHour(startDate.Value, endDate.Value);
        }

        public static int DateDiffMillisecond(DateTime startDate, DateTime endDate)
        {
            return (int)startDate.Subtract(endDate).TotalMilliseconds;
        }

        public static int? DateDiffMillisecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMillisecond(startDate.Value, endDate.Value);
        }

        public static int DateDiffMillisecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return (int)startDate.Subtract(endDate).TotalMilliseconds;
        }

        public static int? DateDiffMillisecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMillisecond(startDate.Value, endDate.Value);
        }

        public static int DateDiffMinute(DateTime startDate, DateTime endDate)
        {
            return (int)startDate.Subtract(endDate).TotalMinutes;
        }

        public static int? DateDiffMinute(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMinute(startDate.Value, endDate.Value);
        }

        public static int DateDiffMinute(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return (int)startDate.Subtract(endDate).TotalMinutes;
        }

        public static int? DateDiffMinute(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMinute(startDate.Value, endDate.Value);
        }

        public static int DateDiffSecond(DateTime startDate, DateTime endDate)
        {
            return (int)startDate.Subtract(endDate).TotalSeconds;
        }

        public static int? DateDiffSecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffSecond(startDate.Value, endDate.Value);
        }

        public static int DateDiffSecond(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return (int)startDate.Subtract(endDate).TotalSeconds;
        }

        public static int? DateDiffSecond(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffSecond(startDate.Value, endDate.Value);
        }
    }
}