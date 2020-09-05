namespace WindowsFormsApp1
{
    partial class DisplayProfile
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
            this.dataGridViewDSP = new System.Windows.Forms.DataGridView();
            this.btnBackDSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSP
            // 
            this.dataGridViewDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSP.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewDSP.Name = "dataGridViewDSP";
            this.dataGridViewDSP.Size = new System.Drawing.Size(776, 64);
            this.dataGridViewDSP.TabIndex = 0;
            // 
            // btnBackDSP
            // 
            this.btnBackDSP.Location = new System.Drawing.Point(12, 13);
            this.btnBackDSP.Name = "btnBackDSP";
            this.btnBackDSP.Size = new System.Drawing.Size(92, 25);
            this.btnBackDSP.TabIndex = 1;
            this.btnBackDSP.Text = "Back";
            this.btnBackDSP.UseVisualStyleBackColor = true;
            // 
            // DisplayProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackDSP);
            this.Controls.Add(this.dataGridViewDSP);
            this.Name = "DisplayProfile";
            this.Text = "DisplayProfile";
            this.Load += new System.EventHandler(this.DisplayProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSP;
        private System.Windows.Forms.Button btnBackDSP;
    }
}