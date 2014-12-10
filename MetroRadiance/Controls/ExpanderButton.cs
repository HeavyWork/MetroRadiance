<<<<<<< HEAD
﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MetroRadiance.Controls
{
	public class ExpanderButton : ToggleButton
	{
		static ExpanderButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpanderButton), new FrameworkPropertyMetadata(typeof(ExpanderButton)));
		}


		#region Direction 依存関係プロパティ

		public ExpandDirection Direction
		{
			get { return (ExpandDirection)this.GetValue(DirectionProperty); }
			set { this.SetValue(DirectionProperty, value); }
		}

		public static readonly DependencyProperty DirectionProperty =
			DependencyProperty.Register("Direction", typeof(ExpandDirection), typeof(ExpanderButton), new UIPropertyMetadata(ExpandDirection.Left, DirectionChangedCallback));

		private static void DirectionChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//var instance = (ExpanderButton)d;
		}

		#endregion

	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MetroRadiance.Controls
{
	public class ExpanderButton : ToggleButton
	{
		static ExpanderButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpanderButton), new FrameworkPropertyMetadata(typeof(ExpanderButton)));
		}


		#region Direction 依存関係プロパティ

		public ExpandDirection Direction
		{
			get { return (ExpandDirection)this.GetValue(DirectionProperty); }
			set { this.SetValue(DirectionProperty, value); }
		}

		public static readonly DependencyProperty DirectionProperty =
			DependencyProperty.Register("Direction", typeof(ExpandDirection), typeof(ExpanderButton), new UIPropertyMetadata(ExpandDirection.Left, DirectionChangedCallback));

		private static void DirectionChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//var instance = (ExpanderButton)d;
		}

		#endregion

	}
}
>>>>>>> 816b6d0d09d9488b74b93cb9f673ea45b2a6acd2
