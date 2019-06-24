public class Derived : Base {
	public int NewProperty { get; set; }

	public Derived(Base base, int newProperty) {
		foreach (PropertyInfo property in typeof(Base).GetProperties()) {
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
		}
		NewProperty = newProperty;
	}
	
	public Derived(Base base) {
		foreach (PropertyInfo property in typeof(Base).GetProperties()) {
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
		}
	}
	
	public Derived(int newProperty, string oldProperty) : base(oldProperty) {
		// etc
	}
	
	public Derived() {
		
	}
}
