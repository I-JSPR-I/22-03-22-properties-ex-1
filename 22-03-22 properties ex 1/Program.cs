using System;

namespace _22_03_22_properties_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student leerling = new Student();
            leerling.Fname = "Jasper";
            leerling.Lname = "Meersschaut";
            leerling.Klas = "5IB";
            Console.WriteLine(leerling.Fname);
            Console.WriteLine(leerling.Lname);
            Console.WriteLine(leerling.Klas);
        }
    }
}
