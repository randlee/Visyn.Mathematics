﻿#region Copyright (c) 2015-2017 Visyn
//The MIT License(MIT)
//
//Copyright(c) 2015-2017 Visyn
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
#endregion
#region Autogenerated T4 Text Template
// Autogenerated from T4 Text Template :	RangedExtensions.tt
//											file:\C:\git\proto.temp\Visyn.Mathematics\Lib\RangedExtensions.tt
// Autogeneration date/time:				8/13/2017 9:14:36 PM
#endregion
using System;
using Visyn.Mathematics;
using Visyn.Types;

namespace Visyn.Mathematics
{
	public static partial class RangedExtensions
	{
		public static Int32 ModuloAddWithCarry(this Ranged<Int32> ranged, Int32 value)
        {
            var sum = ranged.Value + value;
			Int32 carry=(Int32)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (Int32)sum;
                return carry;
            }

            Int32 positions = (Int32)(ranged.Max - ranged.Min + 1);
			Int32 remainder = (Int32)0;
			carry = Numbers.Divide((Int32)(sum-ranged.Min), positions, out remainder);
			
			Int32 result;
            if (remainder >= 0)
            {
				result = (Int32)(ranged.Min + remainder);
            }
			else
            {	// remainder is negative, back off from max & decrement carry
				result = (Int32)(ranged.Max + 1 + remainder);
				carry--;
            }
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static Int64 ModuloAddWithCarry(this Ranged<Int64> ranged, Int64 value)
        {
            var sum = ranged.Value + value;
			Int64 carry=(Int64)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (Int64)sum;
                return carry;
            }

            Int64 positions = (Int64)(ranged.Max - ranged.Min + 1);
			Int64 remainder = (Int64)0;
			carry = Numbers.Divide((Int64)(sum-ranged.Min), positions, out remainder);
			
			Int64 result;
            if (remainder >= 0)
            {
				result = (Int64)(ranged.Min + remainder);
            }
			else
            {	// remainder is negative, back off from max & decrement carry
				result = (Int64)(ranged.Max + 1 + remainder);
				carry--;
            }
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static Int16 ModuloAddWithCarry(this Ranged<Int16> ranged, Int16 value)
        {
            var sum = ranged.Value + value;
			Int16 carry=(Int16)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (Int16)sum;
                return carry;
            }

            Int16 positions = (Int16)(ranged.Max - ranged.Min + 1);
			Int16 remainder = (Int16)0;
			carry = Numbers.Divide((Int16)(sum-ranged.Min), positions, out remainder);
			
			Int16 result;
            if (remainder >= 0)
            {
				result = (Int16)(ranged.Min + remainder);
            }
			else
            {	// remainder is negative, back off from max & decrement carry
				result = (Int16)(ranged.Max + 1 + remainder);
				carry--;
            }
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static UInt32 ModuloAddWithCarry(this Ranged<UInt32> ranged, UInt32 value)
        {
            var sum = ranged.Value + value;
			UInt32 carry=(UInt32)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (UInt32)sum;
                return carry;
            }

            UInt32 positions = (UInt32)(ranged.Max - ranged.Min + 1);
			UInt32 remainder = (UInt32)0;
			carry = Numbers.Divide((UInt32)(sum-ranged.Min), positions, out remainder);
			
			UInt32 result = (UInt32)(ranged.Min + remainder);
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static UInt64 ModuloAddWithCarry(this Ranged<UInt64> ranged, UInt64 value)
        {
            var sum = ranged.Value + value;
			UInt64 carry=(UInt64)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (UInt64)sum;
                return carry;
            }

            UInt64 positions = (UInt64)(ranged.Max - ranged.Min + 1);
			UInt64 remainder = (UInt64)0;
			carry = Numbers.Divide((UInt64)(sum-ranged.Min), positions, out remainder);
			
			UInt64 result = (UInt64)(ranged.Min + remainder);
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static UInt16 ModuloAddWithCarry(this Ranged<UInt16> ranged, UInt16 value)
        {
            var sum = ranged.Value + value;
			UInt16 carry=(UInt16)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (UInt16)sum;
                return carry;
            }

            UInt16 positions = (UInt16)(ranged.Max - ranged.Min + 1);
			UInt16 remainder = (UInt16)0;
			carry = Numbers.Divide((UInt16)(sum-ranged.Min), positions, out remainder);
			
			UInt16 result = (UInt16)(ranged.Min + remainder);
			ranged.Value = result;
#if DEBUG
			if(ranged.Value != result) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static Double ModuloAddWithCarry(this Ranged<Double> ranged, Double value)
        {
            var sum = ranged.Value + value;
			Double carry=(Double)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (Double)sum;
                return carry;
            }

            Double positions = (Double)(ranged.Max - ranged.Min + 1);
			Double remainder = (Double)0;
			carry = Numbers.Divide((Double)(sum-ranged.Min), positions, out remainder);
			
			Double result;
            if (remainder >= 0)
            {
				result = (Double)(ranged.Min + remainder);
            }
			else
            {	// remainder is negative, back off from max & decrement carry
				result = (Double)(ranged.Max + 1 + remainder);
				carry--;
            }
			ranged.Value = result;
#if DEBUG
			if(Math.Abs(ranged.Value - result) > 1e-12) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}
		public static Single ModuloAddWithCarry(this Ranged<Single> ranged, Single value)
        {
            var sum = ranged.Value + value;
			Single carry=(Single)0;
            if (sum <= ranged.Max && sum >= ranged.Min)
            {
                ranged.Value = (Single)sum;
                return carry;
            }

            Single positions = (Single)(ranged.Max - ranged.Min + 1);
			Single remainder = (Single)0;
			carry = Numbers.Divide((Single)(sum-ranged.Min), positions, out remainder);
			
			Single result;
            if (remainder >= 0)
            {
				result = (Single)(ranged.Min + remainder);
            }
			else
            {	// remainder is negative, back off from max & decrement carry
				result = (Single)(ranged.Max + 1 + remainder);
				carry--;
            }
			ranged.Value = result;
#if DEBUG
			if(Math.Abs(ranged.Value - result) > 1e-12) throw new Exception($"Value={result} failed range [{ranged.Min},{ranged.Max}], {ranged.Value}+{value}, {carry}R{remainder}");
#endif
			return carry;
		}

	}
}