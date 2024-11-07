namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Option {  get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.label5.Text = "First and last name";

            logIn.textBox1.Visible = false;
            logIn.textBox2.Visible = false;
            logIn.label1.Visible = false;
            logIn.label2.Visible = false;
            Option = 1;
            logIn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.label5.Text = "Name of company";
            logIn.textBox1.Visible = true;
            logIn.label1.Visible = true;
            logIn.textBox2.Visible = false;
            logIn.label2.Visible = false;
            Option = 2;
            logIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.label5.Text = "Name of company";
            logIn.textBox1.Visible = true;
            logIn.label1.Visible = true;
            logIn.textBox2.Visible = true;
            logIn.label2.Visible = true;
            Option = 3;
            logIn.Show();
        }
    }
}