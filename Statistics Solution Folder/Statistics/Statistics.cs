using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public class Stats
        {
            public double average;
            public double max;
            public double min;
        }
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            float sumOfNumbers = 0, maxValue = float.MinValue, minValue = float.MaxValue;

            foreach (var num in numbers)
            {
                sumOfNumbers += num;
                maxValue = Math.Max(maxValue, num);
                minValue = Math.Min(minValue, num);
            }

            Stats statsObj = new Stats();
            statsObj.max = maxValue;
            statsObj.min = minValue;
            int length = numbers.Count;
            statsObj.average = (sumOfNumbers / (float)length);

            return statsObj;
        }
    }
}
