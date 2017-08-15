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
// Autogenerated from T4 Text Template :	SwapTests.tt
//											file:\C:\git\proto.temp\Visyn.Mathematics\Test\SwapTests.tt
// Autogeneration date/time:				8/13/2017 9:20:17 PM
#endregion

using System;
using System.Threading;
using NUnit.Framework;
using Visyn.Mathematics.Rand;

namespace Visyn.Mathematics.Test
{
	public class SwapTests
	{
        [Test()]
        public void SwapTest_Int32()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Int32 value1 = (Int32)values1[i];
                Int32 value2 = (Int32)values2[i];

                {
                    Int32 temp1 = value1;
                    Int32 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int32 temp1 = value1;
                    Int32 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int32 temp1 = value1;
                    Int32 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Int64()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Int64 value1 = (Int64)values1[i];
                Int64 value2 = (Int64)values2[i];

                {
                    Int64 temp1 = value1;
                    Int64 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int64 temp1 = value1;
                    Int64 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int64 temp1 = value1;
                    Int64 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Int16()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Int16 value1 = (Int16)values1[i];
                Int16 value2 = (Int16)values2[i];

                {
                    Int16 temp1 = value1;
                    Int16 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int16 temp1 = value1;
                    Int16 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Int16 temp1 = value1;
                    Int16 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Char()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Char value1 = (Char)values1[i];
                Char value2 = (Char)values2[i];

                {
                    Char temp1 = value1;
                    Char temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Char temp1 = value1;
                    Char temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Char temp1 = value1;
                    Char temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_UInt32()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                UInt32 value1 = (UInt32)values1[i];
                UInt32 value2 = (UInt32)values2[i];

                {
                    UInt32 temp1 = value1;
                    UInt32 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt32 temp1 = value1;
                    UInt32 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt32 temp1 = value1;
                    UInt32 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_UInt64()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                UInt64 value1 = (UInt64)values1[i];
                UInt64 value2 = (UInt64)values2[i];

                {
                    UInt64 temp1 = value1;
                    UInt64 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt64 temp1 = value1;
                    UInt64 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt64 temp1 = value1;
                    UInt64 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_UInt16()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                UInt16 value1 = (UInt16)values1[i];
                UInt16 value2 = (UInt16)values2[i];

                {
                    UInt16 temp1 = value1;
                    UInt16 temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt16 temp1 = value1;
                    UInt16 temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    UInt16 temp1 = value1;
                    UInt16 temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Byte()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Byte value1 = (Byte)values1[i];
                Byte value2 = (Byte)values2[i];

                {
                    Byte temp1 = value1;
                    Byte temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Byte temp1 = value1;
                    Byte temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Byte temp1 = value1;
                    Byte temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Double()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Double value1 = (Double)values1[i];
                Double value2 = (Double)values2[i];

                {
                    Double temp1 = value1;
                    Double temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Double temp1 = value1;
                    Double temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Double temp1 = value1;
                    Double temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Single()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Single value1 = (Single)values1[i];
                Single value2 = (Single)values2[i];

                {
                    Single temp1 = value1;
                    Single temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Single temp1 = value1;
                    Single temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Single temp1 = value1;
                    Single temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
        [Test()]
        public void SwapTest_Decimal()
        {
			IRandom random = Rng<FastRng>.ThreadSafeRandom(null,Thread.CurrentThread.ManagedThreadId);
		    var values1 = random.ExclusiveList(0, 1000000,100);
            var values2 = random.ExclusiveList(0, 1000000,100);

            for(int i=0;i<100;i++)
            {
                Decimal value1 = (Decimal)values1[i];
                Decimal value2 = (Decimal)values2[i];

                {
                    Decimal temp1 = value1;
                    Decimal temp2 = value2;

                    Numbers.Swap(ref temp1, ref temp2);
                    Assert.AreEqual(value1, temp2, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                    Assert.AreEqual(value2, temp1, $"Swap({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Decimal temp1 = value1;
                    Decimal temp2 = value2;

                    Numbers.SwapIfLess(ref temp1, ref temp2);
                    Assert.GreaterOrEqual(temp1,temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
                {
                    Decimal temp1 = value1;
                    Decimal temp2 = value2;

                    Numbers.SwapIfGreater(ref temp1, ref temp2);
                    Assert.LessOrEqual(temp1, temp2, $"SwapIfLess({value1},{value2}) Failed {temp1},{temp2}");
                }
			}
		}
	}
}



