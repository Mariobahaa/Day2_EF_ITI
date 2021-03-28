
namespace Hotel_Reservation
{
    partial class kitchenDataGirdView
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
            this.savebtn = new System.Windows.Forms.Button();
            this.reservationDataGirdView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Location = new System.Drawing.Point(418, 567);
            this.savebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(102, 47);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // reservationDataGirdView
            // 
            this.reservationDataGirdView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGirdView.Location = new System.Drawing.Point(9, -29);
            this.reservationDataGirdView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservationDataGirdView.Name = "reservationDataGirdView";
            this.reservationDataGirdView.RowHeadersWidth = 51;
            this.reservationDataGirdView.RowTemplate.Height = 25;
            this.reservationDataGirdView.Size = new System.Drawing.Size(887, 543);
            this.reservationDataGirdView.TabIndex = 0;
            // 
            // kitchenDataGirdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.reservationDataGirdView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kitchenDataGirdView";
            this.Text = "dataGirdView";
            this.Load += new System.EventHandler(this.dataGirdView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView reservationDataGirdView;
    }
}