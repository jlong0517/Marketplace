using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {


        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "")
            {
                lblMessage.Text = "Enter UserName";
            }
            else if (txtupass.Text == "")
            {
                lblMessage.Text = "Enter Password";
            }
            else
            {
                if (txtuname.Text == "jlong" && txtupass.Text == "winter")
                {
                    lblMessage.Text = "Login Success";
                }
                else
                {
                    lblMessage.Text = "Invalid Name or Password";
                }
            }
        }
    }
}

