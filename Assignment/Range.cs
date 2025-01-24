using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T: IComparable<T>, INumber<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
               Methods.SWAP(ref max,ref min);
            }
            Max = max;
            Min = min;

        }

        public bool isInRange(T value)
        {
            return value.CompareTo(Min) >=0 && value.CompareTo(Max)<=0;
        }

        public T Length()
        {
            return Max - Min;
        }

        public int CompareTo(Range<T>? other)
        {
            if (other is not null)
            {
                int maxComparison = Max.CompareTo(other.Max);
                if (maxComparison != 0)
                {
                    return maxComparison; 
                }

                return Min.CompareTo(other.Min);
            }
            return 1;
        }
    }
}
