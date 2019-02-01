using System;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            Cat cat1 = new Cat("Mittens", 3, "tabby");
            string description = cat1.verboseDescription();
            Console.WriteLine(description);
            cat1.changeName("Waffles");
            Console.WriteLine(cat1.getName());

            Box box1 = new Box(5.00, 3.5, 2.5);
            Console.WriteLine(box1.getVolume());
            Console.ReadLine();
        }
    }

    public class Cat {
        string name, breed;
        int age;

        public Cat(string name, int age, string breed) {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }

        public string getName() {
            return name; 
        }

        public int getAge() {
            return age;
        }

        public string getBreed() {
            return breed;
        }

        public string changeName(string newName) {
            Console.WriteLine("Name change request: " + newName);
            name = newName;
            return name;
        }

        public string verboseDescription() {
            return String.Format("{0} is a {1}-year old {2} cat.", name, age, breed);
        }
    }

    public class Box {
        double length, breadth, height;
        
        // Constructors are not mandatory
        public Box(double length, double breadth, double height) {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        // These get/sets must be the capitalised version of the initial initialisations
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public double getVolume() {
            return length * breadth * height;
        }
    }
}
