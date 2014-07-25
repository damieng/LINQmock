// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace LinqMock.Maps
{
    public class BaseLinqMap : ILinqMap
    {
        // TODO: Better long-term caching strategy
        private readonly Dictionary<string, Delegate> replacementMap = new Dictionary<string, Delegate>();
        private readonly Dictionary<MethodInfo, Delegate> replacementCache = new Dictionary<MethodInfo, Delegate>();

        protected void Add(string methodName, params Delegate[] replacements)
        {
            foreach (var replacement in replacements)
            {
                var methodSignature = replacement.Method.CopySignature(methodName);
                replacementMap.Add(methodSignature, replacement);
            }
        }

        public Delegate GetReplacement(MethodInfo methodInfo)
        {
            Delegate replacement;
            if (replacementCache.TryGetValue(methodInfo, out replacement))
                return replacement;

            var methodSignature = methodInfo.GetSignature();
            replacementMap.TryGetValue(methodSignature, out replacement);
            replacementCache[methodInfo] = replacement;

            return replacement;
        }
    }
}