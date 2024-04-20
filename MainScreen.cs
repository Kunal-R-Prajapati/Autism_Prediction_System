using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autism_Prediction_System
{
    public partial class MainScreen : Form
    {

       
        public static Form activeForm ;
        //private Datae data;
        public Data2 data ;

        public MainScreen()
        {
            InitializeComponent();
            data = new Data2();
        }


        public void OpenChildForm(Form childForm, MainScreen obj, object btnSender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                //childForm.data = activeForm.data; 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            obj.panelBody.Controls.Add(childForm);
            obj.panelBody.Tag = childForm;
       
            childForm.BringToFront();
            childForm.Show();

        }
        private void Main_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home( this ),this, sender, e);
            //OpenChildForm(new Forms.QuestionPage3(this),this,sender,e);
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
