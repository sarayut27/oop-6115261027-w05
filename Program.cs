using System;

namespace oop_6115261027_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b4 = new Building ("5", "Building 4", "222", "333");
            Room r422 = new Room ("422", "Room 422", "3", "2", "computer",b4);
            Subject A = new Subject ("261027", "ced", "2", "2", "2");
            Lecturer nathee = new Lecturer ("Arm", "zaza", "lecturer");
            Section ced1 = new Section ("15", "09.00", "12.00", r422 , A , nathee );
            Console.WriteLine(r433.ToString());
            Console.WriteLine(ced1.ToString());
        }
    }
}
