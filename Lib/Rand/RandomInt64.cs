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

namespace Visyn.Mathematics.Rand
{
    public class RandomInt64 : IRandom<Int64>
    {
        private readonly IRandom Rng;

        public RandomInt64(IRandom rng)
        {
            Rng = rng;
        }

        #region Implementation of IRandom<short>

        /// <summary>
        /// Return a random value in the range [min,max] 
        /// </summary>
        /// <param name="min">Inclusive minimum of range</param>
        /// <param name="max">Inclusive maximum of range</param>
        /// <returns></returns>
        Int64 IRandom<Int64>.Inclusive(Int64 min, Int64 max)
        {
            return Inclusive(Rng, min, max);
        }

        /// <summary>
        /// Return a random integer in the range (min,max)
        /// </summary>
        /// <param name="min">Exclusive minimum of range</param>
        /// <param name="max">Exclusive maximum of range</param>
        /// <returns></returns>
        Int64 IRandom<Int64>.Exclusive(Int64 min, Int64 max)
        {
            return Exclusive(Rng, min, max);
        }

        #endregion

        /// <summary>
        /// Return a random integer in the range (min,max)
        /// </summary>
        /// <param name="min">Exclusive minimum of range</param>
        /// <param name="max">Exclusive maximum of range</param>
        /// <returns></returns>
        public static Int64 Exclusive(IRandom rng, Int64 min, Int64 max)
        {
            if(min > Int32.MinValue && max < Int32.MaxValue) return Convert.ToInt64(rng.Exclusive(Convert.ToInt32(min), Convert.ToInt32(max)));

            return Convert.ToInt64(rng.Exclusive(Convert.ToDecimal(min), Convert.ToDecimal(max)));

        }
        /// <summary>
        /// Return a random value in the range [min,max] 
        /// </summary>
        /// <param name="min">Inclusive minimum of range</param>
        /// <param name="max">Inclusive maximum of range</param>
        /// <returns></returns>
        public static long Inclusive(IRandom rng, Int64 min, Int64 max)
        {
            if (min > Int32.MinValue && max < Int32.MaxValue) return Convert.ToInt64(rng.Inclusive(Convert.ToInt32(min), Convert.ToInt32(max)));
            return Convert.ToInt64(rng.Inclusive(Convert.ToDecimal(min), Convert.ToDecimal(max)));
        }
    }
    
}
