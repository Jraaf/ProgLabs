using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text.Json.Serialization;

namespace Lab3
{
    internal class Counter
    {
        public double Value { get; set; }

        public double LowerBorder { get; set; } 

        public double UpperBorder { get; set; }

        public Counter() { }
        private Counter(double value) : this(value, value - 1, value + 1)
        {
            Value = value;
        }
        private Counter(double value, double lowerBorder, double upperBorder)
        {
            Value = value;
            LowerBorder = lowerBorder;
            UpperBorder = upperBorder;
        }
        //public Counter() : this(0)
        //{ }

        //public Counter(double value) : this(value - 1, value + 1)
        //{
        //    Value = value;
        //}
        //public Counter(double lowerBorder, double upperBorder) : this((lowerBorder + upperBorder) / 2, lowerBorder, upperBorder)
        //{
        //    LowerBorder = lowerBorder;
        //    UpperBorder = upperBorder;
        //}
        //[JsonConstructor]
        //public Counter(double value, double lowerBorder, double upperBorder)
        //{
        //    Value = value;
        //    LowerBorder = lowerBorder;
        //    UpperBorder = upperBorder;
        //}

        public override string ToString()
        {
            return $"Value: {Value}\nLowerBorder: {LowerBorder}\nUpperBorder: {UpperBorder}";
        }

        public Counter Clone()
        {
            return new Counter(Value,LowerBorder,UpperBorder);
        }

        #region [Operators]
        public static Counter operator ++(Counter a)
        {
            if (a.Value +1 > a.UpperBorder) throw new ArgumentOutOfRangeException("UpperBound reached");
            return new Counter()
            {
                Value=a.Value+1,
                LowerBorder=a.LowerBorder,
                UpperBorder=a.UpperBorder
            };
        }

        public static Counter operator --(Counter a)
        {
            if (a.Value-1 < a.LowerBorder) throw new ArgumentOutOfRangeException("LowerBound Reached");
            return new Counter()
            {
                Value = a.Value - 1,
                LowerBorder = a.LowerBorder,
                UpperBorder = a.UpperBorder
            };
        }
        public static Counter operator +(Counter a, double b)
        {
            if (a.Value + b > a.UpperBorder) throw new ArgumentOutOfRangeException("UpperBound reached");
            return new Counter()
            {
                Value = a.Value + 1,
                LowerBorder = a.LowerBorder,
                UpperBorder = a.UpperBorder
            };
        }
        public static Counter operator -(Counter a, double b)
        {
            if (a.Value - b < a.LowerBorder) throw new ArgumentOutOfRangeException("LowerBound Reached");
            return new Counter()
            {
                Value = a.Value - b,
                LowerBorder = a.LowerBorder,
                UpperBorder = a.UpperBorder
            };
        }
        public static Counter operator *(Counter a, double b)
        {
            if (a.Value * b > a.UpperBorder) throw new ArgumentOutOfRangeException("UpperBound reached");
            return new Counter()
            {
                Value = a.Value * b,
                LowerBorder = a.LowerBorder,
                UpperBorder = a.UpperBorder
            };
        }
        public static Counter operator /(Counter a, double b)
        {
            if (a.Value / b < a.LowerBorder) throw new ArgumentOutOfRangeException("LowerBound Reached");
            return new Counter()
            {
                Value = a.Value / b,
                LowerBorder = a.LowerBorder,
                UpperBorder = a.UpperBorder
            };
        }
        public static bool operator <(Counter a, double b) => a.Value < b;
        public static bool operator >(Counter a, double b) => a.Value > b;
        #endregion


    }
}
