namespace FOrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBox1.Text);
            double kelvin = celsius + 273.15;
            textBox2.Text = kelvin.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Celsius = double.Parse(textBox1.Text);
            double Fahenheit = Celsius * 1.8 + 32;
            textBox3.Text = Fahenheit.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}