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
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Autism_Prediction_System.Forms
{
    public partial class QuestionPage2 : Form
    {
        MainScreen parentForm;
        int count;
        //Data data;
        //public Data data { get; set; }
        public QuestionPage2(MainScreen parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            count = 0;
            buttonNext.Enabled = false;
            buttonNext.BackColor = Color.FromArgb(179, 179, 179);
            buttonNext.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 99);
            //this.data = data;
        }
        private void checkNoOfQuestionsAnswered()
        {
            count++;
            if (answer6.SelectedIndex > -1 && answer7.SelectedIndex > -1 && answer8.SelectedIndex > -1
                && answer9.SelectedIndex > -1 && answer10.SelectedIndex > -1 && count >= 5)
            {
                buttonNext.Enabled = true;
                buttonNext.BackColor = Color.FromName("Green");
                buttonNext.FlatAppearance.BorderColor = Color.FromName("DarkGreen");
            }
        }
        public float ConvertTo0and1(string text)
        {
            if (text == "Yes")
            {
                return 1F;
            }
            else if (text == "No")
            {
                return 0F;
            }
            else
            {
                return -1F;
            }
        }
        private void answer6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //label1.Text = data.A1_Score.ToString();
            checkNoOfQuestionsAnswered();
            //data.A6_Score = data.ConvertTo0and1(answer6.SelectedText);
        }

        private void answer7_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            // data.A7_Score = data.ConvertTo0and1(answer7.SelectedText);
        }

        private void answer8_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            // data.A8_Score = data.ConvertTo0and1(answer8.SelectedText);
        }

        private void answer9_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            //  data.A9_Score = data.ConvertTo0and1(answer9.SelectedText);
        }

        private void answer10_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkNoOfQuestionsAnswered();
            // data.A10_Score = data.ConvertTo0and1(answer10.SelectedText);
        }
        private void updateJson()
        {
            string dataFilePath = Path.Combine(".", "JSON", "Check.json");
            // Read existing JSON data from the file
            string jsonData = File.ReadAllText(dataFilePath);
            JObject jsonObject = JObject.Parse(jsonData);
            //Adding data to json
            jsonObject["A6_Score"] = ConvertTo0and1(answer6.Text);
            jsonObject["A7_Score"] = ConvertTo0and1(answer7.Text);
            jsonObject["A8_Score"] = ConvertTo0and1(answer8.Text);
            jsonObject["A9_Score"] = ConvertTo0and1(answer9.Text);
            jsonObject["A10_Score"] = ConvertTo0and1(answer10.Text);
            // Serialize the modified object back to JSON
            string updatedJsonData = jsonObject.ToString(Formatting.Indented);
            File.WriteAllText(dataFilePath, updatedJsonData);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            updateJson();
            this.Close();
            parentForm.OpenChildForm(new Forms.QuestionPage3(parentForm), parentForm, sender, e);
        }


    }
}
