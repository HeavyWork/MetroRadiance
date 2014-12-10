using System.Windows;
using System.Windows.Controls;

namespace MetroRadiance.Controls
{
	public class SystemButtons : Control
	{
		static SystemButtons()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SystemButtons), new FrameworkPropertyMetadata(typeof(SystemButtons)));
		}
	}
}
