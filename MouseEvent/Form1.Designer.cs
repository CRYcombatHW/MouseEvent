namespace MouseEvent
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			labelXText = new Label();
			labelYText = new Label();
			labelXValue = new Label();
			labelYvalue = new Label();
			numericUpDown1 = new NumericUpDown();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(65, 15);
			label1.TabIndex = 0;
			label1.Text = "Mouse Pos";
			// 
			// labelXText
			// 
			labelXText.AutoSize = true;
			labelXText.Location = new Point(12, 34);
			labelXText.Name = "labelXText";
			labelXText.Size = new Size(17, 15);
			labelXText.TabIndex = 1;
			labelXText.Text = "X:";
			// 
			// labelYText
			// 
			labelYText.AutoSize = true;
			labelYText.Location = new Point(12, 49);
			labelYText.Name = "labelYText";
			labelYText.Size = new Size(17, 15);
			labelYText.TabIndex = 2;
			labelYText.Text = "Y:";
			// 
			// labelXValue
			// 
			labelXValue.AutoSize = true;
			labelXValue.Location = new Point(39, 34);
			labelXValue.Name = "labelXValue";
			labelXValue.Size = new Size(0, 15);
			labelXValue.TabIndex = 3;
			// 
			// labelYvalue
			// 
			labelYvalue.AutoSize = true;
			labelYvalue.Location = new Point(39, 49);
			labelYvalue.Name = "labelYvalue";
			labelYvalue.Size = new Size(0, 15);
			labelYvalue.TabIndex = 4;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(12, 105);
			numericUpDown1.Maximum = new decimal(new int[] { 42, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(45, 23);
			numericUpDown1.TabIndex = 5;
			numericUpDown1.Value = new decimal(new int[] { 8, 0, 0, 0 });
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 87);
			label2.Name = "label2";
			label2.Size = new Size(68, 15);
			label2.TabIndex = 6;
			label2.Text = "Figures Size";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(929, 506);
			Controls.Add(label2);
			Controls.Add(numericUpDown1);
			Controls.Add(labelYvalue);
			Controls.Add(labelXValue);
			Controls.Add(labelYText);
			Controls.Add(labelXText);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			MouseClick += Form1_MouseClick;
			MouseDown += Form1_MouseDown;
			MouseMove += Form1_MouseMove;
			MouseUp += Form1_MouseUp;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label labelXText;
		private Label labelYText;
		private Label labelXValue;
		private Label labelYvalue;
		private NumericUpDown numericUpDown1;
		private Label label2;
	}
}