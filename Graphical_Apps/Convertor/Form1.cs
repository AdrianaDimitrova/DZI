namespace Convertor
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            double leva = double.Parse(textBox1.Text);
            if (leva >= 0)
            {
                double euro = leva / 1.95583;
                labelResult.Text = $"{leva:f2} BGN = {euro:f2} EUR";
            }
            else
            {
                labelResult.Text = "Сумата не може да бъде отрицателна!";
            }
            

        }
    }
}
