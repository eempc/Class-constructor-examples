public class Derived : Base {
	public int NewProperty { get; set; }
	
	// Casting a base class to derived class to include the new property
	public Derived(Base base, int newProperty) {
		foreach (PropertyInfo property in typeof(Base).GetProperties()) {
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
		}
		NewProperty = newProperty;
	}
	
	// As above but without the new property
	public Derived(Base base) {
		foreach (PropertyInfo property in typeof(Base).GetProperties()) {
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
		}
	}
	
	// Standard constructor inheritance for brand new instance of Derived class
	public Derived(int newProperty, string oldProperty) : base(oldProperty) {
		// etc
	}
	
	// Just an empty
	public Derived() {
		
	}
}
