public class Derived : Base {
	public int NewProperty { get; set; }

	public Derived(Base base, int newProperty) {
		foreach (PropertyInfo property in typeof(Base).GetProperties()) {
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
		}
		NewProperty = newProperty;
	}
}
