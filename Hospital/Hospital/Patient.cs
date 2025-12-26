using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Patient : Person
    {
        public Patient(string name, int age, string nationalCode,string patientId) : base(name, age, nationalCode)
        {
            PatientId = patientId;

        }
        public string PatientId { get; set; }
        public List<string> MedicalHistory { get; set; } = new List<string>();

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }
        public override string GetDetails()
        {
            string medicalHistory = "";
            foreach (var item in MedicalHistory)
            {
                medicalHistory+= item;
            }
            return base.GetDetails()+
                $"and PatientId {PatientId} ";
        }

    }
}
