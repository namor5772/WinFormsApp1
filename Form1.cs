namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SplashForm splash = new SplashForm();
            splash.Show();


            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Size = new Size(816, 489);
            label1.Text = "TIMER FINISHED";
            WindowState = FormWindowState.Normal;
        }
    }
}