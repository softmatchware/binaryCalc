namespace binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateOut()
        {
            // Calculate the sum in a branchless manner using bitwise operations
            int sum = (bool128.Checked ? 128 : 0) |
                      (bool64.Checked ? 64 : 0) |
                      (bool32.Checked ? 32 : 0) |
                      (bool16.Checked ? 16 : 0) |
                      (bool8.Checked ? 8 : 0) |
                      (bool4.Checked ? 4 : 0) |
                      (bool2.Checked ? 2 : 0) |
                      (bool1.Checked ? 1 : 0);

            outputBits.Text = sum.ToString();
        }

        private void bool_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void outputBits_TextChanged(object sender, EventArgs e)
        {
            //TODO: make a stable in/out system.
        }
    }
}