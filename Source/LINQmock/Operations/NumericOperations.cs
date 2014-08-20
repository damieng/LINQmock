// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LinqMock.Operations
{
    public static class NumericOperations
    {
        public static double? Acos(double? arg)
        {
            if (arg == null)
                return null;

            return Math.Acos(arg.Value);
        }

        public static double? Acos(decimal? arg)
        {
            return Acos((double?)arg);
        }

        public static double? Asin(double? arg)
        {
            if (arg == null)
                return null;

            return Math.Asin(arg.Value);
        }

        public static double? Asin(decimal? arg)
        {
            return Asin((double?)arg);
        }

        public static double? Atan(double? arg)
        {
            if (arg == null)
                return null;

            return Math.Atan(arg.Value);
        }

        public static double? Atan(decimal? arg)
        {
            return Atan((double?)arg);
        }

        public static double? Atan2(double? arg1, double? arg2)
        {
            if (arg1 == null || arg2 == null)
                return null;

            return Math.Atan2(arg1.Value, arg2.Value);
        }

        public static double? Atan2(decimal? arg1, decimal? arg2)
        {
            return Atan2((double?)arg1, (double?)arg2);
        }
            
        private static readonly Random random = new Random();

        public static double? Rand()
        {
            return random.NextDouble();
        }

        public static double? Rand(int? seed)
        {
            if (seed == null)
                return null;

            return new Random(seed.Value).NextDouble();
        }
    }
}