
namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hospital = Hospital.Instance;

            hospital.Rooms.Add(new Room("101", 8));
            hospital.Rooms.Add(new Room("102", 4));

            Patient p1 = new Patient("Ali", 30, "5856215485", "P001");
            Patient p2 = new Patient("Sara", 25, "0316588525", "P002");

            hospital.AdmitPatient(p1);
            hospital.AdmitPatient(p2);

            Doctor d1 = new Doctor("Dr. Reza", 45, "5856215485", "D001", "Cardiology");
            d1.Diagnose(p1, "MS");
            Console.WriteLine(p1.GetDetails());

            hospital.DischargePatient(p1);
        }
    }
}
