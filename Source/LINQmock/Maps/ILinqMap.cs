// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using System.Reflection;

namespace LinqMock.Maps
{
    public interface ILinqMap
    {
        Delegate GetReplacement(MethodInfo methodInfo);
    }
}