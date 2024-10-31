using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    class Hospital
    {

        private List<Appointment> Appointments { get; set; }
        private int nextAppointmentNo = 1;



        public Hospital()
        {
            Appointments = new List<Appointment>();
        }


        public void AddAppointment(string patient, string doctor, DateTime startDate, DateTime endDate)
        {
            Appointment appointment = new Appointment(nextAppointmentNo++, patient, doctor, startDate, endDate);
            Appointments.Add(appointment);
            Console.WriteLine("Appointment elave olundu: No " + appointment.No);
        }
        public void EndAppointment(int no)
        {
            var appointment = GetAppointment(no);
            if (appointment != null && appointment.EndDate == null)
            {
                appointment.EndDate = DateTime.Now;
                Console.WriteLine("Appointment sona catdi: No " + appointment.No);
            }
            else
            {
                Console.WriteLine("Tapilmadi.");
            }
        }

        public Appointment GetAppointment(int no)
        {
            return Appointments.Find(a => a.No == no);
        }

        public void GetAllAppointments()
        {
            foreach (var appointment in Appointments)
            {
                Console.WriteLine($"No: {appointment.No}, Patient: {appointment.Patient}," +
                    $" Doxtur: {appointment.Doctor}, Start: {appointment.StartDate}, End: {appointment.EndDate}");
            }
        }

        public void GetWeeklyAppointments()
        {
            var startOfWeek = DateTime.Today.StartOfWeek();
            var endOfWeek = startOfWeek.AddDays(7);
            var weeklyAppointments = Appointments.Where(a => a.StartDate >= startOfWeek && a.StartDate < endOfWeek);

            foreach (var appointment in weeklyAppointments)
            {
                Console.WriteLine($"No: {appointment.No}, Patient: {appointment.Patient}," +
                    $" Doxtur: {appointment.Doctor}, Start: {appointment.StartDate}, End: {appointment.EndDate}");
            }
        }

        public void GetTodaysAppointments()
        {
            var todayAppointments = Appointments.Where(a => a.StartDate.Date == DateTime.Today);

            foreach (var appointment in todayAppointments)
            {
                Console.WriteLine($"No: {appointment.No}, Patient: {appointment.Patient}, " +
                    $"Doxtur: {appointment.Doctor}, Start: {appointment.StartDate}, End: {appointment.EndDate}");
            }
        }

        public void GetAllContinuingAppointments()
        {
            var continuingAppointments = Appointments.Where(a => a.EndDate == null);

            foreach (var appointment in continuingAppointments)
            {
                Console.WriteLine($"No: {appointment.No}, Patient: {appointment.Patient}, " +
                    $"Doxtur: {appointment.Doctor}, Start: {appointment.StartDate}, End: {appointment.EndDate}");
            }
        }
    }

}

