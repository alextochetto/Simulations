using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace SimulationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CheckAppointmentInvertedClass();
            //CheckAppointmentInvertedClassFor();
            CheckAppointmentInvertedClassWhile();
            //CheckAppointmentInvertedDateTime();
            //CheckAppointmentInvertedDateTimeFor();
            //CheckAppointmentInvertedDateTimeWhile();
            //CheckAppointmentInverted();
            //CheckAppointmentInvertedFor();
            //CheckAppointmentInvertedWhile();
        }

        

        static void CheckAppointmentInvertedClass()
        {
            List<Appointment> appointmentsAvaliable = new List<Appointment>();
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 8, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 9, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 10, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 11, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 12, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 13, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 14, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 15, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 16, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 17, 0, 0) });
            appointmentsAvaliable.Add(new Appointment { Start = new DateTime(2023, 1, 13, 18, 0, 0) });

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<Appointment> avaliableAppointments = new List<Appointment>();
            foreach (Appointment appointment in appointmentsAvaliable)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == appointment.Start);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(new Appointment { Start = appointment.Start });
                }
            }
            foreach (Appointment appointment in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + appointment.Start.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInvertedClassFor()
        {
            List<Appointment> appointmentsAvaliable = new List<Appointment>();
            DateTime lastAdded = new DateTime(2023, 1, 13, 7, 0, 0);
            for (int i = 8; i <= 18; i++)
            {
                lastAdded = lastAdded.AddHours(1);
                appointmentsAvaliable.Add(new Appointment { Start = lastAdded });
            }

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<Appointment> avaliableAppointments = new List<Appointment>();
            foreach (Appointment appointment in appointmentsAvaliable)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == appointment.Start);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(new Appointment { Start = appointment.Start });
                }
            }
            foreach (Appointment appointment in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + appointment.Start.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInvertedClassWhile()
        {
            List<Appointment> appointmentsAvaliable = new List<Appointment>();
            DateTime lastAdded = new DateTime(2023, 1, 13, 7, 0, 0);
            int i = 8;
            while (i <= 18)
            {
                lastAdded = lastAdded.AddHours(1);
                appointmentsAvaliable.Add(new Appointment { Start = lastAdded });
                i++;
            }

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<Appointment> avaliableAppointments = new List<Appointment>();
            foreach (Appointment appointment in appointmentsAvaliable)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == appointment.Start);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(new Appointment { Start = appointment.Start });
                }
            }
            foreach (Appointment appointment in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + appointment.Start.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInvertedDateTime()
        {
            List<DateTime> avaliables = new List<DateTime>();
            avaliables.Add(new DateTime(2023, 1, 13, 8, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 12, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 13, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 14, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 15, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 16, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 17, 0, 0));
            avaliables.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<DateTime> avaliableAppointments = new List<DateTime>();
            foreach (DateTime date in avaliables)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == date);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(date);
                }
            }
            foreach (DateTime item in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + item.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInvertedDateTimeFor()
        {
            List<DateTime> avaliables = new List<DateTime>();
            DateTime lastAdded = new DateTime(2023, 1, 13, 7, 0, 0);
            for (int i = 8; i <= 18; i++)
            {
                lastAdded = lastAdded.AddHours(1);
                avaliables.Add(lastAdded);
            }

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<DateTime> avaliableAppointments = new List<DateTime>();
            foreach (DateTime date in avaliables)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == date);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(date);
                }
            }
            foreach (DateTime item in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + item.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInvertedDateTimeWhile()
        {
            List<DateTime> avaliables = new List<DateTime>();
            DateTime lastAdded = new DateTime(2023, 1, 13, 7, 0, 0);
            int i = 8;
            while (i <= 18)
            {
                lastAdded = lastAdded.AddHours(1);
                avaliables.Add(lastAdded);
                i++;
            }

            List<DateTime> scheduledAppointments = new List<DateTime>();
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 9, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 10, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 11, 0, 0));
            scheduledAppointments.Add(new DateTime(2023, 1, 13, 18, 0, 0));

            List<DateTime> avaliableAppointments = new List<DateTime>();
            foreach (DateTime date in avaliables)
            {
                DateTime datetimeFind = scheduledAppointments.Find(x => x == date);
                if (datetimeFind == DateTime.MinValue)
                {
                    avaliableAppointments.Add(date);
                }
            }
            foreach (DateTime item in avaliableAppointments)
            {
                Console.WriteLine("Datetime avaliable: " + item.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        static void CheckAppointmentInverted()
        {
            List<int> avaliables = new List<int>{ 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            List<int> scheduledAppointments = new List<int>{ 9, 10, 11, 18};

            List<int> avaliableAppointments = new List<int>();
            foreach (int hour in avaliables)
            {
                int hourFind = scheduledAppointments.Find(x => x == hour);
                if (hourFind == 0)
                {
                    avaliableAppointments.Add(hour);
                }
            }
            foreach (int item in avaliableAppointments)
            {
                Console.WriteLine("Hour avaliable: " + item);
            }
        }

        static void CheckAppointmentInvertedFor()
        {
            List<int> avaliables = new List<int>();
            for (int i = 8; i <= 18; i++)
            {
                avaliables.Add(i);
            }
            List<int> scheduledAppointments = new List<int>{ 9, 10, 11, 18};

            List<int> avaliableAppointments = new List<int>();
            foreach (int hour in avaliables)
            {
                int hourFind = scheduledAppointments.Find(x => x == hour);
                if (hourFind == 0)
                {
                    avaliableAppointments.Add(hour);
                }
            }
            foreach (int item in avaliableAppointments)
            {
                Console.WriteLine("Hour avaliable: " + item);
            }
        }

        static void CheckAppointmentInvertedWhile()
        {
            List<int> avaliables = new List<int>();
            int i = 8;
            while (i<=18)
            {
                avaliables.Add(i);
                i++;
            }
            List<int> scheduledAppointments = new List<int>{ 9, 10, 11, 18};

            List<int> avaliableAppointments = new List<int>();
            foreach (int hour in avaliables)
            {
                int hourFind = scheduledAppointments.Find(x => x == hour);
                if (hourFind == 0)
                {
                    avaliableAppointments.Add(hour);
                }
            }
            foreach (int item in avaliableAppointments)
            {
                Console.WriteLine("Hour avaliable: " + item);
            }
        }
    }

    internal class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }
}