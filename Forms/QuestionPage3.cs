using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autism_Prediction_System.Forms
{
    public partial class QuestionPage3 : Form
    {
        MainScreen parentForm;
        public QuestionPage3(MainScreen parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;   
        }

        private void answerGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
