using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using Word2Vec.Net;
using System.IO;


namespace Word2Vec
{
    public class Word2Vec : LinearPlugin
    {


        public string[] InputType { get; } = { "Corpus File (.txt)" };
        public string OutputType { get; } = "Word2Vec Model";
        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "TokenizedText" } };
        public bool InheritHeader { get; } = false;

        public string StatusToReport { get; set; } = "";


        #region Word2Vec Parameters
        public string IncomingTextLocation { get; set; }
        public string SelectedEncoding { get; set; } = "utf-8";
        public string ModelOutputFile { get; set; } = "";

        #endregion






        #region Plugin Details and Info

        public string PluginName { get; } = "Word2Vec (Train Model)";
        public string PluginType { get; } = "Word Embeddings";
        public string PluginVersion { get; } = "1.0.1";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Trains a word embedding model using the very popular word2vec method. This is a standalone plugin -- it should be at the top of a plugin chain. You will also most likely want to have a clean corpus file as input. This can be done using by tokenizing all of your texts, removing punctuation/etc. as stop words, and then using the \"Build Corpus\" plugin to save all of your cleaned text into a single .txt file." + Environment.NewLine + Environment.NewLine +
            "For more information on word2vec in general, please see:" + Environment.NewLine + Environment.NewLine +
            "https://code.google.com/archive/p/word2vec/" + Environment.NewLine + Environment.NewLine +
            "[1] Tomas Mikolov, Kai Chen, Greg Corrado, and Jeffrey Dean. Efficient Estimation of Word Representations in Vector Space. In Proceedings of Workshop at ICLR, 2013." + Environment.NewLine + Environment.NewLine +
            "[2] Tomas Mikolov, Ilya Sutskever, Kai Chen, Greg Corrado, and Jeffrey Dean. Distributed Representations of Words and Phrases and their Compositionality. In Proceedings of NIPS, 2013." + Environment.NewLine + Environment.NewLine +
            "[3] Tomas Mikolov, Wen-tau Yih, and Geoffrey Zweig. Linguistic Regularities in Continuous Space Word Representations. In Proceedings of NAACL HLT, 2013.";
        public bool TopLevel { get; } = true;
        public string PluginTutorial { get; } = "https://www.youtube.com/watch?v=Vk-Bf2s4FyE";



        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_Word2Vec(IncomingTextLocation, ModelOutputFile, SelectedEncoding,
                VecSize,
                CBow,
                Alpha,
                Window,
                HierarchicalSoftmax,
                Iterations,
                MinCount,
                SampleThreshold,
                NegativeExamples))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;


                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedEncoding = form.SelectedEncoding;
                    ModelOutputFile = form.OutgoingFileLocation;
                    IncomingTextLocation = form.IncomingTextLocation;
                    VecSize = form.VecSize;
                    CBow = form.CBow;
                    Alpha = form.Alpha;
                    Window = form.Window;
                    HierarchicalSoftmax = form.HierarchicalSoftmax;
                    Iterations = form.Iterations;
                    MinCount = form.MinCount;
                    SampleThreshold = form.SampleThreshold;
                    NegativeExamples = form.NegativeExamples;

                }
            }

        }




        //normal, no threading
        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;


            for (int i = 0; i < Input.StringList.Count; i++)
            {

            }

            return (pData);

        }











        private int VecSize { get; set; } = 100;
        private int CBow { get; set; } = 1;
        private float Alpha { get; set; } = (float)0.05;
        private int Window { get; set; } = 5;
        private int HierarchicalSoftmax { get; set; } = 0;
        private int Iterations { get; set; } = 5;
        private int MinCount { get; set; } = 5;
        private float SampleThreshold { get; set; } = (float)1e-3;
        private int NegativeExamples { get; set; } = 5;


        //extension method
        public Payload RunPlugin(Payload Input, int ThreadsAvailable = 1)
        {


            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;

            var word2Vec = Word2VecBuilder.Create()
                .WithTrainFile(IncomingTextLocation)// Use text data to train the model;
                .WithOutputFile(ModelOutputFile)//Use to save the resulting word vectors / word clusters
                .WithSize(VecSize)//Set size of word vectors; default is 100
                //.WithSaveVocubFile()//The vocabulary will be saved to <file>
                .WithDebug(2)//Set the debug mode (default = 2 = more info during training)
                .WithBinary(0)//Save the resulting vectors in binary moded; default is 0 (off)
                .WithCBow(CBow)//Use the continuous bag of words model; default is 1 (use 0 for skip-gram model)
                .WithAlpha(Alpha)//Set the starting learning rate; default is 0.025 for skip-gram and 0.05 for CBOW
                .WithWindow(Window)//Set max skip length between words; default is 5
                .WithSample(SampleThreshold)//Set threshold for occurrence of words. Those that appear with higher frequency in the training data twill be randomly down-sampled; default is 1e-3, useful range is (0, 1e-5)
                .WithHs(HierarchicalSoftmax)//Use Hierarchical Softmax; default is 0 (not used)
                .WithNegative(NegativeExamples)//Number of negative examples; default is 5, common values are 3 - 10 (0 = not used)
                .WithThreads(ThreadsAvailable)//Use <int> threads (default 12)
                .WithIter(Iterations)//Run more training iterations (default 5)
                .WithMinCount(MinCount)//This will discard words that appear less than <int> times; default is 5
                .WithClasses(0)//Output word classes rather than word vectors; default number of classes is 0 (vectors are written)
                .Build();


            TimeSpan reportPeriod = TimeSpan.FromMinutes(0.01);
            using (new System.Threading.Timer(
                           _ => UpdateStatus(word2Vec.StatusToReport), null, reportPeriod, reportPeriod))
            {
                word2Vec.TrainModel();
            }
                


            return (pData);

        }


        private void UpdateStatus(object status)
        {
            StatusToReport = status.ToString();
        }


        public void Initialize() { }

        public bool InspectSettings()
        {
            if (string.IsNullOrEmpty(IncomingTextLocation) || string.IsNullOrEmpty(ModelOutputFile))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }






        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            SelectedEncoding = SettingsDict["SelectedEncoding"];
            ModelOutputFile = SettingsDict["ModelOutputFile"];
            IncomingTextLocation = SettingsDict["IncomingTextLocation"];
            VecSize = int.Parse(SettingsDict["VecSize"]);
            CBow = int.Parse(SettingsDict["CBow"]);
            Alpha = float.Parse(SettingsDict["Alpha"]);
            Window = int.Parse(SettingsDict["Window"]);
            HierarchicalSoftmax = int.Parse(SettingsDict["HierarchicalSoftmax"]);
            Iterations = int.Parse(SettingsDict["Iterations"]);
            MinCount = int.Parse(SettingsDict["MinCount"]);
            SampleThreshold = float.Parse(SettingsDict["SampleThreshold"]);
            NegativeExamples = int.Parse(SettingsDict["NegativeExamples"]);
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("SelectedEncoding", SelectedEncoding);
            SettingsDict.Add("ModelOutputFile", ModelOutputFile);
            SettingsDict.Add("IncomingTextLocation", IncomingTextLocation);
            SettingsDict.Add("VecSize", VecSize.ToString());
            SettingsDict.Add("CBow", CBow.ToString());
            SettingsDict.Add("Alpha", Alpha.ToString());
            SettingsDict.Add("Window", Window.ToString());
            SettingsDict.Add("HierarchicalSoftmax", HierarchicalSoftmax.ToString());
            SettingsDict.Add("Iterations", Iterations.ToString());
            SettingsDict.Add("MinCount", MinCount.ToString());
            SettingsDict.Add("SampleThreshold", SampleThreshold.ToString());
            SettingsDict.Add("NegativeExamples", NegativeExamples.ToString());
            return (SettingsDict);
        }
        #endregion




    }
}
