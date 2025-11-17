namespace LawLab4
{
    public partial class frmMain : Form
    {
        const int SIZE = 5;
        const string MYNAME = "Tyler Law";

        int index = 0;
        double[] taxlist = new double[SIZE];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            radPrimaryResidence.Checked = true;
            lblNumberDisplay.Text = (index + 1).ToString("D2");
        }

        private void ResetForm()
        {
            txtPropertyValue.Text = string.Empty;
            btnCalculate.Enabled = true;

            lblPropertyTaxDisplay.Text = string.Empty;
            lblAverageDisplay.Text = string.Empty;

            index += 1;

            lblNumberDisplay.Text = (index + 1).ToString("D2");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                const double MINVALUE = 50000;
                const double MAXVALUE = 1500000;

                const double TAX_PRIMARY = 0.01714;
                const double TAX_NONPRIMARY = 0.02275;
                const double TAX_COMMERCIAL = 0.027518;

                double dblPropertyValue;

                bool boolIsNumberDouble = double.TryParse(txtPropertyValue.Text, out dblPropertyValue);

                switch (boolIsNumberDouble)
                {
                    case true:

                        double dblPropertyTax = 0.0;

                        int indexDisplay = index + 1;

                        if (dblPropertyValue >= MINVALUE && dblPropertyValue <= MAXVALUE)
                        {
                            // Calculate tax based on 
                            if (radPrimaryResidence.Checked)
                            {
                                dblPropertyTax = dblPropertyValue * TAX_PRIMARY;
                            }
                            else if (radNonPrimaryResidence.Checked)
                            {
                                dblPropertyTax = dblPropertyValue * TAX_NONPRIMARY;
                            }
                            else
                            {
                                dblPropertyTax = dblPropertyValue * TAX_COMMERCIAL;
                            }

                            // Add prop. tax to array at current index
                            taxlist[index] = dblPropertyTax;

                            // Get average using values stored
                            double dblAvg = GetAverageCost();

                            lblPropertyTaxDisplay.Text = dblPropertyTax.ToString("c2");

                            string strMessage = $"Entry: {indexDisplay.ToString("D2")} Tax: {dblPropertyTax.ToString("c2")}\n";
                            lblEntriesDisplay.Text += strMessage;

                            lblAverageDisplay.Text = dblAvg.ToString("c2");

                            btnCalculate.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("The number you have entered must be between $50000 and $1500000." +
                            "\nPlease enter a number within range.", MYNAME);
                        }

                    break;

                    default:

                        MessageBox.Show("The number you have entered is not a double. Please enter a double.", MYNAME);

                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured.\n{ex.Message}", MYNAME);
            }
        }

        private double GetAverageCost()
        {
            // Fix later
            int i;
            double totalInArray = 0.0;

            double average = 0.0;

            int intCurrentLength = index + 1;

            for (i = 0; i < intCurrentLength; i++)
            {
                totalInArray += taxlist[i];
            }

            average = totalInArray / intCurrentLength;

            return average;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
