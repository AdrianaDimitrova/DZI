namespace Time_15_Minutes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(numericUpDownHour.Text);
            int minutes = int.Parse(numericUpDownMinutes.Text);

            minutes += 15;

            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours = 0;
            }

            label4Result.Text = $"{hours}:{minutes}";

        }
    }
}
