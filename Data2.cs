using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autism_Prediction_System
{
    public class Data2
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
        public float Age { get; set;}
        public string Gender { get; set;}
        public string Ethnicity { get; set; }
        public string Contry_of_res { get; set; }
        public float Result { get; set; }
        public string Relation { get; set; }

        public  float ConvertTo0and1(string text)
        {
            if (text == "YES")
            {
                return 1F;
            }
            else
            {
                return 0F;                
            }
        }
    }
}
