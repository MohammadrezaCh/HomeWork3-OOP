using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Doctor : Person
    {
        public Doctor(string name, int age, string nationalCode,string doctorId, string specialization) : base(name, age, nationalCode)
        {
            DoctorId= doctorId;
            Specialization= specialization;
        }
        public string DoctorId { get; set; }
        public string Specialization { get; set; }
        public void Diagnose(Patient patient,string medical)
        {
            patient.AddToMedicalHistory(medical);
        }
        public override string GetDetails()
        {
            return base.GetDetails()+
                $"with DoctorId {DoctorId} and Specialization {Specialization}";
        }
    }
}
