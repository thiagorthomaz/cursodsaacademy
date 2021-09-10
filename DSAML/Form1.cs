using DSAML.Classes;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAML
{
    public partial class Form1 : Form
    {

        static readonly string _dataPath =
            Path.Combine(Environment.CurrentDirectory, "Dados", "iris.data");


        static readonly string _modelPath =
            Path.Combine(Environment.CurrentDirectory, "Dados", "Modelo.zip");

        MLContext mlContext = new MLContext(seed: 1234);
        DataOperationsCatalog.TrainTestData splitData;
        DataViewSchema DataSchema = null;

        static private ITransformer trainedModel;

        static private PredictionEngine<Iris, IrisPrediction> prediction;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Inicializando Programa...\n");
            Log("Dataset Iris disponível em: https://archive.ics.uci.edu/ml/datasets/iris");
            log.AppendText("\n----------\n");
            Log("Tentando carregar Dataset: " + _dataPath);
            if (!File.Exists(_dataPath))
            {
                LogWarning("Dataset não encontrado. \n");
                LogWarning("Tente marcar o properties do Dataset para copiar para o diretorio de saída. \n");
                return;
            }
            else
            {
                /*
                 * IDataView: Conjunto de interfaces e componentes que provê processamento eficiente de dados para ML e aplicações analíticias. 
                 * Enquanto "tabela" geralmente se refere a um conjunto de dados "mutáveis", "view" pode ser compreendido como um conjunto de dados resultado de uma consulta geralmente imutável.
                 * 
                 * https://github.com/dotnet/machinelearning/blob/main/docs/code/IDataViewDesignPrinciples.md
                 * 
                 */

                //Primeira etapa carregar dados
                IDataView dataView = mlContext.Data.LoadFromTextFile<Iris>(_dataPath, hasHeader: false, separatorChar: ',');
                DataSchema = dataView.Schema;

                splitData = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.25);
                LogSucesso("Dataset carregado.");

                if (!File.Exists(_modelPath))
                {
                    LogWarning("Modelo não encontrado. Realize o treinamento do Dataset.");
                }
                else
                {
                    using (FileStream fs = new FileStream(_modelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        LogSucesso("Modelo treinado.");

                        trainedModel = mlContext.Model.Load(fs, out DataSchema);

                        prediction = mlContext.Model.CreatePredictionEngine<Iris, IrisPrediction>(trainedModel);

                        btn_prever.Enabled = true;
                        LogSucesso("Modelo carregado.");
                    }
                    
                }
            }

        }

        private void treinar_Click(object sender, EventArgs e)
        {
            Log("Iniciando treinamento.");


            var watch = Stopwatch.StartNew();
            //Segunda etapa: Transformação dos dados
            var dataProcessPipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: nameof(Iris.Label))
            .Append(mlContext.Transforms.Concatenate("Features",
                nameof(Iris.SepalLength),
                nameof(Iris.SepalWidth),
                nameof(Iris.PetalLength),
                nameof(Iris.PetalWidth))
            .AppendCacheCheckpoint(mlContext));

            Log("Aguarde...");

            //Terceira etapa: Treinamento de um modelo de ML
            var trainer = mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(labelColumnName: "Label", featureColumnName: "Features");

            var trainingPipeline = dataProcessPipeline.Append(trainer);
            var trainedModel = trainingPipeline.Fit(splitData.TrainSet);

            watch.Stop();

            var tempo = watch.ElapsedMilliseconds / 1000;

            LogSucesso("Treinamento finalizado. Tempo gasto: " + tempo + " segundos.");


            //Quarta etapa: Avaliação do modelo.
            var predictions = trainedModel.Transform(splitData.TestSet);
            var metrics = mlContext.MulticlassClassification.Evaluate(predictions, "Label", "Score");

            Log("Acurácia: " + metrics.MacroAccuracy + " de 0 a 1, quando maior melhor!");
            Log("LogLoss:" + metrics.LogLoss + "0 a 1, quanto menor melhor!");

            Log("LogLoss classe 1:" + metrics.PerClassLogLoss[0] + " -> 0 a 1, quanto menor melhor!");
            Log("LogLoss classe 2:" + metrics.PerClassLogLoss[1] + " -> 0 a 1, quanto menor melhor!");
            Log("LogLoss classe 3:" + metrics.PerClassLogLoss[2] + " -> 0 a 1, quanto menor melhor!");


            //Quinta etapa: Serializando modelo.
            using (FileStream fs = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write)) {
                mlContext.Model.Save(trainedModel, DataSchema, fs);
                LogSucesso("Modelo salvo em: " + _modelPath);
            }

            Log("Finalizado.");


        }






        private void LogWarning(string mensagem)
        {
            log.AppendText("[WARNING]: " + mensagem);
            log.AppendText("\n");
        }

        private void LogSucesso(string mensagem)
        {
            log.AppendText("[SUCCESS]: " + mensagem);
            log.AppendText("\n");
        }

        private void Log(string mensagem)
        {
            log.AppendText(mensagem);
            log.AppendText("\n");
        }

        private void btn_prever_Click(object sender, EventArgs e)
        {

            var amostra = new Iris
            {
                Label = "Iris-setosa",
                PetalLength = float.Parse(txt_petala_largura.Text),
                PetalWidth = float.Parse(txt_petala_comprimento.Text),
                SepalLength = float.Parse(txt_sepala_largura.Text),
                SepalWidth = float.Parse(txt_sepala_comprimento.Text)
            };

            IrisPrediction result = prediction.Predict(amostra);

            Log(String.Format("Probabilidade Class 0: {0:0.###}", result.Score[0]));
            Log(String.Format("Probabilidade Class 1: {0:0.###}", result.Score[1]));
            Log(String.Format("Probabilidade Class 2: {0:0.###}", result.Score[2]));

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_amostra_setosa_Click(object sender, EventArgs e)
        {
            
            txt_sepala_largura.Text = "4,6";
            txt_sepala_comprimento.Text = "3,4";
            txt_petala_largura.Text = "1,4";
            txt_petala_comprimento.Text = "0,3";

        }

        private void btn_amostra_versicolor_Click(object sender, EventArgs e)
        {
            txt_sepala_largura.Text = "7,0";
            txt_sepala_comprimento.Text = "3,2";
            txt_petala_largura.Text = "4,7";
            txt_petala_comprimento.Text = "1,4";
        }

        private void btn_amostra_virginica_Click(object sender, EventArgs e)
        {
            txt_sepala_largura.Text = "7,4";
            txt_sepala_comprimento.Text = "2,8";
            txt_petala_largura.Text = "6,1";
            txt_petala_comprimento.Text = "1,9";
        }
    }
}
