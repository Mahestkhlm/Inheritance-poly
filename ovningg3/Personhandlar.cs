using System;
using System.Collections.Generic;
using System.Text;

namespace ovningg3
{
    class Personhandlar
    {
        public Personhandlar()
        {
            PList = new List<Person>();
        }

        List<Person> PList;
        // property to set the person's age attribute using the SetAge method.
        public void SetAge(Person per, int age)
        {
            per.Age = age;
        }
        // property to set the person's weight attribute using the Setweight method.
        public void SetWeight(Person per, double weight)
        {
            per.Weight = weight;
        }
        //CreatePerson method with specified values age,fname,lname,height,weight
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            //creating an object for the person class using new keyword

            Person person = new Person(age, fname, lname, height, weight);
            PList.Add(person);
            return person;
        }
        /* public Person DeletePerson(int age,string fname,string lname,double height,double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            PList.Add(person);
            return person;
        }*/
    }
}


  
