namespace WindowsFormsApp1
{
    partial class profilesetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilesetting));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPerformOperation = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnBackProfileSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPerformOperation
            // 
            this.btnPerformOperation.BackColor = System.Drawing.Color.Maroon;
            this.btnPerformOperation.FlatAppearance.BorderSize = 0;
            this.btnPerformOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformOperation.ForeColor = System.Drawing.Color.White;
            this.btnPerformOperation.Location = new System.Drawing.Point(24, 267);
            this.btnPerformOperation.Name = "btnPerformOperation";
            this.btnPerformOperation.Size = new System.Drawing.Size(307, 30);
            this.btnPerformOperation.TabIndex = 10;
            this.btnPerformOperation.Text = "Perform Operation";
            this.btnPerformOperation.UseVisualStyleBackColor = false;
            this.btnPerformOperation.Click += new System.EventHandler(this.btnPerformOperation_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(58, 329);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(229, 30);
            this.btnDeleteAccount.TabIndex = 11;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnBackProfileSetting
            // 
            this.btnBackProfileSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBackProfileSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackProfileSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackProfileSetting.BorderRadius = 0;
            this.btnBackProfileSetting.ButtonText = "Back";
            this.btnBackProfileSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackProfileSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackProfileSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackProfileSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBackProfileSetting.Iconimage")));
            this.btnBackProfileSetting.Iconimage_right = null;
            this.btnBackProfileSetting.Iconimage_right_Selected = null;
            this.btnBackProfileSetting.Iconimage_Selected = null;
            this.btnBackProfileSetting.IconMarginLeft = 0;
            this.btnBackProfileSetting.IconMarginRight = 0;
            this.btnBackProfileSetting.IconRightVisible = true;
            this.btnBackProfileSetting.IconRightZoom = 0D;
            this.btnBackProfileSetting.IconVisible = true;
            this.btnBackProfileSetting.IconZoom = 90D;
            this.btnBackProfileSetting.IsTab = false;
            this.btnBackProfileSetting.Location = new System.Drawing.Point(24, 24);
            this.btnBackProfileSetting.Name = "btnBackProfileSetting";
            this.btnBackProfileSetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackProfileSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnBackProfileSetting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnBackProfileSetting.selected = false;
            this.btnBackProfileSetting.Size = new System.Drawing.Size(86, 21);
            this.btnBackProfileSetting.TabIndex = 12;
            this.btnBackProfileSetting.Text = "Back";
            this.btnBackProfileSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackProfileSetting.Textcolor = System.Drawing.Color.White;
            this.btnBackProfileSetting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProfileSetting.Click += new System.EventHandler(this.btnBackProfileSetting_Click);
            // 
            // profilesetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.btnBackProfileSetting);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnPerformOperation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "profilesetting";
            this.Text = "profilesetting";
            this.Load += new System.EventHandler(this.profilesetting_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPerformOperation;
        private System.Windows.Forms.Button btnDeleteAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnBackProfileSetting;
    }
}