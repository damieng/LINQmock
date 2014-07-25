// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;

namespace LinqMock.Operations
{
    public static class DateTimeOperations
    {
        private const double MilliToMicro = 1000.0;
        private const double MilliToNano = 1000000.0;

        public static int DateDiffYear(DateTime startDate, DateTime endDate)
        {
            return endDate.Year - startDate.Year;
        }

        public static int DateDiffMonth(DateTime startDate, DateTime endDate)
        {
            var years = endDate.Year - startDate.Year;
            return endDate.Month - startDate.Month + (years * 12);
        }

        public static int DateDiffDay(DateTime startDate, DateTime endDate)
        {
            return (int)endDate.Subtract(startDate).TotalDays;
        }

        public static int DateDiffHour(DateTime startDate, DateTime endDate)
        {
            return (int)endDate.Subtract(startDate).TotalHours;
        }

        public static int DateDiffMinute(DateTime startDate, DateTime endDate)
        {
            return (int)endDate.Subtract(startDate).TotalMinutes;
        }

        public static int DateDiffSecond(DateTime startDate, DateTime endDate)
        {
            return (int)endDate.Subtract(startDate).TotalSeconds;
        }

        public static int DateDiffMillisecond(DateTime startDate, DateTime endDate)
        {
            return (int)endDate.Subtract(startDate).TotalMilliseconds;
        }

        public static int DateDiffMicrosecond(DateTime startDate, DateTime endDate)
        {
            return (int)(endDate.Subtract(startDate).TotalMilliseconds * MilliToMicro);
        }

        public static int DateDiffNanosecond(DateTime startDate, DateTime endDate)
        {
            return (int)(endDate.Subtract(startDate).TotalMilliseconds * MilliToNano);
        }

        public static int? DateDiffYear(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffYear(startDate.Value, endDate.Value);
        }

        public static int? DateDiffMonth(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMonth(startDate.Value, endDate.Value);
        }

        public static int? DateDiffDay(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffDay(startDate.Value, endDate.Value);
        }

        public static int? DateDiffHour(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffHour(startDate.Value, endDate.Value);
        }

        public static int? DateDiffMinute(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMinute(startDate.Value, endDate.Value);
        }

        public static int? DateDiffSecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffSecond(startDate.Value, endDate.Value);
        }

        public static int? DateDiffMillisecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMillisecond(startDate.Value, endDate.Value);
        }

        public static int? DateDiffMicrosecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffMicrosecond(startDate.Value, endDate.Value);
        }

        public static int? DateDiffNanosecond(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null)
                return null;

            return DateDiffNanosecond(startDate.Value, endDate.Value);
        }
    }
}