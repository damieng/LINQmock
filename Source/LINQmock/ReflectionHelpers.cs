using System;
using System.Linq;
using System.Reflection;

namespace LinqMock
{
    internal static class ReflectionHelpers
    {
        public static string GetSignature(this MethodInfo methodInfo)
        {
            return CopySignature(methodInfo, methodInfo.DeclaringType.GetName() + "." + methodInfo.Name);
        }

        public static string CopySignature(this MethodInfo methodInfo, string replacementMethodName)
        {
            return methodInfo.ReturnType.GetName() + " " + replacementMethodName
                + "(" + string.Join(",", methodInfo.GetParameters().Select(p => p.ParameterType.GetName())) + ")";
        }

        public static string GetName(this Type type)
        {
            if (!type.IsGenericType)
                return type.Name;

            var strippedName = type.Name.Substring(0, type.Name.IndexOf('`'));

            if (type.GetGenericTypeDefinition() == typeof(Nullable<>))
                return GetName(type.GetGenericArguments()[0]) + "?";

            return strippedName + "<" + String.Join(",", type.GetGenericArguments().Select(a => a.GetName())) + ">";
        }
    }
}