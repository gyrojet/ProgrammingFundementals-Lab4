using System.Diagnostics.Eventing.Reader;

namespace LawLab4
{
    /* Name: Tyler Law
     * Date: Nov. 2nd, 2025
     * This program calculates the tax values of a property, with settings for primary, non-primary and commercial taxes.
     * Each tax is stored in an array, prompting the user to reset after 5 runs.
     */
    public partial class frmMain : Form
    {
        // Array size
        const int SIZE = 5;

        // My name! Used for messageboxes
        const string MYNAME = "Tyler Law";

        // The array's current index
        int intIndex = 0;

        // An array to store property taxes
        double[] dblTaxList = new double[SIZE];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Initialize form
            InitializeForm();
        }

        /* Name: InitializeForm
         * Returns: Nothing
         * This function resets the form to it's initial state by clearing labels & textboxes,
         * setting radiobuttons to their default values and emptying out the array.
         */
        private void InitializeForm()
        {
            // Reset the index
            intIndex = 0;

            // Set all elements of the array to 0
            Array.Clear(dblTaxList, 0, dblTaxList.Length);

            // Empty entry label
            lblEntriesDisplay.Text = string.Empty;

            // Empty textbox
            txtPropertyValue.Text = string.Empty;

            // Enable calculatebutton, disable reset button
            btnCalculate.Enabled = true;
            btnReset.Enabled = false;

            // Empty tax, average labels
            lblPropertyTaxDisplay.Text = string.Empty;
            lblAverageDisplay.Text = string.Empty;

            // Set radiobuttons to default value
            radPrimaryResidence.Checked = true;

            // Set default number display
            lblNumberDisplay.Text = (intIndex + 1).ToString("D2");
        }

        /* Name: ResetForm
         * Returns: Nothing
         * This function resets the form for the next transaction by clearing labels, textboxes and 
         * enabling buttons.
         */
        private void ResetForm()
        {
            // Empty textbox
            txtPropertyValue.Text = string.Empty;

            // Reenable calculate button
            btnCalculate.Enabled = true;

            // Empty tax, average labels
            lblPropertyTaxDisplay.Text = string.Empty;
            lblAverageDisplay.Text = string.Empty;

            // Increment index by 1
            intIndex += 1;

            // Display new index
            lblNumberDisplay.Text = (intIndex + 1).ToString("D2");

            // Disable reset button
            btnReset.Enabled = false;

            // Place cursor in textbox
            txtPropertyValue.Focus();
        }

        /* Name: btnCalculate_Click
         * Returns: Nothing
         * This event calculates the user's property tax based on 3 options: primary, non-primary and commercial.
         * The program checks to see if the user has entered a double, then checks to see if it falls within the appropriate range (50,000 - 1,500,000).
         * If it is, then the program calculates the property tax for the building and the average of all calculated taxes so far.
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Minimum and maximum values the user must enter between
                const double MINVALUE = 50000;
                const double MAXVALUE = 1500000;

                // The 3 tax rates
                const double TAX_PRIMARY = 0.01714;
                const double TAX_NONPRIMARY = 0.02275;
                const double TAX_COMMERCIAL = 0.027518;

                // Stores property alue
                double dblPropertyValue;

                // Converts entered number to double, if possible
                bool boolIsNumberDouble = double.TryParse(txtPropertyValue.Text, out dblPropertyValue);

                // Check value of boolean
                switch (boolIsNumberDouble)
                {
                    // If number is a double:
                    case true:

                        // Stores tax value
                        double dblPropertyTax = 0.0;

                        // Index to display
                        int indexDisplay = intIndex + 1;

                        // If the user's value is between and min and max values:
                        if (dblPropertyValue >= MINVALUE && dblPropertyValue <= MAXVALUE)
                        {
                            // Calculate tax based on the checked option
                            // Primary
                            if (radPrimaryResidence.Checked)
                            {
                                // Calculate tax value
                                dblPropertyTax = dblPropertyValue * TAX_PRIMARY;
                            }
                            // Non-Primary
                            else if (radNonPrimaryResidence.Checked)
                            {
                                // Calculate tax value
                                dblPropertyTax = dblPropertyValue * TAX_NONPRIMARY;
                            }
                            // Commercial
                            else
                            {
                                // Calculate tax value
                                dblPropertyTax = dblPropertyValue * TAX_COMMERCIAL;
                            }

                            // Add prop. tax to array at current index
                            dblTaxList[intIndex] = dblPropertyTax;

                            // Get average using values stored in array
                            double dblAvg = GetAverageCost();

                            // Display new number 
                            lblPropertyTaxDisplay.Text = dblPropertyTax.ToString("c2");
                            
                            // List entry
                            string strMessage = $"Entry: {indexDisplay.ToString("D2")} Tax: {dblPropertyTax.ToString("c2")}\n";

                            // Add entry to label
                            lblEntriesDisplay.Text += strMessage;

                            // Format and display average
                            lblAverageDisplay.Text = dblAvg.ToString("c2");

                            // Disable calculate, re-enable reset
                            btnCalculate.Enabled = false;
                            btnReset.Enabled = true;
                        }
                        else // If number was not in range:
                        {
                            // Display error message
                            MessageBox.Show($"The number you have entered must be between {MINVALUE.ToString("c2")} and {MAXVALUE.ToString("c2")}." +
                            "\nPlease enter a number within range.", MYNAME, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            // Select and focus on textbox
                            SelectTextbox();
                        }

                    break;

                    // If the user's input was not a double:
                    default:
                        // Display error message
                        MessageBox.Show("The number you have entered is not a double. Please enter a double.", MYNAME, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        // Select textbox, focus on it
                        SelectTextbox();

                    break;
                }
            }
            catch (Exception ex)
            {
                // Catch message, if there is an error
                MessageBox.Show($"An error occured.\n{ex.Message}", MYNAME, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // Select textbox, focus on it
                SelectTextbox();
            }
        }

        /* Name: SelectTextbox
         * Returns: Nothing
         * This function selects all text in the user's textbox, then places the cursor on it.
         */
        private void SelectTextbox()
        {
            // Select all text in textbox
            txtPropertyValue.SelectAll();

            // Place cursor on textbox
            txtPropertyValue.Focus();
        }

        /* Name: GetAverageCost
         * Returns: double
         * This function gets the average cost of all taxes currently stored in the array. 
         * It does this by using the value of the index to add only the current values in the array.
         * Example: If this is entry 3, the program will add up the first 3 items, then divide by 3.
         * It does this by using the index variable to set a stopping point, ensuring the program doesn't check the later entries in the array.
         */
        private double GetAverageCost()
        {
            // Loop counter
            int i;

            // Stores total array value
            double dblTotalInArray = 0.0;

            // Stores average value
            double dblAverage = 0.0;

            // Current length = index plus 1
            int intCurrentLength = intIndex + 1;

            // Loop through array up to current length
            for (i = 0; i < intCurrentLength; i++)
            {
                // Add tax to total
                dblTotalInArray += dblTaxList[i];
            }

            // Divide total by current length
            dblAverage = dblTotalInArray / intCurrentLength;

            // Return the average value
            return dblAverage;
        }

        /* Name: IsMaxLength
         * Returns: bool
         * This function checks to see if the value of index is equal to the max length of the array, in this case 4.
         * It is is, the value is truel otherwise it is false.
         * This value is then returned.
         */
        private bool IsMaxLength()
        { 
            // Current array length
            int intLength = intIndex + 1;

            // bool to store results
            bool boolIsMax;

            // If length = max size:
            if (intLength == SIZE)
                // Valie is true
                boolIsMax = true;
            else // Otherwise:
                // Value is false
                boolIsMax = false;

            // Return value
            return boolIsMax;
        }

        /* Name: btnReset_Click
         * Returns: Nothing
         * This event checks the current value of the index; If it is at it's max value, the program will prompt the user to either initialize the form again or quit.
         * Otherwise, it will reset the form.
         */ 
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Checks to see if max length has been reached
            if (IsMaxLength())
            {
                // Holds messagebox results
                DialogResult dialogSelection;

                // Gives user option to restart or quit
                dialogSelection =
                    MessageBox.Show("Maximum number of list entries reached.\nWould you like to restart?",
                    MYNAME,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                // If user selects to restart
                if (dialogSelection == DialogResult.Yes)
                {
                    // Initialize form
                    InitializeForm();
                }
                else // If user selected to quit
                {
                    // Close program
                    CloseProgram();
                }
            }
            else // If max length was not reached
                // Reset the form
                ResetForm();
        }

        /* Name: CloseProgram
         * Returns: Nothing
         * This function displays a farewell message, then closes the form.
         */
        private void CloseProgram()
        {
            // Display message
            MessageBox.Show("Closing the program. Have a nice day!", MYNAME, MessageBoxButtons.OK);

            // Close form
            Close();
        }
    }
}
