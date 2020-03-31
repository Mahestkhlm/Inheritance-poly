using System;
using System.Collections.Generic;

namespace ovningg3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Person Details using Encapsulation");
                Console.WriteLine("-----------------------------------");
                Personhandlar handler = new Personhandlar();

                Person person = handler.CreatePerson(8, "ANANYA", "MOHAN", 4.40, 20);
                Person person1 = handler.CreatePerson(3, "AHALYA", "MOHAN", 2.60, 10);

                //setting age and weigth using setAge and setWeight for the person 1,2
                handler.SetAge(person, 9);
                handler.SetWeight(person, 29);
                handler.SetAge(person1, 4);
                handler.SetWeight(person1, 16);


                // Adding the person to the list
                Console.WriteLine(" The Person List:");
                Console.WriteLine(" ================");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"\nName:{person.Fname}{person.Lname} \nAge: {person.Age} years\nWeight: {person.Weight}kg\nLength:{person.Height}meter.");
                Console.WriteLine($"\nName:{person1.Fname}{person1.Lname}\nAge: {person1.Age}years\nweight: {person1.Weight}kg\nLength:{person1.Height}meter.");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEnter To Continue:");
                Console.ReadLine();

                // Creating a list of Animals in program.cs that receives animals
                Console.WriteLine(" THE ANIMAL LIST  ");
                Console.WriteLine("==================");

                List<Animal> animals = new List<Animal>()
            {
               new Horse (5,"Pony", 120.5,20),
               new Dog (5,"Jack", 13, "Male"),
               new Hedgehog("NorthAfrican", 20, 5, 1045),
               new Worm("Roundworm", 1.4, 5, 100),
               new Pelican(10,"Asian Pelican", 12, 2.2,"Yellow"),
               new Dog (5, "Rocky", 20, "Male"),

            };
                Console.WriteLine($"The total Animals in the Animal List: {animals.Count}");

                // Write out what animals are in the list with a foreach loop
                foreach (var Animal in animals)
                {
                    Console.WriteLine(value: Animal);
                }
                Console.WriteLine("\n------------------------------------------------------------------------------");
                // Create a list for dogs
                List<Dog> dogs = new List<Dog>()
            {
                 new Dog(7,"Princy",30,"Female"),
                 new Dog(12,"Tommy",35,"Male"),
                 new Dog(2,"Puppy",8,"Male"),
                 new Dog(5,"Boxy",7,"Male"),
                 new Dog(10,"Picasso",12,"Female"),
                 new Dog(4,"Julu",7,"Female"),
                 new Dog(2,"Siera",7,"Female"),

                 //new Horse(8,"Cherry", 9, 54),
                // We cannaot convert Horse class to dog class as we cannot add one child class to another child class.
                // we can only add Horse to the Animal List (Parent class)
                
            };

                Console.WriteLine($"Total count of Dogs in the Dog List: {dogs.Count}");
                Console.WriteLine("----------------------------------------------------------------------------");

                // Print all Animals Stats () by a foreach loop.
                foreach (var Animal in animals)
                {

                    Console.WriteLine(Animal.Stats());
                }
                Console.WriteLine("\n-------------------------------------------------------------------------- ");


                foreach (var Animal in animals)
                {
                    if (Animal is Dog)
                    {
                        Console.WriteLine("\nThe Dog in the Animal List:\n");

                        Console.WriteLine(Animal.Stats());
                    }

                }
                Console.WriteLine("\n------------------------------------------------------------------------------");
                //Question 15-F : 
                //AS the above mentioned Animal list doesnot have access to a new method.It has to be 
                //inherted from the parent class to child class
                // Print Dog Barks() by a foreach  loop .
                foreach (var DOG in animals)
                {
                    if (DOG is Dog newDog)
                    {
                        Console.WriteLine(newDog.Barks());
                    }
                }


                // User Errorhandling
                // Create a list of UserErrors and populate with instances of NumericInputError and TextInputError.
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(" Press Enter To check the UserERRor Handling");
                Console.ReadLine();
                List<UserError> UERROR = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new ValidateNumberError(-1,2),
                new TextError(),
            };
                // Print all UserErrors UEMessage () through a foreach loop.
                foreach (var user in UERROR)
                {
                    Console.WriteLine($"{user.UEMessage()}");
                }

                Console.WriteLine("Exit");
                Console.ReadKey();
            }
        }
    }
}

    // question: 11-F 
    //      Foreach loop checks the Animal List and executes the Stats ()method by returning the string property.
    // //   override method modifies the given properties.



    //  Print Stats ()of all dogs by a foreach loop
    // We can only retrieve dogs which are added  in animal List


    //Question 12.F: Polymorphism OOP concept uses inherited methods to perform different tasks-single action in different ways

    //Question 13.F
    //An abstract class cannot be instantiated. An abstract class can have constructrs.
    //constuctors are a spl mtd which is invoked when the object is created. 
    //constructor with specified parameters
    //ex: Public Person(int Age,string Name)
    //{Age = age;
    //  Name = name;}
    //An abstract class is designed to be inherited by baseclass which can either implement or override its methods.


