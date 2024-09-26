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

		private string _memo;

		private int _elapsedHour;
		private int _elapsedMinute;
		private int _elapsedSeconds;
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

			btnPauseTimer.Visible = false;
			btnPauseTimer.Enabled = false;

			txtMemo.Enabled = false;
			txtMemo.Visible = false;

			timerUtilities = new TimerUtilities();
			timer.Tick += TimerTick;
			DebugTimer();
		}

		private void TimerTick(object? sender, EventArgs e)
		{
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

			lblTimeElapsed.Text = timerUtilities.FormatDisplay(_elapsedHour, _elapsedMinute, _elapsedSeconds);
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
				txtMemo.Enabled = false;
				lblMemo.Visible = false;

				lblMemo.Enabled = true;
				lblMemo.Visible = true;

				_memo = txtMemo.Text;
				lblMemo.Text = _memo;
				e.SuppressKeyPress = true;
			}
		}
	}
}
