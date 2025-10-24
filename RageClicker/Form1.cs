namespace RageClicker
{
    public partial class Form1 : Form
    {
        int score = 0;  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = "Score: " + score;
        }
    }
}
