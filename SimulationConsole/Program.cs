using System;
using System.Collections.Generic;

namespace SimulationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckAppointmentInverted();
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