namespace HW4
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            lblmobile = new Label();
            lblname = new Label();
            lblsex = new Label();
            lblstatus = new Label();
            lblbday = new Label();
            lblloc = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 130);
            label1.Name = "label1";
            label1.Size = new Size(357, 29);
            label1.TabIndex = 0;
            label1.Text = "Sim Card Registration Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(686, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblmobile
            // 
            lblmobile.AutoSize = true;
            lblmobile.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmobile.Location = new Point(374, 225);
            lblmobile.Name = "lblmobile";
            lblmobile.Size = new Size(68, 20);
            lblmobile.TabIndex = 2;
            lblmobile.Text = "Mobile: ";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.Location = new Point(374, 276);
            lblname.Name = "lblname";
            lblname.Size = new Size(58, 20);
            lblname.TabIndex = 3;
            lblname.Text = "Name:";
            // 
            // lblsex
            // 
            lblsex.AutoSize = true;
            lblsex.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsex.Location = new Point(374, 325);
            lblsex.Name = "lblsex";
            lblsex.Size = new Size(42, 20);
            lblsex.TabIndex = 4;
            lblsex.Text = "Sex:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(374, 375);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(57, 20);
            lblstatus.TabIndex = 5;
            lblstatus.Text = "Status";
            // 
            // lblbday
            // 
            lblbday.AutoSize = true;
            lblbday.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblbday.Location = new Point(374, 426);
            lblbday.Name = "lblbday";
            lblbday.Size = new Size(76, 20);
            lblbday.TabIndex = 6;
            lblbday.Text = "Birthday:";
            // 
            // lblloc
            // 
            lblloc.AutoSize = true;
            lblloc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblloc.Location = new Point(374, 475);
            lblloc.Name = "lblloc";
            lblloc.Size = new Size(78, 20);
            lblloc.TabIndex = 7;
            lblloc.Text = "Location:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(791, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 158);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1317, 862);
            Controls.Add(pictureBox1);
            Controls.Add(lblloc);
            Controls.Add(lblbday);
            Controls.Add(lblstatus);
            Controls.Add(lblsex);
            Controls.Add(lblname);
            Controls.Add(lblmobile);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblbday;
        private System.Windows.Forms.Label lblloc;
        private PictureBox pictureBox1;
    }
}