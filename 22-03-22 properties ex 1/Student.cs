using System;
using System.Collections.Generic;
using System.Text;

namespace _22_03_22_properties_ex_1
{
    class Student
    {
        private string fname;
        private string lname;
        private string klas;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }


        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Klas
        {
            get { return klas; }
            set { klas = value; }
        }
        public Student()
        {
            Fname = "Voornaam";
            Lname = "Achternaam";
            Klas = "IB";
        }
    }
}
