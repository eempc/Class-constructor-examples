// Reference vs value types, classes vs structs

public struct Vector2 {
    public double x, y;
    public Vector2(double p1, double p2) {
        x = p1;
        y = p2;
    }

    // Get the length between this vector2 and another vector2 via Pythagoras
    public double magnitude(Vector2 otherPoint) {
        return Math.Sqrt(Math.Pow(otherPoint.y - this.y, 2) + Math.Pow(otherPoint.x - this.x, 2));
    }

    // Get midpoint between this vector2 and another vector2
    public Vector2 midpoint(Vector2 otherPoint) {
        return new Vector2((otherPoint.x + this.x)/2, (otherPoint.y + this.y)/2);
    }
}  

// https://softwareengineering.stackexchange.com/questions/92339/when-do-you-use-a-struct-instead-of-a-class
