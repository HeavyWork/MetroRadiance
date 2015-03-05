using MetroRadiance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MetroRadiance
{
	public class CustomTheme
	{
		string MainFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
		public List<CustomThemeStruct> ReadThemeFile()
		{
			if (!File.Exists(Path.Combine(MainFolder, "Bin", "Custom.CTheme"))) return null;

			var items = new List<CustomThemeStruct>();
			var bytes = File.ReadAllBytes(Path.Combine(MainFolder, "Bin", "Custom.CTheme"));
			using (var memoryStream = new MemoryStream(bytes))
			using (var reader = new BinaryReader(memoryStream))
			{
				while (memoryStream.Position < memoryStream.Length)
				{
					items.Add(new CustomThemeStruct
					{
						Key = reader.ReadString(),
						ColorKey = reader.ReadString()
					});
				}
			}
			return items;
		}
		public void CustomThemeApplyer()
		{
			var items = new List<CustomThemeStruct>(ReadThemeFile());
			if (items != null)
			{
				foreach (var item in items)
				{
					var test = System.Drawing.ColorTranslator.FromHtml(item.ColorKey);
					var temp = new List<string>();
					temp.Add(item.Key);
					ThemeService.Current.ChangePartColor(temp, Color.FromArgb(test.A, test.R, test.G, test.B));
				}
			}
		}
	}
}
