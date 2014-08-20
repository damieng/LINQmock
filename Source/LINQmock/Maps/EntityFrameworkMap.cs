// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using LinqMock.Operations;

namespace LinqMock.Maps
{
    public sealed class EntityFrameworkMap : BaseLinqMap
    {
        private EntityFrameworkMap()
        {
            Add("SqlFunctions.Acos",
                (Func<double?, double?>)NumericOperations.Acos,
                (Func<decimal?, double?>)NumericOperations.Acos);
            Add("SqlFunctions.Ascii", (Func<string, int?>)StringOperations.Ascii);
            Add("SqlFunctions.Asin",
                (Func<double?, double?>)NumericOperations.Asin,
                (Func<decimal?, double?>)NumericOperations.Asin);
            Add("SqlFunctions.Atan",
                (Func<double?, double?>)NumericOperations.Atan,
                (Func<decimal?, double?>)NumericOperations.Atan);
            Add("SqlFunctions.Atan2",
                (Func<double?, double?, double?>)NumericOperations.Atan2,
                (Func<decimal?, decimal?, double?>)NumericOperations.Atan2);
            Add("SqlFunctions.Char", (Func<int?, string>)StringOperations.Char);
            Add("SqlFunctions.CharIndex", (Func<string, string, int?, int?>)StringOperations.CharIndex);
            Add("SqlFunctions.CurrentTimestamp", (Func<DateTime?>)(() => DateTime.Now));
            Add("SqlFunctions.CurrentUser", (Func<string>)(() => "dbo"));
            Add("SqlFunctions.GetDate", (Func<DateTime?>)(() => DateTime.Now));
            Add("SqlFunctions.Pi", (Func<double?>)(() => Math.PI));
            Add("SqlFunctions.Rand", (Func<double?>)NumericOperations.Rand,
                (Func<int?, double?>)NumericOperations.Rand);
        }

        public static readonly EntityFrameworkMap Instance = new EntityFrameworkMap();
    }
}