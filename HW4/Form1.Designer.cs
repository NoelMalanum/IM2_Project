namespace HW4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtloc = new TextBox();
            txtlname = new TextBox();
            txtstatus = new TextBox();
            txtfname = new TextBox();
            mtxtmob = new MaskedTextBox();
            dtpbday = new DateTimePicker();
            rbmale = new RadioButton();
            rbfemale = new RadioButton();
            btnsubmit = new Button();
            pictureBox1 = new PictureBox();
            btnbrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(512, 44);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 0;
            label1.Text = "SIM CARD REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 129);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 187);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Firstname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(673, 187);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(673, 242);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 289);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Birthdate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 241);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 6;
            label7.Text = "Sex";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(673, 289);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 7;
            label8.Text = "Location";
            // 
            // txtloc
            // 
            txtloc.Location = new Point(771, 289);
            txtloc.Name = "txtloc";
            txtloc.Size = new Size(160, 27);
            txtloc.TabIndex = 8;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(771, 187);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(160, 27);
            txtlname.TabIndex = 9;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(771, 242);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(160, 27);
            txtstatus.TabIndex = 10;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(381, 180);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(162, 27);
            txtfname.TabIndex = 12;
            // 
            // mtxtmob
            // 
            mtxtmob.Location = new Point(381, 126);
            mtxtmob.Name = "mtxtmob";
            mtxtmob.Size = new Size(162, 27);
            mtxtmob.TabIndex = 13;
            // 
            // dtpbday
            // 
            dtpbday.Location = new Point(381, 284);
            dtpbday.Name = "dtpbday";
            dtpbday.Size = new Size(250, 27);
            dtpbday.TabIndex = 14;
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Location = new Point(381, 241);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(63, 24);
            rbmale.TabIndex = 15;
            rbmale.TabStop = true;
            rbmale.Text = "Male";
            rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Location = new Point(465, 242);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(78, 24);
            rbfemale.TabIndex = 16;
            rbfemale.TabStop = true;
            rbfemale.Text = "Female";
            rbfemale.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = SystemColors.ActiveCaption;
            btnsubmit.Location = new Point(574, 379);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(183, 78);
            btnsubmit.TabIndex = 17;
            btnsubmit.Text = "Submit Regsitration";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(991, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 122);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new Point(1022, 187);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(94, 29);
            btnbrowse.TabIndex = 19;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 616);
            Controls.Add(btnbrowse);
            Controls.Add(pictureBox1);
            Controls.Add(btnsubmit);
            Controls.Add(rbfemale);
            Controls.Add(rbmale);
            Controls.Add(dtpbday);
            Controls.Add(mtxtmob);
            Controls.Add(txtfname);
            Controls.Add(txtstatus);
            Controls.Add(txtlname);
            Controls.Add(txtloc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtloc;
        private TextBox txtlname;
        private TextBox txtstatus;
        private TextBox txtfname;
        private MaskedTextBox mtxtmob;
        private DateTimePicker dtpbday;
        private RadioButton rbmale;
        private RadioButton rbfemale;
        private Button btnsubmit;
        private PictureBox pictureBox1;
        private Button btnbrowse;
        private OpenFileDialog openFileDialog1;
    }
}
