namespace StudyAssist
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			assistTimer1 = new AssistTimer();
			flowLayoutPanel1 = new FlowLayoutPanel();
			assistTimer2 = new AssistTimer();
			assistTimer3 = new AssistTimer();
			assistTimer4 = new AssistTimer();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// assistTimer1
			// 
			assistTimer1.Location = new Point(3, 76);
			assistTimer1.Margin = new Padding(3, 2, 3, 2);
			assistTimer1.Name = "assistTimer1";
			assistTimer1.Size = new Size(262, 70);
			assistTimer1.TabIndex = 0;
			assistTimer1.Load += assistTimer1_Load;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(assistTimer2);
			flowLayoutPanel1.Controls.Add(assistTimer1);
			flowLayoutPanel1.Controls.Add(assistTimer3);
			flowLayoutPanel1.Controls.Add(assistTimer4);
			flowLayoutPanel1.Location = new Point(3, 9);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(269, 300);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// assistTimer2
			// 
			assistTimer2.Location = new Point(3, 2);
			assistTimer2.Margin = new Padding(3, 2, 3, 2);
			assistTimer2.Name = "assistTimer2";
			assistTimer2.Size = new Size(262, 70);
			assistTimer2.TabIndex = 1;
			// 
			// assistTimer3
			// 
			assistTimer3.Location = new Point(3, 150);
			assistTimer3.Margin = new Padding(3, 2, 3, 2);
			assistTimer3.Name = "assistTimer3";
			assistTimer3.Size = new Size(262, 70);
			assistTimer3.TabIndex = 2;
			// 
			// assistTimer4
			// 
			assistTimer4.Location = new Point(3, 224);
			assistTimer4.Margin = new Padding(3, 2, 3, 2);
			assistTimer4.Name = "assistTimer4";
			assistTimer4.Size = new Size(262, 70);
			assistTimer4.TabIndex = 3;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(275, 321);
			Controls.Add(flowLayoutPanel1);
			Margin = new Padding(3, 2, 3, 2);
			MinimumSize = new Size(291, 360);
			Name = "frmMain";
			Text = "Main";
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private AssistTimer assistTimer1;
		private FlowLayoutPanel flowLayoutPanel1;
		private AssistTimer assistTimer2;
		private AssistTimer assistTimer3;
		private AssistTimer assistTimer4;
	}
}
