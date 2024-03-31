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
    public partial class QuestionPage1 : Form
    {
        MainScreen parentForm;
        int count;
        public QuestionPage1(MainScreen parentForm)
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
            if(answer1.SelectedIndex > -1 && answer2.SelectedIndex > -1 && answer3.SelectedIndex > -1 
                && answer4.SelectedIndex > -1 && answer5.SelectedIndex > -1 && count >= 5) {
                buttonNext.Enabled = true;
                buttonNext.BackColor = Color.FromName("Green");
                buttonNext.FlatAppearance.BorderColor = Color.FromName("DarkGreen");
            }
        }

        private void answer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
        }

        private void answer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
        }

        private void answer3_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
        }

        private void answer4_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
        }

        private void answer5_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage2(parentForm), parentForm, sender, e);
        }
    }
}
