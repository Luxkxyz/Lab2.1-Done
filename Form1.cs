namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int arryIndex = 0;
        int Max = 0;
        int Min = 100000000;
        string[] arryID = new string[1000000];
        string[] arryName = new string[100000];
        int[] arryPoint = new int[100000];
        int summe = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBinputID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBinputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBinputPoint_TextChanged(object sender, EventArgs e)
        {

        }


        private void Save_Click(object sender, EventArgs e)
        {

            string inputID = TBinputID.Text;
            string inputname = TBinputName.Text;
            int inputpoint = int.Parse(TBinputPoint.Text);



            arryID[arryIndex] = inputID;
            arryName[arryIndex] = inputname;
            arryPoint[arryIndex] = inputpoint;
            arryIndex++;

            TBinputPoint.Text = inputpoint.ToString();

            if (inputpoint > Max)
            {
                Max = inputpoint;
                HighID.Text = inputID;
                HighName.Text = inputname;
                Highpoint.Text = inputpoint.ToString();
                Min = Max;
            }

            if (inputpoint < Min)
            {
                Min = inputpoint;
                LowID.Text = inputID;
                LowName.Text = inputname;
                Lowpoint.Text = inputpoint.ToString();


            }
            int summe = Max + Min;
            double summe2 = summe / 2;
            string summe3 = summe2.ToString();
            average.Text = summe3;
        }

        private void HighID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
