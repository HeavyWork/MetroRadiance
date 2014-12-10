
namespace MetroRadiance.Controls
{
	public interface ITabItem
	{
		string Name { get; }
		int? Badge { get; }
		bool IsSelected { get; set; }
	}
}
