namespace WindowsFormsApp1
{
    partial class emailsend
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.from = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.to = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.sub = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.msg = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.smtp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.un = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.showmsg = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.showmsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // from
            // 
            this.from.BorderColor = System.Drawing.Color.SeaGreen;
            this.from.Location = new System.Drawing.Point(163, 24);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(434, 20);
            this.from.TabIndex = 4;
            // 
            // to
            // 
            this.to.BorderColor = System.Drawing.Color.SeaGreen;
            this.to.Location = new System.Drawing.Point(163, 55);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(434, 20);
            this.to.TabIndex = 5;
            // 
            // sub
            // 
            this.sub.BorderColor = System.Drawing.Color.SeaGreen;
            this.sub.Location = new System.Drawing.Point(163, 88);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(434, 20);
            this.sub.TabIndex = 6;
            // 
            // msg
            // 
            this.msg.BorderColor = System.Drawing.Color.SeaGreen;
            this.msg.Location = new System.Drawing.Point(163, 234);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msg.Size = new System.Drawing.Size(434, 161);
            this.msg.TabIndex = 7;
            // 
            // smtp
            // 
            this.smtp.BorderColor = System.Drawing.Color.SeaGreen;
            this.smtp.Location = new System.Drawing.Point(163, 123);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(434, 20);
            this.smtp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Smtp Server";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(320, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Name";
            // 
            // un
            // 
            this.un.BorderColor = System.Drawing.Color.SeaGreen;
            this.un.Location = new System.Drawing.Point(163, 159);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(434, 20);
            this.un.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.BorderColor = System.Drawing.Color.SeaGreen;
            this.pass.Location = new System.Drawing.Point(163, 194);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(434, 20);
            this.pass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // showmsg
            // 
            this.showmsg.Controls.Add(this.label8);
            this.showmsg.Location = new System.Drawing.Point(639, 97);
            this.showmsg.Name = "showmsg";
            this.showmsg.Size = new System.Drawing.Size(310, 358);
            this.showmsg.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.button2.Location = new System.Drawing.Point(734, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "My Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "You have no new message!";
            // 
            // emailsend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(981, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showmsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.un);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "emailsend";
            this.Text = "emailsend";
            this.showmsg.ResumeLayout(false);
            this.showmsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox from;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox to;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox sub;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox msg;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox smtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox un;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel showmsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}