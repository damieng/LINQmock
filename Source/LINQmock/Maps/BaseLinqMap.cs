// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace LinqMock.Maps
{
    public class BaseLinqMap : ILinqMap
    {
        // TODO: Better long-term caching strategy
        private readonly Dictionary<string, Delegate> replacements = new Dictionary<string, Delegate>();
        private readonly Dictionary<MethodInfo, Delegate> readCache = new Dictionary<MethodInfo, Delegate>();

        protected void Add(string methodName, Delegate replacement)
        {
            var methodSignature = replacement.Method.CopySignature(methodName);
            replacements.Add(methodSignature, replacement);
        }

        public Delegate GetReplacement(MethodInfo methodInfo)
        {
            Delegate replacement;
            if (readCache.TryGetValue(methodInfo, out replacement))
                return replacement;

            var methodSignature = methodInfo.GetSignature();
            replacements.TryGetValue(methodSignature, out replacement);
            readCache[methodInfo] = replacement;

            return replacement;
        }
    }
}