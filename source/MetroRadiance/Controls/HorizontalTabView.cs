using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MetroRadiance.Controls
{
	public class HorizontalTabView : ListBox
	{
		static HorizontalTabView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizontalTabView), new FrameworkPropertyMetadata(typeof(HorizontalTabView)));
		}

		protected override void OnSelectionChanged(SelectionChangedEventArgs e)
		{
			base.OnSelectionChanged(e);

			foreach (var item in e.RemovedItems.OfType<ITabItem>())
			{
				item.IsSelected = false;
			}
			foreach (var item in e.AddedItems.OfType<ITabItem>())
			{
				item.IsSelected = true;
			}
		}
	}
}
