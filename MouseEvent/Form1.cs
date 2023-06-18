namespace MouseEvent
{
	public partial class Form1 : Form
	{
		private bool IsDrawMousePath;

		public Form1() {
			InitializeComponent();
			IsDrawMousePath = false;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e) {
			labelXValue.Text = e.X.ToString();
			labelYvalue.Text = e.Y.ToString();

			if (IsDrawMousePath) {
				Label lbl = new Label();
				if (e.Button == MouseButtons.Left)
					lbl.Text = "⬛";
				else if (e.Button == MouseButtons.Right)
					lbl.Text = "⚫";
				else
					lbl.Text = "▲";

				lbl.Location = e.Location;
				lbl.Font = new Font("Roboto", (int)numericUpDown1.Value);
				lbl.AutoSize = true;


				Controls.Add(lbl);
			}
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e) {
			Form1_MouseMove(sender, e);
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e) {
			IsDrawMousePath = true;
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e) {
			IsDrawMousePath = false;
		}
	}
}