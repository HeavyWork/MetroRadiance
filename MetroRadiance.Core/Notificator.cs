<<<<<<< HEAD
﻿using MetroRadiance.Core.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MetroRadiance.Core
{
	/// <summary>
	/// プロパティの変更通知をサポートします。
	/// </summary>
	public class Notificator : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MetroRadiance.Core.Annotations;

namespace MetroRadiance.Core
{
	/// <summary>
	/// プロパティの変更通知をサポートします。
	/// </summary>
	public class Notificator : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
>>>>>>> 816b6d0d09d9488b74b93cb9f673ea45b2a6acd2
