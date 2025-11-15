namespace LawLab4
{
    public partial class frmMain : Form
    {
        const int SIZE = 5;
        const string MYNAME = "Tyler Law";

        int index = 0;
        int[] taxlist = new int[SIZE];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ResetForm()
        {
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int MINVALUE = 50000;
            const int MAXVALUE = 1500000;
        }

        private double GetAverage()
        {
            int i;
            double totalInArray = 0.0;
            double average = 0.0;

            for (i = 0; i < taxlist.Length; i++)
            {
                totalInArray += taxlist[i];
            }

            average = totalInArray / taxlist.Length;

            return average;
        }
    }
}
