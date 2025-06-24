using System;
// Create a class Hospital with HospitalDetails() method. Create another classes Apollo, Wockhardt, Gokul_Superspeciality which overrides HospitalDetails() method

namespace LAB_4
{
    internal class Hospital{
        public virtual void HospitalDetails()
        {
            Console.WriteLine("This is a generic hospital.");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is a Apollo hospital.");

        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is a Wockhardt hospital.");

        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is a Gokul_Superspeciality hospital.");

        }
    }
}
