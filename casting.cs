public class Derived : Base
{
	public Derived(Base base)
	{
		foreach (PropertyInfo property in typeof(Base).GetProperties())
			typeof(Derived).GetProperty(property.Name).SetValue(this, property.GetValue(base));
	}
}
