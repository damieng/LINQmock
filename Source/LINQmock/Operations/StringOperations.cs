// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinqMock.Operations
{
    public static class StringOperations
    {
        private static readonly Dictionary<string, Regex> likeCache = new Dictionary<string, Regex>();

        public static bool SqlLike(string matchExpression, string likePattern, char escape)
        {
            return SqlLike(matchExpression, likePattern);
        }

        public static bool SqlLike(string matchExpression, string likePattern)
        {
            Regex regex;
            if (!likeCache.TryGetValue(likePattern, out regex))
                likeCache[likePattern] = regex = CreateLikeRegex(likePattern);

            return regex.IsMatch(matchExpression);
        }

        private static Regex CreateLikeRegex(string likePattern)
        {
            return new Regex(Regex.Replace(likePattern, @"[%_]|\[[^]]*\]|[^%_[]+", SqlLikeMatchEvaluator));
        }

        private static string SqlLikeMatchEvaluator(Match match)
        {
            if (match.Value == "%")
                return ".*";

            if (match.Value == "_")
                return ".";

            if (match.Value.StartsWith("[") && match.Value.EndsWith("]"))
                return match.Value;

            return Regex.Escape(match.Value);
        }
    }
}