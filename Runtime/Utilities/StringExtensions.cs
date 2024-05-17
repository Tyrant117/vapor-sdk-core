using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vapor
{
    public static class StringExtensions
    {
        public static bool EmptyOrNull(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
