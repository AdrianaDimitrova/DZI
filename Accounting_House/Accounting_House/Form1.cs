namespace Accounting_House
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;
            double discount = 0.0;

            if (!double.TryParse(textBox1.Text, out discount))
            {
                discount = 0.0;
            }

            double price = 0.0;

            if (checkBox1.Checked == true)
            {
                price += 25.0;
            }
            if (checkBox2.Checked == true)
            {
                price += 18.50;
            }
            if (checkBox3.Checked == true)
            {
                price += 22.10;
            }
            if (checkBox4.Checked == true)
            {
                price += 31.99;
            }
            if (checkBox5.Checked == true)
            {
                price += 1.00;
            }
            if (checkBox6.Checked == true)
            {
                price += 1.50;
            }
            if (checkBox7.Checked == true)
            {
                price += 2.00;
            }
            if (checkBox8.Checked == true)
            {
                price += 0.50;
            }
            if (checkBox9.Checked == true)
            {
                price += 0.40;
            }
            if (checkBox10.Checked == true)
            {
                price += 0.20;
            }
            if (checkBox11.Checked == true)
            {
                price += 0.50;
            }

            double baseTotal = price * quantity;
            double total = baseTotal - (baseTotal * (discount / 100));
            labelResult.Text = $"{total:f2} €";
        }
    }
}
         
     
    

   


        
    

