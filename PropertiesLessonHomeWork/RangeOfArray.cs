using System;

namespace PropertiesLessonHomeWork
{
    class RangeOfArray
    {
        public int StartOfRange { get; set; }
        public int EndOfRange { get; set; }
        private int[] ArrayOfNewRange;

        public RangeOfArray(int start, int end)
        {
            end++;
            if (end <= start)
            {
                Console.WriteLine("Invalid Indices");
                end = 1;
                start = 0;
            }
            ArrayOfNewRange = new int[end - start];

            StartOfRange = start;
            EndOfRange = --end;
        }

        public int this[int index]
        {
            get
            {
                return ArrayOfNewRange[index + StartOfRange];
            }

            set
            {
                ArrayOfNewRange[index + StartOfRange] = value;
            }
        }

    }
}
