// Maybe?

    public class ScoreRecord {
        public List<double> Scores = new List<double>();

        public double Sum {
            get {
                return Scores.Sum();
            }
        }
            
        public double High {
            get {
                return Scores.Max();
            }
        }
        public double Low {
            get {
                return Scores.Min();
            }
        }
        public double Average {
            get {
                return Scores.Average();
            }
        }

        public void AddGrade(double score) {
            Scores.Add(score);
        }
    }

// use { get; set; } when it's a Property with PascalCase, this allows direct mutability of the property variable
// without { get; set; } it is a (private) variable with a "method" that sets the private variable (as is the case below with the extra validation check, or gets it via return method

public class Date
{
    private int month = 7;  // Backing store

    public int Month
    {
        get
        {
            return month;
        }
        set
        {
            if ((value > 0) && (value < 13))
            {
                month = value;
            }
            // else throw new ArgumentOutOfRangeException()
        }
    }
}

//////////////////
class MyBaseClass
{
    // virtual auto-implemented property. Overrides can only
    // provide specialized behavior if they implement get and set accessors.
    public virtual string Name { get; set; }

    // ordinary virtual property with backing field
    private int num;
    public virtual int Number
    {
        get { return num; }
        set { num = value; }
    }
}

class MyDerivedClass : MyBaseClass
{
    private string name;

   // Override auto-implemented property with ordinary property
   // to provide specialized accessor behavior.
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                name = "Unknown";
            }
        }
    } 
}
