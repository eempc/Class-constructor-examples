public class ExtendedChild : Parent
{
	public ExtendedChild(Parent parent)
	{
		foreach (PropertyInfo property in typeof(Parent).GetProperties())
			typeof(ExtendedChild).GetProperty(property.Name).SetValue(this, property.GetValue(parent));
	}
}
