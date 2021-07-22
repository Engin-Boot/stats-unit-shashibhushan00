using System;
using System.Collections.Generic;

namespace StatisticsAlerter
{
    public class StatsAlerter
    {
        public float maxThreshold;
        IAlerter[] alerters;

        public StatsAlerter(float threshold, IAlerter[] alerter)
        {
            maxThreshold = threshold;
            alerters = alerter;
        }

        public void checkAndAlert(List<float> numbers)
        {
            foreach (var num in numbers)
            {
                if (num > maxThreshold)
                {
                    foreach (var alert in alerters)
                    {
                        alert.Alert();
                    }
                }
            }
        }
    }
}
