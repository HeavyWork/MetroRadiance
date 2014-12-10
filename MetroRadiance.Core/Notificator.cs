using MetroRadiance.Core.Annotations;
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
