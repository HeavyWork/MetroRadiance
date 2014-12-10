<<<<<<< HEAD
﻿using System;
using System.Globalization;
using System.Windows.Controls;

namespace MetroRadiance.Controls
{
	/// <summary>
	/// 入力された値が有効な <see cref="Int32"/> 値かどうかを検証します。
	/// </summary>
	public class Int32Rule : ValidationRule
	{
		/// <summary>
		/// 入力に空文字を許可するかどうかを示す値を取得または設定します。
		/// </summary>
		public bool AllowsEmpty { get; set; }

		/// <summary>
		/// 入力可能な最小値を取得または設定します。
		/// </summary>
		/// <value>
		/// 入力可能な最小値。最小値がない場合は null。
		/// </value>
		public int? Min { get; set; }

		/// <summary>
		/// 入力可能な最大値を取得または設定します。
		/// </summary>
		/// <value>
		/// 入力可能な最大値。最大値がない場合は null。
		/// </value>
		public int? Max { get; set; }


		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			var numberAsString = value as string;
			if (string.IsNullOrEmpty(numberAsString))
			{
				return this.AllowsEmpty
					? new ValidationResult(true, null)
					: new ValidationResult(false, "값을 입력해주세요");
			}

			int number;
			try
			{
				number = int.Parse(numberAsString);
			}
			catch (Exception)
			{
				return new ValidationResult(false, "수치를 입력해주세요");
			}

			if (this.Min.HasValue && number < this.Min)
			{
				return new ValidationResult(false, string.Format("{0} 이상의 수치를 입력해주세요", this.Min));
			}

			if (this.Max.HasValue && this.Max < number)
			{
				return new ValidationResult(false, string.Format("{0} 이하의 수치를 입력해주세요", this.Max));
			}

			return new ValidationResult(true, null);
		}
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MetroRadiance.Controls
{
	/// <summary>
	/// 入力された値が有効な <see cref="Int32"/> 値かどうかを検証します。
	/// </summary>
	public class Int32Rule : ValidationRule
	{
		/// <summary>
		/// 入力に空文字を許可するかどうかを示す値を取得または設定します。
		/// </summary>
		public bool AllowsEmpty { get; set; }

		/// <summary>
		/// 入力可能な最小値を取得または設定します。
		/// </summary>
		/// <value>
		/// 入力可能な最小値。最小値がない場合は null。
		/// </value>
		public int? Min { get; set; }

		/// <summary>
		/// 入力可能な最大値を取得または設定します。
		/// </summary>
		/// <value>
		/// 入力可能な最大値。最大値がない場合は null。
		/// </value>
		public int? Max { get; set; }


		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			var numberAsString = value as string;
			if (string.IsNullOrEmpty(numberAsString))
			{
				return this.AllowsEmpty
					? new ValidationResult(true, null)
					: new ValidationResult(false, "값을 입력해주세요");
			}

			int number;
			try
			{
				number = int.Parse(numberAsString);
			}
			catch (Exception)
			{
				return new ValidationResult(false, "수치를 입력해주세요");
			}

			if (this.Min.HasValue && number < this.Min)
			{
				return new ValidationResult(false, string.Format("{0} 이상의 수치를 입력해주세요", this.Min));
			}

			if (this.Max.HasValue && this.Max < number)
			{
				return new ValidationResult(false, string.Format("{0} 이하의 수치를 입력해주세요", this.Max));
			}

			return new ValidationResult(true, null);
		}
	}
}
>>>>>>> 816b6d0d09d9488b74b93cb9f673ea45b2a6acd2
