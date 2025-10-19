using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW4
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstname, string lastname, string sex, string status, string birthday, string location, Image photo)
        {



            InitializeComponent();

            lblmobile.Text = "Mobile: " + mobile;
            lblname.Text = "Name: " + firstname + " " + lastname;
            lblsex.Text = "Sex: " + sex;
            lblstatus.Text = "Status: " + status;
            lblbday.Text = "Birthdate: " + birthday;
            lblloc.Text = "Location: " + location;
            pictureBox1.Image = photo;
        }
    }
    }

