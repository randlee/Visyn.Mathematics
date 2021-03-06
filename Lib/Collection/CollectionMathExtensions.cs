#region Copyright (c) 2015-2018 Visyn
// The MIT License(MIT)
// 
// Copyright (c) 2015-2018 Visyn
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using Visyn.Types.Time;

namespace Visyn.Mathematics.Collection
{
    public static class CollectionMathExtensions
    {
 

        public static bool ElementsAreEqual<T>(this T dict1, T dict2, double doubleTolerance, double millisecondTolerance, bool ignoreNullItems) where T : IDictionary
        {
            var commonKeys = new List<object>();

            foreach(var key in dict1.Keys)
            {
                if(dict2.Contains(key))
                {
                    commonKeys.Add(key);
                }
            }

            foreach(var key in commonKeys)
            {
                var d1 = dict1[key];
                var d2 = dict2[key];

                if (d1 == null && d2 == null) continue;
                if (d1 == null || d2 == null)
                {
                    if (ignoreNullItems) continue;
                    return false;
                }
                if (d1.Equals(d2)) continue;

                if (d1.IsNumeric() && d2.IsNumeric())
                {
                    var v1 = Convert.ToDouble(d1);
                    var v2 = Convert.ToDouble(d2);
                    if(Math.Abs(v1-v2) < doubleTolerance) continue;
                }
                if (d1 is TimeSpan && d2 is TimeSpan)
                {
                    var ms1 = ((TimeSpan)d1).TotalMilliseconds;
                    var ms2 = ((TimeSpan)d2).TotalMilliseconds;
                    if (Math.Abs(ms1 - ms2) < millisecondTolerance) continue;
                }
                return false;
            }
            return true;
        }

        public static bool ElementsAreEqual<TKey, TValue>(this IReadOnlyDictionary<TKey,TValue> dict1, IReadOnlyDictionary<TKey, TValue> dict2, double doubleTolerance, double millisecondTolerance, bool ignoreNullItems)
        {
            if (dict1 == null || dict2 == null) return false;
            var commonKeys = new List<TKey>();

            foreach (var key in dict1.Keys)
            {
                if (dict2.ContainsKey(key))
                {
                    commonKeys.Add(key);
                }
            }

            foreach (var key in commonKeys)
            {
                var d1 = default(TValue);
                var d2 = default(TValue);
                dict1.TryGetValue(key, out d1);
                dict2.TryGetValue(key, out d2);

                if (d1 == null && d2 == null) continue;
                if (d1 == null || d2 == null)
                {
                    if (ignoreNullItems) continue;
                    return false;
                }
                if (d1.Equals(d2)) continue;

                if (d1.IsNumeric() && d2.IsNumeric())
                {
                    var v1 = Convert.ToDouble(d1);
                    var v2 = Convert.ToDouble(d2);
                    if (Math.Abs(v1 - v2) < doubleTolerance) continue;
                }
                if (d1 is DateTime && d2 is DateTime)
                {
                    var ms1 = Convert.ToDateTime(d1).MillisecondsSince1970();
                    var ms2 = Convert.ToDateTime(d2).MillisecondsSince1970();
                    if (Math.Abs(ms1 - ms2) <= millisecondTolerance)
                        continue;
                    else
                    {
                    }
                }
                if (d1 is TimeSpan && d2 is TimeSpan)
                {
                    //var ms1 = ((TimeSpan)d1).TotalMilliseconds;
                    //var ms2 = ((TimeSpan)d2).TotalMilliseconds;
                    //if (Math.Abs(ms1 - ms2) < tolerance) continue;
                }
                return false;
            }
            return true;
        }

        public static bool ElementsAreEquivalent<T>(this IList<T> current, IList<T> other)
        {
            if (current.Count != other.Count) return false;
            for(var i=0;i<current.Count;i++)
            {
                if (!current[i].Equals(other[i]))
                    return false;
            }
            return true;
        }

        public static bool ElementsAreEquivalent<T>(this T[] current, T[] other)
        {
            if (current.Length != other.Length) return false;
            for (var i = 0; i < current.Length; i++)
            {
                if (!current[i].Equals(other[i]))
                    return false;
            }
            return true;
        }
    }
}
