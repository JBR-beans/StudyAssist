using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAssist
{
	internal class TimerUtilities
	{
		private int _elapsedHour;
		private int _elapsedMinute;
		private int _elapsedSeconds;

		private int _remainingHour;
		private int _remainingMinute;
		private int _remainingSeconds;
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

		public void CalculateRemainingTimer(int hour, int minute, int second)
		{
			_remainingHour = hour;
			_remainingMinute = minute;
			_remainingSeconds = second;

			_remainingSeconds--;
			if (_remainingSeconds <= 0)
			{
				_remainingSeconds = 59;
				_remainingMinute--;
			}

			if (_remainingMinute <= 0)
			{
				_remainingMinute = 59;
				_remainingHour--;
			}
		}

		public void CalculateElapsedTime(int hour, int minute, int second)
		{
			_elapsedHour = hour;
			_elapsedMinute = minute;
			_elapsedSeconds = second;

			_elapsedSeconds++;
			if (_elapsedSeconds == 60)
			{
				_elapsedMinute++;
				_elapsedSeconds = 0;
			}

			if (_elapsedMinute == 60)
			{
				_elapsedHour++;
				_elapsedMinute = 0;
			}
		}
		
		public int GetRemainingHour() { return _remainingHour; }
		public int GetRemainingMinute() { return _remainingMinute; }
		public int GetRemainingSecond() { return _remainingSeconds; }

		public int GetElapsedHour() {  return _elapsedHour; }
		public int GetElapsedMinute() { return _elapsedMinute; }
		public int GetElapsedSecond() { return _elapsedSeconds; }
	}
}
