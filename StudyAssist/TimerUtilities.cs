using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAssist
{
	internal class TimerUtilities
	{
		public string FormatDisplay(int hours, int minutes, int seconds)
		{
			string d_hour = hours.ToString();
			if (hours < 10)
			{
				d_hour = "0" + hours.ToString();
			}

			string d_minutes = minutes.ToString();
			if (minutes < 10)
			{
				d_minutes = "0" + minutes.ToString();
			}
			string d_seconds = seconds.ToString();
			if (seconds < 10)
			{
				d_seconds = "0" + seconds.ToString();
			}

			string display = string.Format("{0}:{1}:{2}", d_hour, d_minutes, d_seconds);
			return display;
		}
	}
}
