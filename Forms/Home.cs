using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autism_Prediction_System;

namespace Autism_Prediction_System.Forms
{
    public partial class Home : Form
    {
        MainScreen parentForm;
       // public Data data { get; set; }
        public Home(MainScreen parentForm ) 
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage1(parentForm),parentForm,sender,e);
            //parentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
