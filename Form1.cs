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
            int sum = 0;

            if (bool128.Checked)
                sum += 128;
            if (bool64.Checked)
                sum += 64;
            if (bool32.Checked)
                sum += 32;
            if (bool16.Checked)
                sum += 16;
            if (bool8.Checked)
                sum += 8;
            if (bool4.Checked)
                sum += 4;
            if (bool2.Checked)
                sum += 2;
            if (bool1.Checked)
                sum += 1;

            outputBits.Text = sum.ToString();
        }

        private void bool128_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool64_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool32_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool16_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool8_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool4_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool2_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void bool1_CheckedChanged(object sender, EventArgs e)
        {
            updateOut();
        }

        private void outputBits_TextChanged(object sender, EventArgs e)
        {
         //TODO: make a stable in/out system.
        }
    }
}