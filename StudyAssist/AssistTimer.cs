using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAssist
{
	public partial class AssistTimer : UserControl
	{
		private TimerUtilities timerUtilities;

		private string _memo = string.Empty;
		private string _placeholdertext = "Add memo...";

		private int _elapsedHour;
		private int _elapsedMinute;
		private int _elapsedSeconds;

		private int _remainingHour = 1;
		private int _remainingMinute;
		private int _remainingSeconds;

		public AssistTimer()
		{
			InitializeComponent();
		}

		private void AssistTimer_Load(object sender, EventArgs e)
		{
			btnStartTimer.Click += StartTimer;
			btnPauseTimer.Click += PauseTimer;

			lblMemo.Click += EditMemo;
			txtMemo.KeyDown += OnKeyDown;
			txtMemo.Click += EditMemo;

			lblTimeElapsed.Click += EditMaxTime;

			btnPauseTimer.Visible = false;
			btnPauseTimer.Enabled = false;

			txtMemo.Enabled = false;
			txtMemo.Visible = false;

			timerUtilities = new TimerUtilities();
			timer.Tick += TimerTick;
			//DebugTimer();
		}

		private void EditMaxTime(object? sender, EventArgs e)
		{
			
		}

		private void TimerTick(object? sender, EventArgs e)
		{
			//timerUtilities.CalculateElapsedTime(_elapsedHour, _elapsedMinute, _elapsedSeconds);
			//GetElapsedTime();

			timerUtilities.CalculateRemainingTimer(_remainingHour, _remainingMinute, _remainingSeconds);
			GetRemainingTime();

			//lblTimeElapsed.Text = timerUtilities.FormatDisplay(_elapsedHour, _elapsedMinute, _elapsedSeconds);
			lblTimeElapsed.Text = timerUtilities.FormatDisplay(_remainingHour, _remainingMinute, _remainingSeconds);
		}
		public void GetRemainingTime()
		{
			_remainingHour = timerUtilities.GetRemainingHour();
			_remainingMinute = timerUtilities.GetRemainingMinute();
			_remainingSeconds = timerUtilities.GetRemainingSecond();
		}
		public void GetElapsedTime()
		{
			_elapsedHour = timerUtilities.GetElapsedHour();
			_elapsedMinute = timerUtilities.GetElapsedMinute();
			_elapsedSeconds = timerUtilities.GetElapsedSecond();
		}


		private void DebugTimer()
		{
			_elapsedMinute = 59;
			_elapsedSeconds = 55;
		}

		private void StartTimer(object? sender, EventArgs e)
		{
			btnPauseTimer.Enabled = true;
			btnPauseTimer.Visible = true;
			btnStartTimer.Enabled = false;
			btnStartTimer.Visible = false;

			timer.Start();
		}
		private void PauseTimer(object? sender, EventArgs e)
		{
			btnStartTimer.Enabled = true;
			btnStartTimer.Visible = true;
			btnPauseTimer.Enabled = false;
			btnPauseTimer.Visible = false;

			timer.Stop();
		}

		private void EditMemo(object sender, EventArgs e)
		{
			this.Focus();
			txtMemo.Select();

			lblMemo.Enabled = false;
			lblMemo.Visible = false;

			txtMemo.Enabled = true;
			txtMemo.Visible = true;
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Enter))
			{
				if (txtMemo.Text == _placeholdertext || txtMemo.Text.Length < 1)
				{
					lblMemo.Text = _placeholdertext;
				}
				else
				{
					_memo = txtMemo.Text;
					lblMemo.Text = _memo;
				}

				txtMemo.Enabled = false;
				lblMemo.Visible = false;

				lblMemo.Enabled = true;
				lblMemo.Visible = true;

				e.SuppressKeyPress = true;
			}
		}

		private void lblTimeElapsed_Click(object sender, EventArgs e)
		{

		}
	}
}
