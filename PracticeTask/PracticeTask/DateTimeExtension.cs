using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dateTime)
        {
            return dateTime.AddDays(-(int)dateTime.DayOfWeek + (int)DayOfWeek.Monday).Date;
        }
    }
}
