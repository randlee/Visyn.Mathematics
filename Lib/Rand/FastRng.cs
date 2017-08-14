﻿using System;
using Visyn.Mathematics.Redzen.Numerics;

namespace Visyn.Mathematics.Rand
{
    public class FastRng : RandomBase, IRandom
    {
        private readonly XorShiftRandom _fastRandom = new XorShiftRandom(Environment.TickCount);
        #region Overrides of RandomBase

        protected override IRandom Rng => this;

        #endregion
        #region Implementation of IRandom

        /// <summary>
        /// ReSeed random number generator using new seed
        /// </summary>
        /// <param name="seed">Array of ulong to re-initialize</param>
        public void ReSeed(ulong[] seed)
        {
            _fastRandom.Reinitialise((int)seed[0]);
        }

        /// <summary>
        /// Return a random integer in the range [min,max] 
        /// </summary>
        /// <param name="min">Inclusive minimum of range</param>
        /// <param name="max">Inclusive maximum of range</param>
        /// <returns></returns>
        public int Inclusive(int min, int max)
        {
            if (max < int.MaxValue) max++;
            return _fastRandom.Next(min, max);
        }

        /// <summary>
        /// Return a random integer in the range (min,max)
        /// </summary>
        /// <param name="min">Exclusive minimum of range</param>
        /// <param name="max">Exclusive maximum of range</param>
        /// <returns></returns>
        public int Exclusive(int min, int max)
        {
            return _fastRandom.Next(min + 1, max);
        }

        /// <summary>
        /// Return a random double in the range [min,max] 
        /// </summary>
        /// <param name="min">Inclusive minimum of range</param>
        /// <param name="max">Inclusive maximum of range</param>
        /// <returns></returns>
        public double Inclusive(double min, double max)
        {
            if (min >= max) throw new ArgumentOutOfRangeException($"Min [{min}] must be < Max [{max}]!");
            return _fastRandom.NextDoubleNonZero() * (max+double.Epsilon - min) + min;


            //if (min >= max) throw new ArgumentException($"Min [{min}] must be < Max [{max}]!");
            //var random1 = _fastRandom.NextDouble();            // random1 is in range [0,1)
            //var random2 = _fastRandom.NextDouble() * -1.0 + 1.0; // random2 is in range (0,1]
            //// random1 + random2 is in range (0,2), divide by 2 (multiply by 0.5) for range (0,1)
            //return (random1 + random2) * (max - min) * (0.5) + min;
        }

        /// <summary>
        /// Return a random double in the range (min,max)
        /// </summary>
        /// <param name="min">Exclusive minimum of range</param>
        /// <param name="max">Exclusive maximum of range</param>
        /// <returns></returns>
        public double Exclusive(double min, double max)
        {
            if (min >= max) throw new ArgumentOutOfRangeException($"Min [{min}] must be < Max [{max}]!");
            return _fastRandom.NextDoubleNonZero()*(max-min) + min;
        }

        //public decimal Inclusive(decimal min, decimal max)
        //{
        //    return (decimal)Inclusive((double) min, (double) max);
        //}

        //public decimal Exclusive(decimal min, decimal max)
        //{
        //    if (min >= max) throw new ArgumentOutOfRangeException($"Min [{min}] must be < Max [{max}]!");
        //    return (decimal)(_fastRandom.NextDoubleNonZero() * (double)(max - min)) + min;
        //}



        //public byte Exclusive(byte min, byte max)
        //{
        //    return (byte)_fastRandom.Next(min, max);
        //}

        //public byte Inclusive(byte min, byte max)
        //{
        //    if (max < byte.MaxValue) max++;
        //    return (byte)_fastRandom.Next(min, max);
        //}

        #endregion


    }
}