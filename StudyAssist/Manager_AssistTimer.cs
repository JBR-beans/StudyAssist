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
	public partial class Manager_AssistTimer : UserControl
	{
		private List<AssistTimer> _timers;
		private List<AssistTimer> _selectedtimers;
		private int _timercount;

		public Manager_AssistTimer()
		{
			InitializeComponent();
		}

		private void btnAddAssistTimer_Click(object sender, EventArgs e)
		{

		}

		private void Manager_AssistTimer_Load(object sender, EventArgs e)
		{
			btnAddAssistTimer.Click += AddNewAssistTimer;
			_timers = new List<AssistTimer>();
		}

		private void AddNewAssistTimer(object? sender, EventArgs e)
		{
			AssistTimer timer = new AssistTimer();
			
			_timers.Add(timer);

			flpManagerAssistTimer.Controls.Add(timer);

			_timercount++;
		}
	}
}
