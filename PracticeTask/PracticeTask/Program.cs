using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();
            bool run = true;

            while (run)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Appointment yarat (default: bugünkü tarix)");
                Console.WriteLine("2. Appointment-i bitir");
                Console.WriteLine("3. Bütün appointment-lərə bax");
                Console.WriteLine("4. Bu həftəki appointment-lərə bax");
                Console.WriteLine("5. Bugünki appointment-lərə bax");
                Console.WriteLine("6. Bitməmiş appointmentlərə bax");
                Console.WriteLine("7. Menudan çıx");

                var secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Patient: ");
                        string patient = Console.ReadLine();
                        Console.Write("Doxtur: ");
                        string doctor = Console.ReadLine();

                        
                        DateTime startDate = DateTime.Now;

                        
                        Console.Write("Son Tarix (yyyy-mm-dd hh:mm:");
                        Console.Write("End Date (yyyy-mm-dd hh:mm): ");
                        DateTime endDate = DateTime.Parse(Console.ReadLine());

                        hospital.AddAppointment(patient, doctor, startDate, endDate);
                        break;

                    case "2":
                        Console.Write("Appointment Nomresi: ");
                        int noToEnd = int.Parse(Console.ReadLine());
                        hospital.EndAppointment(noToEnd);
                        break;

                    case "3":
                        hospital.GetAllAppointments();
                        break;

                    case "4":
                        hospital.GetWeeklyAppointments();
                        break;

                    case "5":
                        hospital.GetTodaysAppointments();
                        break;

                    case "6":
                        hospital.GetAllContinuingAppointments();
                        break;

                    case "7":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Düzgün seç a kişi!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
