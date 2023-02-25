namespace catchTheCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        tmr.Enabled = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr.Enabled = true;
            redCar.Left += rnd.Next(3, 10);
            yellowCar.Left += rnd.Next(3, 10);

        }
        private void baslatButton_Click(object sender, EventArgs e)
        {

            tmr.Enabled = true;
            redCar.Left += rnd.Next(3, 10);
            yellowCar.Left += rnd.Next(3, 10);





        }


    }
}