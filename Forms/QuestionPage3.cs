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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Autism_Prediction_System.Forms
{
    public partial class QuestionPage3 : Form
    {
        MainScreen parentForm;
        Data data;
        public QuestionPage3(MainScreen parentForm, ref Data data)
        {
            InitializeComponent();
            this.parentForm = parentForm;   
            this.data = data;
            button1.Enabled = false;
            button1.BackColor = Color.FromArgb(179, 179, 179);
            button1.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 99);
        }
        private void checkNoOfQuestionsAnswered()
        {
            if ( answerGender.SelectedIndex > -1 && answerEthnicity.SelectedIndex > -1
                && answerContryOfRes.SelectedIndex > -1 && answerJaundice.SelectedIndex > -1 && answerAutism.SelectedIndex > -1
                && answerTestCompletedBy.SelectedIndex > -1)
            {
                button1.Enabled = true;
                button1.BackColor = Color.FromName("Green");
                button1.FlatAppearance.BorderColor = Color.FromName("DarkGreen");
            }
        }
        private void answerGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.Gender = answerGender.SelectedText;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void answerAge_ValueChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.Age  = (float)Convert.ToDecimal(answerAge.Text);
        }

        private void answerEthnicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.Ethnicity = answerEthnicity.SelectedText;
        }

        private void answerContryOfRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.Contry_of_res = answerContryOfRes.SelectedText;
        }

        private void answerJaundice_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();


        }

        private void answerAutism_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
        }

        private void answerTestCompletedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            data.Relation =  answerTestCompletedBy.SelectedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Result = data.A1_Score + data.A2_Score + data.A3_Score + data.A4_Score + data.A5_Score + data.A6_Score +
                data.A7_Score + data.A8_Score + data.A9_Score + data.A10_Score;
        }
    }
}
