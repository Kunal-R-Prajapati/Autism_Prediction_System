﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace Autism_Prediction_System
{
    public partial class AutismModel
    {
        public const string RetrainFilePath =  @"D:\Final year project\datasets\datasetCombined\data.txt";
        public const char RetrainSeparatorChar = '	';
        public const bool RetrainHasHeader =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
        }



        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }


        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"gender", @"gender"),new InputOutputColumnPair(@"jundice", @"jundice"),new InputOutputColumnPair(@"austim", @"austim"),new InputOutputColumnPair(@"relation", @"relation")}, outputKind: OneHotEncodingEstimator.OutputKind.Indicator)      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"A1_Score", @"A1_Score"),new InputOutputColumnPair(@"A2_Score", @"A2_Score"),new InputOutputColumnPair(@"A3_Score", @"A3_Score"),new InputOutputColumnPair(@"A4_Score", @"A4_Score"),new InputOutputColumnPair(@"A5_Score", @"A5_Score"),new InputOutputColumnPair(@"A6_Score", @"A6_Score"),new InputOutputColumnPair(@"A7_Score", @"A7_Score"),new InputOutputColumnPair(@"A8_Score", @"A8_Score"),new InputOutputColumnPair(@"A9_Score", @"A9_Score"),new InputOutputColumnPair(@"A10_Score", @"A10_Score"),new InputOutputColumnPair(@"age", @"age"),new InputOutputColumnPair(@"result", @"result")}))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"ethnicity",outputColumnName:@"ethnicity"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"contry_of_res",outputColumnName:@"contry_of_res"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"gender",@"jundice",@"austim",@"relation",@"A1_Score",@"A2_Score",@"A3_Score",@"A4_Score",@"A5_Score",@"A6_Score",@"A7_Score",@"A8_Score",@"A9_Score",@"A10_Score",@"age",@"result",@"ethnicity",@"contry_of_res"}))      
                                    .Append(mlContext.BinaryClassification.Trainers.FastTree(new FastTreeBinaryTrainer.Options(){NumberOfLeaves=4,MinimumExampleCountPerLeaf=20,NumberOfTrees=4,MaximumBinCountPerFeature=254,FeatureFraction=1,LearningRate=0.1,LabelColumnName=@"Class/ASD",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
 }
