using System.Diagnostics.Eventing.Reader;

namespace LawLab4
{
    public partial class frmMain : Form
    {
        const int SIZE = 5;
        const string MYNAME = "Tyler Law";

        int intIndex = 0;
        double[] dblTaxList = new double[SIZE];
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
            intIndex = 0;
            Array.Clear(dblTaxList, 0, dblTaxList.Length);

            lblEntriesDisplay.Text = string.Empty;

            txtPropertyValue.Text = string.Empty;

            btnCalculate.Enabled = true;
            btnReset.Enabled = false;

            lblPropertyTaxDisplay.Text = string.Empty;
            lblAverageDisplay.Text = string.Empty;

            radPrimaryResidence.Checked = true;
            lblNumberDisplay.Text = (intIndex + 1).ToString("D2");
        }

        private void ResetForm()
        {
            txtPropertyValue.Text = string.Empty;
            btnCalculate.Enabled = true;

            lblPropertyTaxDisplay.Text = string.Empty;
            lblAverageDisplay.Text = string.Empty;

            intIndex += 1;

            lblNumberDisplay.Text = (intIndex + 1).ToString("D2");

            btnReset.Enabled = false;
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

                        int indexDisplay = intIndex + 1;

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
                            dblTaxList[intIndex] = dblPropertyTax;

                            // Get average using values stored
                            double dblAvg = GetAverageCost();

                            lblPropertyTaxDisplay.Text = dblPropertyTax.ToString("c2");

                            string strMessage = $"Entry: {indexDisplay.ToString("D2")} Tax: {dblPropertyTax.ToString("c2")}\n";
                            lblEntriesDisplay.Text += strMessage;

                            lblAverageDisplay.Text = dblAvg.ToString("c2");

                            btnCalculate.Enabled = false;
                            btnReset.Enabled = true;
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
            int i;
            double dblTotalInArray = 0.0;

            double dblAverage = 0.0;

            int intCurrentLength = intIndex + 1;

            for (i = 0; i < intCurrentLength; i++)
            {
                dblTotalInArray += dblTaxList[i];
            }

            dblAverage = dblTotalInArray / intCurrentLength;

            return dblAverage;
        }

        private bool IsMaxLength()
        {
            const int MAXLENGTH = 4;
            bool boolIsMax;

            if (intIndex == MAXLENGTH)
                boolIsMax = true;
            else
                boolIsMax = false;

            return boolIsMax;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (IsMaxLength())
            {
                DialogResult dialogSelection;

                dialogSelection =
                    MessageBox.Show("Maximum of 5 list entries reached.\nWould you like to restart?",
                    MYNAME,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogSelection == DialogResult.Yes)
                {
                    InitializeForm();
                }
                else
                {
                    CloseProgram();
                }
            }
            else
                ResetForm();
        }

        private void CloseProgram()
        {
            MessageBox.Show("Closing the program. Have a nice day!", MYNAME, MessageBoxButtons.YesNo);
            Close();
        }
    }
}
