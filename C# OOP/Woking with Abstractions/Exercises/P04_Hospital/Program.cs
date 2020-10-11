using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            List<Doctor> doctors = new List<Doctor>();
            List<Department> departments = new List<Department>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] properties = command.Split();
                var departament = new Department(properties[0]);
                var doctor = new Doctor(properties[1], properties[2]);
                var patient = new Patient(properties[3]);
                var count = 1;

                
                

                var searchedDoctor = doctors.FirstOrDefault(d => d.FirstName + d.SureName == doctor.FirstName + doctor.SureName);

                if(searchedDoctor == null)
                {
                    doctors.Add(doctor);
                    searchedDoctor = doctor;
                }
                


                var searcheDepartment = departments.FirstOrDefault(d => d.Name == departament.Name);

                if(searcheDepartment == null)
                {
                    departments.Add(departament);
                    searcheDepartment = departament;
                }

                for (int stai = 0; stai < 20; stai++)
                {
                    var room = new Room(count);

                    searcheDepartment.Rooms.Add(room);

                    count++;
                }

                bool freeBeds = searcheDepartment.Capacity < 60;
                if (freeBeds)
                {
                    searchedDoctor.Patients.Add(patient);
                    foreach (var item in searcheDepartment.Rooms)
                    {
                        if(item.Patients.Count < item.Capacity)
                        {
                            item.Patients.Add(patient);

                            break;
                        }

                    }
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(departments.FirstOrDefault(x => x.Name == args[0]).ToString());
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    var rooms = departments.FirstOrDefault(x => x.Name == args[0]).Rooms.FirstOrDefault(r => r.Id == room);

                    foreach (var patient in rooms.Patients.OrderBy(p => p.Name))
                    {
                        Console.WriteLine(patient.ToString());
                    }
                }
                else
                {
                    var doctor = doctors.FirstOrDefault(x => x.FirstName + x.SureName == args[0] + args[1]);

                    foreach (var patient in doctor.Patients.OrderBy(p => p.Name))
                    {
                        Console.WriteLine(patient.ToString());
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
