namespace LawLab4
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumberTitle = new Label();
            lblPropertyValueTitle = new Label();
            lblNumberDisplay = new Label();
            txtPropertyValue = new TextBox();
            grpPropertyType = new GroupBox();
            radCommercial = new RadioButton();
            radNonPrimaryResidence = new RadioButton();
            radPrimaryResidence = new RadioButton();
            lblPropertyTaxTitle = new Label();
            lblAverageTitle = new Label();
            lblPropertyTaxDisplay = new Label();
            lblAverageDisplay = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            lblEntriesTitle = new Label();
            lblEntriesDisplay = new Label();
            grpPropertyType.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumberTitle
            // 
            lblNumberTitle.AutoSize = true;
            lblNumberTitle.Location = new Point(12, 9);
            lblNumberTitle.Name = "lblNumberTitle";
            lblNumberTitle.Size = new Size(69, 19);
            lblNumberTitle.TabIndex = 0;
            lblNumberTitle.Text = "Number:";
            // 
            // lblPropertyValueTitle
            // 
            lblPropertyValueTitle.AutoSize = true;
            lblPropertyValueTitle.Location = new Point(12, 45);
            lblPropertyValueTitle.Name = "lblPropertyValueTitle";
            lblPropertyValueTitle.Size = new Size(115, 19);
            lblPropertyValueTitle.TabIndex = 1;
            lblPropertyValueTitle.Text = "Property Value:";
            // 
            // lblNumberDisplay
            // 
            lblNumberDisplay.BackColor = Color.LightCoral;
            lblNumberDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblNumberDisplay.Location = new Point(134, 5);
            lblNumberDisplay.Name = "lblNumberDisplay";
            lblNumberDisplay.Size = new Size(100, 28);
            lblNumberDisplay.TabIndex = 2;
            lblNumberDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPropertyValue
            // 
            txtPropertyValue.Location = new Point(134, 42);
            txtPropertyValue.Name = "txtPropertyValue";
            txtPropertyValue.Size = new Size(100, 27);
            txtPropertyValue.TabIndex = 3;
            // 
            // grpPropertyType
            // 
            grpPropertyType.Controls.Add(radCommercial);
            grpPropertyType.Controls.Add(radNonPrimaryResidence);
            grpPropertyType.Controls.Add(radPrimaryResidence);
            grpPropertyType.Location = new Point(12, 86);
            grpPropertyType.Name = "grpPropertyType";
            grpPropertyType.Size = new Size(222, 118);
            grpPropertyType.TabIndex = 4;
            grpPropertyType.TabStop = false;
            grpPropertyType.Text = "Property Type";
            // 
            // radCommercial
            // 
            radCommercial.AutoSize = true;
            radCommercial.Location = new Point(6, 84);
            radCommercial.Name = "radCommercial";
            radCommercial.Size = new Size(107, 23);
            radCommercial.TabIndex = 2;
            radCommercial.TabStop = true;
            radCommercial.Text = "Commercial";
            radCommercial.UseVisualStyleBackColor = true;
            // 
            // radNonPrimaryResidence
            // 
            radNonPrimaryResidence.AutoSize = true;
            radNonPrimaryResidence.Location = new Point(6, 55);
            radNonPrimaryResidence.Name = "radNonPrimaryResidence";
            radNonPrimaryResidence.Size = new Size(187, 23);
            radNonPrimaryResidence.TabIndex = 1;
            radNonPrimaryResidence.TabStop = true;
            radNonPrimaryResidence.Text = "Non-Primary Residence";
            radNonPrimaryResidence.UseVisualStyleBackColor = true;
            // 
            // radPrimaryResidence
            // 
            radPrimaryResidence.AutoSize = true;
            radPrimaryResidence.Location = new Point(6, 26);
            radPrimaryResidence.Name = "radPrimaryResidence";
            radPrimaryResidence.Size = new Size(153, 23);
            radPrimaryResidence.TabIndex = 0;
            radPrimaryResidence.TabStop = true;
            radPrimaryResidence.Text = "Primary Residence";
            radPrimaryResidence.UseVisualStyleBackColor = true;
            // 
            // lblPropertyTaxTitle
            // 
            lblPropertyTaxTitle.AutoSize = true;
            lblPropertyTaxTitle.Location = new Point(12, 224);
            lblPropertyTaxTitle.Name = "lblPropertyTaxTitle";
            lblPropertyTaxTitle.Size = new Size(100, 19);
            lblPropertyTaxTitle.TabIndex = 5;
            lblPropertyTaxTitle.Text = "Property Tax:";
            // 
            // lblAverageTitle
            // 
            lblAverageTitle.AutoSize = true;
            lblAverageTitle.Location = new Point(12, 263);
            lblAverageTitle.Name = "lblAverageTitle";
            lblAverageTitle.Size = new Size(69, 19);
            lblAverageTitle.TabIndex = 6;
            lblAverageTitle.Text = "Average:";
            // 
            // lblPropertyTaxDisplay
            // 
            lblPropertyTaxDisplay.BackColor = Color.LightCoral;
            lblPropertyTaxDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblPropertyTaxDisplay.Location = new Point(134, 219);
            lblPropertyTaxDisplay.Name = "lblPropertyTaxDisplay";
            lblPropertyTaxDisplay.Size = new Size(100, 28);
            lblPropertyTaxDisplay.TabIndex = 7;
            lblPropertyTaxDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAverageDisplay
            // 
            lblAverageDisplay.BackColor = Color.LightCoral;
            lblAverageDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblAverageDisplay.Location = new Point(134, 258);
            lblAverageDisplay.Name = "lblAverageDisplay";
            lblAverageDisplay.Size = new Size(100, 28);
            lblAverageDisplay.TabIndex = 8;
            lblAverageDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 303);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(106, 41);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(128, 303);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 41);
            btnReset.TabIndex = 10;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lblEntriesTitle
            // 
            lblEntriesTitle.AutoSize = true;
            lblEntriesTitle.Location = new Point(240, 9);
            lblEntriesTitle.Name = "lblEntriesTitle";
            lblEntriesTitle.Size = new Size(60, 19);
            lblEntriesTitle.TabIndex = 11;
            lblEntriesTitle.Text = "Entries:";
            // 
            // lblEntriesDisplay
            // 
            lblEntriesDisplay.BackColor = Color.LightCoral;
            lblEntriesDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblEntriesDisplay.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriesDisplay.ImageAlign = ContentAlignment.BottomLeft;
            lblEntriesDisplay.Location = new Point(243, 28);
            lblEntriesDisplay.Name = "lblEntriesDisplay";
            lblEntriesDisplay.Size = new Size(292, 316);
            lblEntriesDisplay.TabIndex = 12;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 371);
            Controls.Add(lblEntriesDisplay);
            Controls.Add(lblEntriesTitle);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(lblAverageDisplay);
            Controls.Add(lblPropertyTaxDisplay);
            Controls.Add(lblAverageTitle);
            Controls.Add(lblPropertyTaxTitle);
            Controls.Add(grpPropertyType);
            Controls.Add(txtPropertyValue);
            Controls.Add(lblNumberDisplay);
            Controls.Add(lblPropertyValueTitle);
            Controls.Add(lblNumberTitle);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Tax Program";
            Load += frmMain_Load;
            grpPropertyType.ResumeLayout(false);
            grpPropertyType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumberTitle;
        private Label lblPropertyValueTitle;
        private Label lblNumberDisplay;
        private TextBox txtPropertyValue;
        private GroupBox grpPropertyType;
        private RadioButton radCommercial;
        private RadioButton radNonPrimaryResidence;
        private RadioButton radPrimaryResidence;
        private Label lblPropertyTaxTitle;
        private Label lblAverageTitle;
        private Label lblPropertyTaxDisplay;
        private Label lblAverageDisplay;
        private Button btnCalculate;
        private Button btnReset;
        private Label lblEntriesTitle;
        private Label lblEntriesDisplay;
    }
}
