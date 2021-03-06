﻿#region Copyright (c) 2015-2018 Visyn
//The MIT License(MIT)
//
//Copyright (c) 2015-2018 Visyn
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
// Autogenerated from T4 Text Template :	Variance.tt
//											file:\C:\Customer\Lucent\Visyn.Mathematics\Lib\Statistic\Variance.tt
// Autogeneration date/time:				4/17/2018 4:30:14 PM
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Visyn.Mathematics.Comparison;

namespace Visyn.Mathematics
{
	public static partial class MathExtensions
	{
		public static double Variance<T>(this IEnumerable<T> collection, out double ave, out int count, Func<T,double> convert)
        {
			return Variance(collection.Select(convert), out ave, out count);
        }

		public static double Variance<T>(this IEnumerable<T> collection) where T : IComparable, IComparable<T>, IEquatable<T>
        {
			double ave;
			int count;
			// Int32 
			if (typeof(T) == typeof(Int32)) return ((IEnumerable<Int32>)collection).Variance(out ave, out count);
			// Int64 
			if (typeof(T) == typeof(Int64)) return ((IEnumerable<Int64>)collection).Variance(out ave, out count);
			// Int16 
			if (typeof(T) == typeof(Int16)) return ((IEnumerable<Int16>)collection).Variance(out ave, out count);
			// Char 
			if (typeof(T) == typeof(Char)) return ((IEnumerable<Char>)collection).Variance(out ave, out count);
			// UInt32 
			if (typeof(T) == typeof(UInt32)) return ((IEnumerable<UInt32>)collection).Variance(out ave, out count);
			// UInt64 
			if (typeof(T) == typeof(UInt64)) return ((IEnumerable<UInt64>)collection).Variance(out ave, out count);
			// UInt16 
			if (typeof(T) == typeof(UInt16)) return ((IEnumerable<UInt16>)collection).Variance(out ave, out count);
			// Byte 
			if (typeof(T) == typeof(Byte)) return ((IEnumerable<Byte>)collection).Variance(out ave, out count);
			// Double 
			if (typeof(T) == typeof(Double)) return ((IEnumerable<Double>)collection).Variance(out ave, out count);
			// Single 
			if (typeof(T) == typeof(Single)) return ((IEnumerable<Single>)collection).Variance(out ave, out count);
			// Decimal 
			if (typeof(T) == typeof(Decimal)) return ((IEnumerable<Decimal>)collection).Variance(out ave, out count);
            if (typeof(T).IsNumeric() || typeof(T) == typeof(string)) return Variance(collection.Select(i => NumberConverter.Instance.ToDouble(i)),out ave,out count);
//			if (typeof(T) == typeof(string)) return Variance(collection.Select(s => Convert.ToDouble(s)), out ave, out count);
            throw new NotImplementedException($"Average not implemented for Type={typeof(T)}");
        }

        public static double Variance<T>(this IEnumerable<T> collection, out double ave) where T : IComparable, IComparable<T>, IEquatable<T>
        {
			int count;
			// Int32 
			if (typeof(T) == typeof(Int32)) return ((IEnumerable<Int32>)collection).Variance(out ave, out count);
			// Int64 
			if (typeof(T) == typeof(Int64)) return ((IEnumerable<Int64>)collection).Variance(out ave, out count);
			// Int16 
			if (typeof(T) == typeof(Int16)) return ((IEnumerable<Int16>)collection).Variance(out ave, out count);
			// Char 
			if (typeof(T) == typeof(Char)) return ((IEnumerable<Char>)collection).Variance(out ave, out count);
			// UInt32 
			if (typeof(T) == typeof(UInt32)) return ((IEnumerable<UInt32>)collection).Variance(out ave, out count);
			// UInt64 
			if (typeof(T) == typeof(UInt64)) return ((IEnumerable<UInt64>)collection).Variance(out ave, out count);
			// UInt16 
			if (typeof(T) == typeof(UInt16)) return ((IEnumerable<UInt16>)collection).Variance(out ave, out count);
			// Byte 
			if (typeof(T) == typeof(Byte)) return ((IEnumerable<Byte>)collection).Variance(out ave, out count);
			// Double 
			if (typeof(T) == typeof(Double)) return ((IEnumerable<Double>)collection).Variance(out ave, out count);
			// Single 
			if (typeof(T) == typeof(Single)) return ((IEnumerable<Single>)collection).Variance(out ave, out count);
			// Decimal 
			if (typeof(T) == typeof(Decimal)) return ((IEnumerable<Decimal>)collection).Variance(out ave, out count);
            if (typeof(T).IsNumeric()|| typeof(T) == typeof(string)) return Variance(collection.Select(i => NumberConverter.Instance.ToDouble(i)),out ave,out count);

            throw new NotImplementedException($"Average not implemented for Type={typeof(T)}");
        }

        public static double Variance<T>(this IEnumerable<T> collection, out double ave, out int count) where T : IComparable, IComparable<T>, IEquatable<T>
        {
			// Int32 
			if (typeof(T) == typeof(Int32)) return ((IEnumerable<Int32>)collection).Variance(out ave, out count);
			// Int64 
			if (typeof(T) == typeof(Int64)) return ((IEnumerable<Int64>)collection).Variance(out ave, out count);
			// Int16 
			if (typeof(T) == typeof(Int16)) return ((IEnumerable<Int16>)collection).Variance(out ave, out count);
			// Char 
			if (typeof(T) == typeof(Char)) return ((IEnumerable<Char>)collection).Variance(out ave, out count);
			// UInt32 
			if (typeof(T) == typeof(UInt32)) return ((IEnumerable<UInt32>)collection).Variance(out ave, out count);
			// UInt64 
			if (typeof(T) == typeof(UInt64)) return ((IEnumerable<UInt64>)collection).Variance(out ave, out count);
			// UInt16 
			if (typeof(T) == typeof(UInt16)) return ((IEnumerable<UInt16>)collection).Variance(out ave, out count);
			// Byte 
			if (typeof(T) == typeof(Byte)) return ((IEnumerable<Byte>)collection).Variance(out ave, out count);
			// Double 
			if (typeof(T) == typeof(Double)) return ((IEnumerable<Double>)collection).Variance(out ave, out count);
			// Single 
			if (typeof(T) == typeof(Single)) return ((IEnumerable<Single>)collection).Variance(out ave, out count);
			// Decimal 
			if (typeof(T) == typeof(Decimal)) return ((IEnumerable<Decimal>)collection).Variance(out ave, out count);
            if (typeof(T).IsNumeric()|| typeof(T) == typeof(string)) return Variance(collection.Select(i => NumberConverter.Instance.ToDouble(i)),out ave, out count);

            throw new NotImplementedException($"Average not implemented for Type={typeof(T)}");
        }
		        
		public static Statistics Statistics<T>(this IEnumerable<T> collection, string name=null) where T : IComparable, IComparable<T>, IEquatable<T>
        {
			// Int32 
			if (typeof(T) == typeof(Int32)) return ((IEnumerable<Int32>)collection).Statistics(name);
			// Int64 
			if (typeof(T) == typeof(Int64)) return ((IEnumerable<Int64>)collection).Statistics(name);
			// Int16 
			if (typeof(T) == typeof(Int16)) return ((IEnumerable<Int16>)collection).Statistics(name);
			// Char 
			if (typeof(T) == typeof(Char)) return ((IEnumerable<Char>)collection).Statistics(name);
			// UInt32 
			if (typeof(T) == typeof(UInt32)) return ((IEnumerable<UInt32>)collection).Statistics(name);
			// UInt64 
			if (typeof(T) == typeof(UInt64)) return ((IEnumerable<UInt64>)collection).Statistics(name);
			// UInt16 
			if (typeof(T) == typeof(UInt16)) return ((IEnumerable<UInt16>)collection).Statistics(name);
			// Byte 
			if (typeof(T) == typeof(Byte)) return ((IEnumerable<Byte>)collection).Statistics(name);
			// Double 
			if (typeof(T) == typeof(Double)) return ((IEnumerable<Double>)collection).Statistics(name);
			// Single 
			if (typeof(T) == typeof(Single)) return ((IEnumerable<Single>)collection).Statistics(name);
			// Decimal 
			if (typeof(T) == typeof(Decimal)) return ((IEnumerable<Decimal>)collection).Statistics(name);
            if (typeof(T).IsNumeric()|| typeof(T) == typeof(string)) return Statistics(collection.Select(i => NumberConverter.Instance.ToDouble(i)),name);

            throw new NotImplementedException($"Average not implemented for Type={typeof(T)}");
        }


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Int32> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Int32> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Int64> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Int64> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Int16> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Int16> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Char> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Char> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<UInt32> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<UInt32> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<UInt64> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<UInt64> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<UInt16> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<UInt16> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Byte> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Byte> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Double> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Double> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Single> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Single> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}


		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="average">Average of the collection</param>
        /// <returns>Mean value System.Double.</returns>
		public static double Variance (this IEnumerable<Decimal> numbers, out double average, out int count)  
		{
            average = 0.0;
			count = 0;
            double M2 = 0.0;

            foreach (var x in numbers)
            {
                count += 1;
                var delta = (double)x - average;
                average += delta / count;
                var delta2 = (double)x - average;
                M2 += delta * delta2;
            }
            return count < 2 ? double.NaN : M2 / (count - 1);
		}

		/// <summary>
        /// Calculates the variance of the specified collection
		/// This is a numerically stable algorithm for the sample variance. 
		/// It also computes the mean. This algorithm was found by Welford, and it has been thoroughly analyzed
		/// https://en.wikipedia.org/wiki/Algorithms_for_calculating_variance#Online_algorithm
        /// </summary>
        /// <param name="numbers">The numbers to calculate variance of.</param>
		/// <param name="name">Name of the statistics</param>
        /// <returns>Mean value System.Double.</returns>
		public static Statistics Statistics (this IEnumerable<Decimal> numbers, string name=null)  
		{
            double average = 0.0;
			int count = 0;
            double M2 = 0.0;
			double min = double.MaxValue;
			double max = double.MinValue;

            foreach (var x in numbers)
            {
				var d = (double)x;
                count += 1;
                var delta = d - average;
                average += delta / count;
                var delta2 = d - average;
                M2 += delta * delta2;
				max=(d>max) ? d : max;
				min=(d<min) ? d : min;
            }
			 var variance= count < 2 ? double.NaN : M2 / (count - 1);
			return new Statistics(name, average,variance,Math.Sqrt(variance),min,max,count);
		}

	}
}