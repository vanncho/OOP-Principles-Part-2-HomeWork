namespace _03.IvalidRangeExeption
{
    using System;

    public class Start
    {
        public static void Main(string[] args)
        {
            try
            {
                int start = 1;
                int end = 100;

                int number = 150;

                if (start < number && number > end)
                    throw new InvalidRangeException<int>(start, end);
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine("Begin: {0}, Last: {1}", ire.Start, ire.End);
            }

            Console.WriteLine();

            try
            {
                DateTime begin = new DateTime(1980, 1, 1);
                DateTime last = new DateTime(2013, 12, 31);

                DateTime date = new DateTime(2014, 2, 1);

                if (begin < date && date > last)
                    throw new InvalidRangeException<DateTime>(begin, last);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine("Begin: {0}, Last: {1}", ire.Start, ire.End);
            }
        }
    }
}
