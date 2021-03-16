﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utils
{
    public interface ITimestampUtil
    {
        DateTime ConvertToDatetime(double milliseconds);
    }

    public class TimestampUtil : ITimestampUtil
    {
        public DateTime ConvertToDatetime(double milliseconds)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime();
            return milestones.AddMilliseconds(milliseconds);
        }
    }

    public class TimestampStaicClas
    {
        public static DateTime ConvertToDatetime(double? milliseconds)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0);

            if(milliseconds == null || milliseconds <= 0)
            {
                return milestones;
            }

            return milestones.AddMilliseconds((double)milliseconds).ToLocalTime();
        }
    }
   
}
