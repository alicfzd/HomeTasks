using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    public class Meeting
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FullName { get; set; }

        public Meeting(string fullName, DateTime fromDate, DateTime toDate)
        {
            FullName = fullName;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }
}
