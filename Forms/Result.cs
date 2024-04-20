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
    public partial class Result : Form
    {
        MainScreen parentForm;
        // Data data;
        Thread t1;
        public Result(MainScreen parentForm)
        {   
            this.parentForm = parentForm;

            InitializeComponent();
            t1 = new Thread(Predict); 
            t1.Start();
        }

        private void Predict()
        {

            string dataFilePath = Path.Combine("..", "JSON", "Check.json");
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
            var predictionScore = predictionResult.Score;
            var predictionLabel = predictionResult.PredictedLabel;
            var predictionProbability = predictionResult.Probability;
            var dataResult = new
            {
                Label = predictionLabel,
                Score = predictionScore,
                Probability = predictionProbability,
            };
            string json = JsonConvert.SerializeObject(dataResult, Formatting.Indented);

            // Write JSON string to a file
            //string filePath = "./JSON/Result.json";
            string filePath = Path.Combine("..", "JSON", "Result.json");
            File.WriteAllText(filePath, json);
            t1.Abort();
        }

        private void Result_Load(object sender, EventArgs e)
        {
           
        }
    }
}
