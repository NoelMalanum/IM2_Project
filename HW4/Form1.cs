namespace HW4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string mobile = mtxtmob.Text;
            string firstname = txtfname.Text;
            string lastname = txtlname.Text;
            string sex = rbmale.Checked ? "Male" : rbfemale.Checked ? "Female" : "";
            string status = txtstatus.Text;
            string birthdate = dtpbday.Value.ToLongDateString();
            string location = txtloc.Text;
            Image photo = pictureBox1.Image;

            Form2 displayForm = new Form2(mobile, firstname, lastname, sex, status, birthdate, location, photo);
            displayForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}

