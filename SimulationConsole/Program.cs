using System;
using System.Collections.Generic;
namespace SimulationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckAppointmentInvertedClass();
            //CheckAppointmentInvertedDateTime();
            //CheckAppointmentInverted();
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
    }
}