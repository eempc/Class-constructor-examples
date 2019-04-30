using System;
using System.Collections.Generic;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            // Make a list of things that speak
            List<ISpeaks> thingsThatSpeak = new List<ISpeaks>();
            thingsThatSpeak.Add(new Cat("Mittens"));
            thingsThatSpeak.Add(new Dog("Rover"));
            thingsThatSpeak.Add(new Human("Bob"));
            thingsThatSpeak.Add(new Robot("R2D2"));

            foreach (var item in thingsThatSpeak) {
                Console.WriteLine(item.Speak() + "\r\n");
            }
            Console.ReadKey();
        }
    }

    // An interface simply defines the name of the methods, i.e. what should go into a class
    public interface ISpeaks {
        string Speak();
    }

    public abstract class Mammal : ISpeaks {
        public string Name { get; set; }
        
        public Mammal(string name) {
            Name = name;
        }

        public abstract string Speak(); // This class requires Speak() and is abstract

    }

    // If the abstract base class Mammal implements ISpeaks, then the derived classes do not need to inherit ISpeaks as with the Cat
    // If Speak() is missing, then the Cat class is invalid
    // Do all mammals speak though? Let's assume yes.
    public class Cat : Mammal {
        public Cat(string name) : base(name) {
            Name = name;
        }

        public override string Speak() {
            return "Meow! My name is " + Name;
        }
    }

    public class Dog : Mammal, ISpeaks {
        public Dog (string name) : base(name) {
            Name = name;
        }
        public override string Speak() {
            return "Woof! My name is " + Name;
        }
    }

    public class Human : Mammal, ISpeaks {
        public Human(string name) : base(name) {
            Name = name;
        }
        public override string Speak() {
            return "Hello! My name is " + Name;
        }
    }

    public class Robot : ISpeaks {
        public string Designation { get; set; }

        public Robot (string designation) {
            Designation = designation;
        }

        public string Speak() {
            return "Bleep! Bloop! My name is " + Designation;
        }
    }
}
