using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schedule = new MeetingSchedule();

            try
            {
                schedule.SetMeeting("Faiq", new DateTime(2024, 10, 30, 10, 0, 0), new DateTime(2024, 10, 30, 12, 0, 0));
                schedule.SetMeeting("Rafiq", new DateTime(2024, 10, 30, 11, 0, 0), new DateTime(2024, 10, 30, 13, 0, 0)); 
                schedule.SetMeeting("Afiq", new DateTime(2024, 10, 30, 12, 0, 0), new DateTime(2024, 10, 30, 14, 0, 0)); 
            }
            catch (ReservedDateInterval ex)
            {

                Console.WriteLine($"ReservedDateInterval Exception: {ex.Message}");

            }
            catch (WrongDateInterval ex)
            {

                Console.WriteLine($"WrongDateInterval Exception: {ex.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }
    }
}
