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
using Autism_Prediction_System;

namespace Autism_Prediction_System.Forms
{
    public partial class QuestionPage2 : Form
    {
        MainScreen parentForm;
        int count;
        Data data;
        public QuestionPage2(MainScreen parentForm, ref Data data)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            count = 0;
            buttonNext.Enabled = false;
            buttonNext.BackColor = Color.FromArgb(179, 179, 179);
            buttonNext.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 99);
            this.data = data;
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
            data.A6_Score = data.ConvertTo0and1(answer6.SelectedText);
        }

        private void answer7_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.A7_Score = data.ConvertTo0and1(answer7.SelectedText);
        }

        private void answer8_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.A8_Score = data.ConvertTo0and1(answer8.SelectedText);
        }

        private void answer9_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.A9_Score = data.ConvertTo0and1(answer9.SelectedText);
        }

        private void answer10_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.A10_Score = data.ConvertTo0and1(answer10.SelectedText);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage3(parentForm, ref data), parentForm, sender, e);
        }

        
    }
}
