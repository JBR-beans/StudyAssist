namespace StudyAssist
{
	partial class Manager_AssistTimer
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			flpManagerAssistTimer = new FlowLayoutPanel();
			btnAddAssistTimer = new Button();
			SuspendLayout();
			// 
			// flpManagerAssistTimer
			// 
			flpManagerAssistTimer.Location = new Point(0, 32);
			flpManagerAssistTimer.Name = "flpManagerAssistTimer";
			flpManagerAssistTimer.Size = new Size(270, 268);
			flpManagerAssistTimer.TabIndex = 0;
			// 
			// btnAddAssistTimer
			// 
			btnAddAssistTimer.Location = new Point(192, 3);
			btnAddAssistTimer.Name = "btnAddAssistTimer";
			btnAddAssistTimer.Size = new Size(75, 23);
			btnAddAssistTimer.TabIndex = 1;
			btnAddAssistTimer.Text = "Add";
			btnAddAssistTimer.UseVisualStyleBackColor = true;
			btnAddAssistTimer.Click += btnAddAssistTimer_Click;
			// 
			// Manager_AssistTimer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnAddAssistTimer);
			Controls.Add(flpManagerAssistTimer);
			Name = "Manager_AssistTimer";
			Size = new Size(270, 300);
			Load += Manager_AssistTimer_Load;
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flpManagerAssistTimer;
		private Button btnAddAssistTimer;
	}
}
