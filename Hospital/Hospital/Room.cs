using Hospital.Exections;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Room
    {
        public string RoomNumber{ get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public Room(string roomNumber,int capacity)
        {
            RoomNumber = roomNumber;    
            Capacity = capacity;
        }
        public void AssignPatient(Patient patient)
        {
            if (Patients.Count>=Capacity)
            {
                throw new RoomFullException($"Room {RoomNumber} is full!");
            }
            Patients.Add(patient);
        }

    }
}
