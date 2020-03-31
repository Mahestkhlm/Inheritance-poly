using System;
using System.Collections.Generic;
using System.Text;

namespace ovningg3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fname, string lname, double height, double weight)
        {
            this.age = age;
            fName = fname;
            lName = lname;
            this.height = height;
            this.weight = weight;
        }

        public Person(int age, double height, double weight, string fname, string lname)
        {
            this.age = age;
            fName = fname;
            lName = lname;
            this.height = height;
            this.weight = weight;

        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }
        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
