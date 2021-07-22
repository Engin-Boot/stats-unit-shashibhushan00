using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsAlerter
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent = false;
        public EmailAlert()
        {
            emailSent = true;
        }
        public bool Alert()
        {
            return emailSent;
        }
    }
    public class LEDAlert : IAlerter
    {
        public bool ledGlows = false;
        public LEDAlert()
        {
            ledGlows = true;
        }
        public bool Alert()
        {
            return ledGlows;
        }
    }
}
