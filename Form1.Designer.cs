namespace AwanaGrandPrix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxEntrantNumber = new System.Windows.Forms.TextBox();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEntrantDriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCarWeight = new System.Windows.Forms.TextBox();
            this.btnTestSeries = new System.Windows.Forms.Button();
            this.btnNextSeries = new System.Windows.Forms.Button();
            this.btnShowGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxEntrantNumber
            // 
            this.tbxEntrantNumber.Location = new System.Drawing.Point(81, 73);
            this.tbxEntrantNumber.Name = "tbxEntrantNumber";
            this.tbxEntrantNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxEntrantNumber.TabIndex = 3;
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Items.AddRange(new object[] {
            "Church Family",
            "Sparks",
            "Truth and Training"});
            this.cbxGroup.Location = new System.Drawing.Point(81, 20);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxGroup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Driver";
            // 
            // tbxEntrantDriver
            // 
            this.tbxEntrantDriver.Location = new System.Drawing.Point(81, 47);
            this.tbxEntrantDriver.Name = "tbxEntrantDriver";
            this.tbxEntrantDriver.Size = new System.Drawing.Size(100, 20);
            this.tbxEntrantDriver.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Car Weight";
            // 
            // tbxCarWeight
            // 
            this.tbxCarWeight.Location = new System.Drawing.Point(81, 99);
            this.tbxCarWeight.Name = "tbxCarWeight";
            this.tbxCarWeight.Size = new System.Drawing.Size(100, 20);
            this.tbxCarWeight.TabIndex = 4;
            // 
            // btnTestSeries
            // 
            this.btnTestSeries.Location = new System.Drawing.Point(401, 220);
            this.btnTestSeries.Name = "btnTestSeries";
            this.btnTestSeries.Size = new System.Drawing.Size(75, 23);
            this.btnTestSeries.TabIndex = 9;
            this.btnTestSeries.Text = "Test Series";
            this.btnTestSeries.UseVisualStyleBackColor = true;
            this.btnTestSeries.Click += new System.EventHandler(this.btnTestSeries_Click);
            // 
            // btnNextSeries
            // 
            this.btnNextSeries.Location = new System.Drawing.Point(496, 220);
            this.btnNextSeries.Name = "btnNextSeries";
            this.btnNextSeries.Size = new System.Drawing.Size(75, 23);
            this.btnNextSeries.TabIndex = 10;
            this.btnNextSeries.Text = "Next Series";
            this.btnNextSeries.UseVisualStyleBackColor = true;
            this.btnNextSeries.Click += new System.EventHandler(this.btnNewSeries_Click);
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.Location = new System.Drawing.Point(597, 221);
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(75, 23);
            this.btnShowGrid.TabIndex = 11;
            this.btnShowGrid.Text = "Show Grid";
            this.btnShowGrid.UseVisualStyleBackColor = true;
            this.btnShowGrid.Click += new System.EventHandler(this.btnShowGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 300);
            this.Controls.Add(this.btnShowGrid);
            this.Controls.Add(this.btnNextSeries);
            this.Controls.Add(this.btnTestSeries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCarWeight);
            this.Controls.Add(this.tbxEntrantDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.tbxEntrantNumber);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxEntrantNumber;
        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEntrantDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCarWeight;
        private System.Windows.Forms.Button btnTestSeries;
        private System.Windows.Forms.Button btnNextSeries;
        private System.Windows.Forms.Button btnShowGrid;
    }
}

