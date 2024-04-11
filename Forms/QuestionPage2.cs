using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Autism_Prediction_System.Forms
{
    public partial class QuestionPage2 : Form
    {
        MainScreen parentForm;
        int count;
        public QuestionPage2(MainScreen parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            count = 0;
            buttonNext.Enabled = false;
            buttonNext.BackColor = Color.FromArgb(179, 179, 179);
            buttonNext.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 99);
        }
        private void checkNoOfQuestionsAnswered()
        {
            count ++;
            if (answer6.SelectedIndex > -1 && answer7.SelectedIndex > -1 && answer8.SelectedIndex > -1
                && answer9.SelectedIndex > -1 && answer10.SelectedIndex > -1 && count >= 5)
            {
                buttonNext.Enabled = true;
                buttonNext.BackColor = Color.FromName("Green");
                buttonNext.FlatAppearance.BorderColor = Color.FromName("DarkGreen");
            }
        }

        private void answer6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void answer7_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void answer8_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void answer9_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void answer10_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage3(parentForm), parentForm, sender, e);
        }

        
    }
}
