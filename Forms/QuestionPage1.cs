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
    public partial class QuestionPage1 : Form
    {
        MainScreen parentForm;
        int count;
        Data data;
        public QuestionPage1(MainScreen parentForm, ref Data data)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.data = data;
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
            data.A1_Score = data.ConvertTo0and1(answer1.SelectedText);
        }

        private void answer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
            data.A2_Score = data.ConvertTo0and1(answer2.SelectedText);
        }

        private void answer3_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
            data.A3_Score = data.ConvertTo0and1(answer3.SelectedText);
        }

        private void answer4_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
            data.A4_Score = data.ConvertTo0and1(answer4.SelectedText);
        }

        private void answer5_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            checkNoOfQuestionsAnswered();
            data.A5_Score = data.ConvertTo0and1(answer5.SelectedText);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage2(parentForm, ref data), parentForm, sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quesion1_Click(object sender, EventArgs e)
        {

        }

        private void question2_Click(object sender, EventArgs e)
        {

        }

        private void question3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void question5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
