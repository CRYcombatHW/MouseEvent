namespace MouseEvent
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e) {
			labelXValue.Text = e.X.ToString();
			labelYvalue.Text = e.Y.ToString();
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e) {
			MessageBox.Show(
				 $"{e.Button} mouse button click\nMouse Pos: X - {e.X}, Y - {e.Y}", 
				 "Mouse Click",
				 MessageBoxButtons.OK,
				 MessageBoxIcon.Information
			);
		}
	}
}