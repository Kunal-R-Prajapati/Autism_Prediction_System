using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autism_Prediction_System.Forms
{

    public partial class Result : Form
    {
        public class Fields
        {
            public float A1_Score { get; set; }
            public float A2_Score { get; set; }
            public float A3_Score { get; set; }
            public float A4_Score { get; set; }
            public float A5_Score { get; set; }
            public float A6_Score { get; set; }
            public float A7_Score { get; set; }
            public float A8_Score { get; set; }
            public float A9_Score { get; set; }
            public float A10_Score { get; set; }
            public float Age { get; set; }
            public string Gender { get; set; }
            public string Ethnicity { get; set; }
            public string Contry_of_res { get; set; }
            public string Relation { get; set; }
        }

        class Res
        {
            public bool Label { get; set; }
            public float Probability { get; set; }
        }
        MainScreen parentForm;
        // Data data;
        Thread t1;
        int count;

        public Result(MainScreen parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
            PredictionProgressBar.Value = 0;
            timer1.Enabled = true;
            button1.Enabled = false;
            button1.Visible = true;
            button1.BackColor = Color.Gray;
            label1.Enabled = true;
            label1.Visible = false;
            label2.Enabled = true;
            label2.Visible = false;
            count = 0;
        }

        private void Predict()
        {

            string dataFilePath = Path.Combine(".", "JSON", "Check.json");
            //Load patient data as a json file and reading it
            var dataFile = File.ReadAllText(dataFilePath);
            //Convertiong that Read data into a useable format with the help of previously declared data class
            var dataValue = JsonConvert.DeserializeObject<Fields>(dataFile);
            var result = dataValue.A1_Score + dataValue.A2_Score + dataValue.A3_Score + dataValue.A4_Score + dataValue.A5_Score + dataValue.A6_Score + dataValue.A7_Score + dataValue.A8_Score + dataValue.A9_Score + dataValue.A10_Score;
            AutismModel.ModelInput sampleData = new AutismModel.ModelInput()
            {
                A1_Score = dataValue.A1_Score,
                A2_Score = dataValue.A2_Score,
                A3_Score = dataValue.A3_Score,
                A4_Score = dataValue.A4_Score,
                A5_Score = dataValue.A5_Score,
                A6_Score = dataValue.A5_Score,
                A7_Score = dataValue.A7_Score,
                A8_Score = dataValue.A8_Score,
                A9_Score = dataValue.A9_Score,
                A10_Score = dataValue.A10_Score,
                Age = dataValue.Age,
                Gender = dataValue.Gender,
                Ethnicity = dataValue.Ethnicity,
                Contry_of_res = dataValue.Ethnicity,
                Result = result,
                Relation = dataValue.Relation,

            };
            var predictionResult = AutismModel.Predict(sampleData);
            //var predictionScore = predictionResult.Score;
            var predictionLabel = predictionResult.PredictedLabel;
            var predictionProbability = predictionResult.Probability;
            //Code to write data in json file
            var dataResult = new
            {
                Label = predictionLabel,
                //  Score = predictionScore,
                Probability = predictionProbability,
            };
            string json = JsonConvert.SerializeObject(dataResult, Formatting.Indented);

            // Write JSON string to a file
            //string filePath = "./JSON/Result.json";
            string filePath = Path.Combine(".", "JSON", "Result.json");
            File.WriteAllText(filePath, json);

            //label1.Text = "Autism Detected : " + predictionLabel.ToString();
            //label2.Text = "True Percentage : " + predictionProbability.ToString();

            t1.Abort();
        }

        private void ShowResultData()
        {
            string dataFilePath = Path.Combine(".", "JSON", "Result.json");
            //Load patient data as a json file and reading it
            var dataFile = File.ReadAllText(dataFilePath);
            //Convertiong that Read data into a useable format with the help of previously declared data class
            var dataValue = JsonConvert.DeserializeObject<Res>(dataFile);
            int prob = (int)(dataValue.Probability * 100);
            label1.Text = "Autism Detected : " + dataValue.Label.ToString();
            label2.Text = "True Percentage : " + prob.ToString()+"%";
        }

        private void Result_Load(object sender, EventArgs e)
        {
            t1 = new Thread(Predict);

            t1.Start();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PredictionProgressBar.Value += 1;
            if (!(t1.IsAlive))
            {

                if (PredictionProgressBar.Value < 90)
                {
                    PredictionProgressBar.Value += 10;

                }

            }
            if (PredictionProgressBar.Value > 90)
            {
                Task.Delay(750);
            }
            if (PredictionProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                PredictionProgressBar.Text = "Predicted";
                Task.Delay(3000);
                button1.Enabled = true;
                button1.BackColor = Color.Green;
                button1.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count < 2)
            {
                PredictionProgressBar.Visible = false;
                PredictionProgressBar.Enabled = false;
             
                label1.Enabled = true;
                label2.Enabled = true;

                ShowResultData();
                label1.Visible = true;
                
                label2.Visible = true;
                button1.Text = "Home";
            }
            else
            {
                MainScreen mainScreen = new MainScreen();
                this.Close();
                mainScreen.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
