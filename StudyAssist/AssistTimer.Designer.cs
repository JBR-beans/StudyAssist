namespace StudyAssist
{
	partial class AssistTimer
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
			components = new System.ComponentModel.Container();
			btnStartTimer = new Button();
			btnPauseTimer = new Button();
			lblTimeElapsed = new Label();
			timer = new System.Windows.Forms.Timer(components);
			txtMemo = new TextBox();
			lblMemo = new Label();
			chxSelectTimer = new CheckBox();
			SuspendLayout();
			// 
			// btnStartTimer
			// 
			btnStartTimer.Location = new Point(206, 2);
			btnStartTimer.Margin = new Padding(3, 2, 3, 2);
			btnStartTimer.Name = "btnStartTimer";
			btnStartTimer.Size = new Size(53, 22);
			btnStartTimer.TabIndex = 0;
			btnStartTimer.Text = "Start";
			btnStartTimer.UseVisualStyleBackColor = true;
			// 
			// btnPauseTimer
			// 
			btnPauseTimer.Location = new Point(206, 2);
			btnPauseTimer.Margin = new Padding(3, 2, 3, 2);
			btnPauseTimer.Name = "btnPauseTimer";
			btnPauseTimer.Size = new Size(53, 22);
			btnPauseTimer.TabIndex = 1;
			btnPauseTimer.Text = "Pause";
			btnPauseTimer.UseVisualStyleBackColor = true;
			// 
			// lblTimeElapsed
			// 
			lblTimeElapsed.AutoSize = true;
			lblTimeElapsed.Location = new Point(151, 6);
			lblTimeElapsed.Name = "lblTimeElapsed";
			lblTimeElapsed.Size = new Size(49, 15);
			lblTimeElapsed.TabIndex = 2;
			lblTimeElapsed.Text = "00:00:00";
			lblTimeElapsed.Click += lblTimeElapsed_Click;
			// 
			// timer
			// 
			timer.Interval = 1000;
			// 
			// txtMemo
			// 
			txtMemo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtMemo.Location = new Point(3, 27);
			txtMemo.Margin = new Padding(3, 2, 3, 2);
			txtMemo.MaxLength = 75;
			txtMemo.Multiline = true;
			txtMemo.Name = "txtMemo";
			txtMemo.PlaceholderText = "Add memo...";
			txtMemo.Size = new Size(258, 42);
			txtMemo.TabIndex = 3;
			// 
			// lblMemo
			// 
			lblMemo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblMemo.Location = new Point(3, 27);
			lblMemo.Name = "lblMemo";
			lblMemo.Size = new Size(256, 42);
			lblMemo.TabIndex = 4;
			lblMemo.Text = "Add memo...";
			lblMemo.Click += EditMemo;
			// 
			// chxSelectTimer
			// 
			chxSelectTimer.AutoSize = true;
			chxSelectTimer.Location = new Point(3, 3);
			chxSelectTimer.Name = "chxSelectTimer";
			chxSelectTimer.Size = new Size(15, 14);
			chxSelectTimer.TabIndex = 5;
			chxSelectTimer.UseVisualStyleBackColor = true;
			// 
			// AssistTimer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(chxSelectTimer);
			Controls.Add(lblMemo);
			Controls.Add(txtMemo);
			Controls.Add(lblTimeElapsed);
			Controls.Add(btnPauseTimer);
			Controls.Add(btnStartTimer);
			Margin = new Padding(3, 2, 3, 2);
			Name = "AssistTimer";
			Size = new Size(262, 70);
			Load += AssistTimer_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnStartTimer;
		private Button btnPauseTimer;
		private Label lblTimeElapsed;
		private System.Windows.Forms.Timer timer;
		private TextBox txtMemo;
		private Label lblMemo;
		private CheckBox chxSelectTimer;
	}
}
