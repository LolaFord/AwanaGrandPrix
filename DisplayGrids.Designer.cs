namespace AwanaGrandPrix
{
    partial class DisplayGrids
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
            this.dgvHeats = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeats
            // 
            this.dgvHeats.AllowUserToAddRows = false;
            this.dgvHeats.AllowUserToDeleteRows = false;
            this.dgvHeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeats.Location = new System.Drawing.Point(29, 32);
            this.dgvHeats.Name = "dgvHeats";
            this.dgvHeats.ReadOnly = true;
            this.dgvHeats.Size = new System.Drawing.Size(771, 288);
            this.dgvHeats.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(819, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.OnClick);
            // 
            // DisplayGrids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 353);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvHeats);
            this.Name = "DisplayGrids";
            this.Text = "DisplayGrids";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHeats;
        private System.Windows.Forms.Button btnBack;
    }
}