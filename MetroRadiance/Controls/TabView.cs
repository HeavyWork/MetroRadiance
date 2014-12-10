using System.Windows;
using System.Windows.Controls;

namespace MetroRadiance.Controls
{
	public class TabView : ListBox
	{
		static TabView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TabView), new FrameworkPropertyMetadata(typeof(TabView)));
		}
	}
}
