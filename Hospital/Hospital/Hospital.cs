using Hospital.Exections;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Hospital
    {
        private static Hospital _instance;
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Patient> AllPatients { get; set; } = new List<Patient>();

        private Hospital() { }
        public static Hospital Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Hospital();
                return _instance;
            }
        }
        public void AdmitPatient(Patient patient)
        {
            bool available = false;
            foreach (var room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    AllPatients.Add(patient);
                    available = true;
                    Console.WriteLine($"{patient.Name} admitted to Room {room.RoomNumber}");
                    break;
                }
                catch (RoomFullException)
                {
                    continue;
                }
            }
            if (!available)
            {
                Console.WriteLine("No rooms available for reserved.");
            }
        }
        public void DischargePatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    break;
                }
            }
            AllPatients.Remove(patient);
            Console.WriteLine($"{patient.Name} has been discharged.");
        }
    }
}
