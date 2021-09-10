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


        MLContext mlContext = new MLContext(seed: 1234);
        DataOperationsCatalog.TrainTestData splitData;


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

                splitData = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.25);
                LogSucesso("Dataset carregado.");

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


            //Avaliação do modelo.
            var predictions = trainedModel.Transform(splitData.TestSet);
            var metrics = mlContext.MulticlassClassification.Evaluate(predictions, "Label", "Score");

            Log("Acurácia: " + metrics.MacroAccuracy + " de 0 a 1, quando maior melhor!");
            Log("LogLoss:" + metrics.LogLoss + "0 a 1, quanto menor melhor!");

            Log("LogLoss classe 1:" + metrics.PerClassLogLoss[0] + " -> 0 a 1, quanto menor melhor!");
            Log("LogLoss classe 2:" + metrics.PerClassLogLoss[1] + " -> 0 a 1, quanto menor melhor!");
            Log("LogLoss classe 3:" + metrics.PerClassLogLoss[2] + " -> 0 a 1, quanto menor melhor!");


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
    }
}
