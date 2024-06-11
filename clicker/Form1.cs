namespace clicker
{
    public partial class Form1 : Form
    {

        int countt = 0;
        Delay delay = new();
        void click()
        {
            if (pictureBox1.Image == Resource1.cooky2)
            {
                countt++;
                label1.Text = "Count: " + countt;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void changePicture()
        {
            pictureBox1.Image = Resource1.cooky1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resource1.cooky2;
            delay.Start(timer1, 3, changePicture);
            click();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            delay.Tick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}