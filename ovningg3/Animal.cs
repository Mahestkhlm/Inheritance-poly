using System;
using System.Collections.Generic;
using System.Text;

namespace ovningg3
{
    class Animal
    {
        public int Age;
        public string Name;
        public double Weight;

        // Attributes for the animals such as Age,Name,Weight
        public Animal(int age, string name, double weight)
        {

            Age = age;
            Name = name;
            Weight = weight;

        }

        public virtual string Stats()
        {
            return $"\n Name: {Name}\n Age: {Age}\n Weight: {Weight}\n ";

        }
    }

    class Horse : Animal
    {
        public double RunSpeed { get; set; }

        public Horse(int age, string name, double weight, double Speed) : base(age, name, weight)
        {
            RunSpeed = Speed;
        }

        public Horse(int age, string name, double weight) : base(age, name, weight)
        {
        }

        public override string Stats()
        {
            return base.Stats() + $" The Running Speed per hour: {RunSpeed}";
        }
    }
    class Dog : Animal
    {
        public string Gender { get; set; }
        public Dog(int age, string name, double weight, string gender) : base(age, name, weight)
        {
            Gender = gender;
        }
        public string sleeps()
        {
            return "The Dog is sleeping";
        }
        public override string Stats()
        {
            return base.Stats() + $" Gender is: {Gender}";
        }
        public string Barks() => "The Dog barks Bowbow bowwwww!!!!!!!";
    }
    class Hedgehog : Animal
    {
        public int Spikecount { get; set; }
        public Hedgehog(string name, double weight, int age, int spikes) : base(age, name, weight)
        {
            Spikecount = spikes;
        }

        public override string Stats()
        {

            return base.Stats() + $"The hedgehog has :{Spikecount } spikes";
        }
    }
    class Worm : Animal
    {


        public int Length { get; set; }
        public Worm(string name, double weight, int age, int length) : base(age, name, weight)
        {
            Length = length;
        }
        public override string Stats()
        {

            return base.Stats() + $" The Worm is : {Length } cm";
        }

    }
    class Bird : Animal
    {
        public double WingSpan { get; set; }


        public Bird(int age, string name, double weight, double wingSpan) : base(age, name, weight)
        {
            WingSpan = wingSpan;
        }

    }
    class Pelican : Bird
    {
        public string Beakcolor { get; set; }
        public Pelican(int age, string name, double weight, double wingSpan, string beak) : base(age, name, weight, wingSpan)
        {
            Beakcolor = beak;
        }
        public override string Stats()
        {

            return base.Stats() + $"The Pelican has  : {Beakcolor } colored beak";
        }

    }
    class Flamingo : Bird
    {
        public double Color { get; set; }
        public Flamingo(int age, string name, double weight, double wingSpan, double color) : base(age, name, weight, wingSpan)
        {
            Color = color;
        }
    }
    class Swan : Bird
    {
        public bool BirdSound { get; set; }
        public Swan(int age, string name, double weight, double wingSpan, bool Birdsound) : base(age, name, weight, wingSpan)
        {
            BirdSound = Birdsound;
        }
        public override string Stats()
        {

            return base.Stats() + $" The Swan has : {BirdSound  }";
        }
        public string Birdsound() => "quack quack quackkkkkkkkkk";
    }
}


