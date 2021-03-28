
namespace Hotel_Reservation
{
    partial class Form1
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
            this.lgnbtn = new System.Windows.Forms.Button();
            this.usrnameTxt = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lgnbtn
            // 
            this.lgnbtn.Location = new System.Drawing.Point(341, 250);
            this.lgnbtn.Name = "lgnbtn";
            this.lgnbtn.Size = new System.Drawing.Size(84, 40);
            this.lgnbtn.TabIndex = 0;
            this.lgnbtn.Text = "Login";
            this.lgnbtn.UseVisualStyleBackColor = true;
            this.lgnbtn.Click += new System.EventHandler(this.lgnbtn_Click);
            // 
            // usrnameTxt
            // 
            this.usrnameTxt.Location = new System.Drawing.Point(265, 137);
            this.usrnameTxt.Name = "usrnameTxt";
            this.usrnameTxt.Size = new System.Drawing.Size(254, 23);
            this.usrnameTxt.TabIndex = 1;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(265, 191);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(254, 23);
            this.passtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.usrnameTxt);
            this.Controls.Add(this.lgnbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgnbtn;
        private System.Windows.Forms.TextBox usrnameTxt;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

