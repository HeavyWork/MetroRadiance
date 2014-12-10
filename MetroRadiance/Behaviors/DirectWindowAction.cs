<<<<<<< HEAD
﻿using MetroRadiance.Controls;
using MetroRadiance.Internal;
using System.Windows;
using System.Windows.Interactivity;

namespace MetroRadiance.Behaviors
{
	internal class DirectWindowAction : TriggerAction<FrameworkElement>
	{
		#region WindowAction 依存関係プロパティ

		public WindowAction WindowAction
		{
			get { return (WindowAction)this.GetValue(WindowActionProperty); }
			set { this.SetValue(WindowActionProperty, value); }
		}

		public static readonly DependencyProperty WindowActionProperty =
			DependencyProperty.Register("WindowAction", typeof (WindowAction), typeof (DirectWindowAction), new UIPropertyMetadata(WindowAction.Active));

		#endregion

		protected override void Invoke(object parameter)
		{
			this.WindowAction.Invoke(this.AssociatedObject);
		}
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Interactivity;
using MetroRadiance.Controls;
using MetroRadiance.Internal;

namespace MetroRadiance.Behaviors
{
	internal class DirectWindowAction : TriggerAction<FrameworkElement>
	{
		#region WindowAction 依存関係プロパティ

		public WindowAction WindowAction
		{
			get { return (WindowAction)this.GetValue(WindowActionProperty); }
			set { this.SetValue(WindowActionProperty, value); }
		}

		public static readonly DependencyProperty WindowActionProperty =
			DependencyProperty.Register("WindowAction", typeof (WindowAction), typeof (DirectWindowAction), new UIPropertyMetadata(WindowAction.Active));

		#endregion

		protected override void Invoke(object parameter)
		{
			this.WindowAction.Invoke(this.AssociatedObject);
		}
	}
}
>>>>>>> 816b6d0d09d9488b74b93cb9f673ea45b2a6acd2
