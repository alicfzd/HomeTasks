using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    public class MeetingSchedule
    {
        private Meeting meeting1;
        private Meeting meeting2;
        private Meeting meeting3;

        public void SetMeeting(string fullName, DateTime from, DateTime to)
        {
            
            if (from >= to)
            {
                throw new WrongDateInterval("FromDate, ToDate-den boyuk olmalidir");
            }

            
            CheckDates(from, to);

            
            if (meeting1 == null)
            {

                meeting1 = new Meeting(fullName, from, to);
            }
            else if (meeting2 == null)
            {
                meeting2 = new Meeting(fullName, from, to);
            }
            else if (meeting3 == null)
            {

                meeting3 = new Meeting(fullName, from, to);
            }
            else
            {
                throw new Exception("Maksimum saya çatdı");

            }
        }

        private void CheckDates(DateTime from, DateTime to)
        {
            Meeting[] meetings = {meeting1, meeting2, meeting3};

            foreach (var meeting in meetings)
            {
                if (meeting != null && (from < meeting.ToDate) && (to > meeting.FromDate))
                {
                    throw new ReservedDateInterval("Bu tarix intervalında rezerv var");
                }
            }
        }
    }
}
