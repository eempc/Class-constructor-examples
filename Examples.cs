namespace ClassPractice {
    class Box2 {
        // Double constructor method
        public double length, breadth, height;
        public string name;

        // If you use the constructor parameters e.g. Box2 myBox2 = new Box2(3,3,3);
        public Box2(double length, double breadth, double height) {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
            this.name = "Box: " + length.ToString() + "x" + breadth.ToString() + "x" + breadth.ToString(); // This name is generated at construction, it won't be changed unless I can autodetect changes to box dimensions, or manual change
        }

        // Default value box of 2 if unspecified
        public Box2() {
            length = 2;
            breadth = 2;
            height = 2;
            name = "Box: " + length.ToString() + "x" + breadth.ToString() + "x" + breadth.ToString();
        }

        public double getVolume() {
            return length * breadth * height;
        }
    }
    
    class Box {
        // Non-constructor method

        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public double GetVolume() {
        return Length * Breadth * Height;
        }
    }
    
}
