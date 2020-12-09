using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;





namespace Word2Vec
{
    internal partial class SettingsForm_Word2Vec : Form
    {


        #region Get and Set Options

        public string IncomingTextLocation { get; set; }
        public string OutgoingFileLocation { get; set; }
        public string SelectedEncoding { get; set; }

        public int VecSize { get; set; }
        public int CBow { get; set; }
        public float Alpha { get; set; }
        public int Window { get; set; }
        public int HierarchicalSoftmax { get; set; }
        public int Iterations { get; set; }
        public int MinCount { get; set; }
        public float SampleThreshold { get; set; }
        public int NegativeExamples { get; set; }


        #endregion



        public SettingsForm_Word2Vec(string CorpusFileLocation, string OutputLocation, string SelectedEncoding,
                int VecSize,
                int CBow,
                float Alpha,
                int Window,
                int HierarchicalSoftmax,
                int Iterations,
                int MinCount,
                float SampleThreshold,
                int NegativeExamples)

        {
            InitializeComponent();

            foreach (var encoding in Encoding.GetEncodings())
            {
                EncodingDropdown.Items.Add(encoding.Name);
            }

            try
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact(SelectedEncoding);
            }
            catch
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }

            SelectedFileTextbox.Text = CorpusFileLocation;
            this.SelectedEncoding = SelectedEncoding;

            SelectOutputTextbox.Text = OutputLocation;

            SettingVector.Value = VecSize;


            
            if (CBow == 1)
            {
                ModelTypeDropdown.SelectedIndex = ModelTypeDropdown.FindStringExact("CBOW");
            }
            else
            {
                ModelTypeDropdown.SelectedIndex = ModelTypeDropdown.FindStringExact("Skipgram");
            }


            if (HierarchicalSoftmax == 1)
            {
                HierarchicalSoftmaxDropdown.SelectedIndex = HierarchicalSoftmaxDropdown.FindStringExact("Yes");
            }
            else
            {
                HierarchicalSoftmaxDropdown.SelectedIndex = HierarchicalSoftmaxDropdown.FindStringExact("No");
            }



            //SettingCBOW.Value = CBow;
            SettingAlpha.Value = (decimal)Alpha;
            SettingWindow.Value = Window;
            //SettingSoftmax.Value = HierarchicalSoftmax;
            SettingIters.Value = Iterations;
            SettingMinWordThresh.Value = MinCount;
            SettingSampleThresh.Value = (decimal)SampleThreshold;
            SettingNegativeExamples.Value = NegativeExamples;
            
        }












        private void SetFolderButton_Click(object sender, System.EventArgs e)
        {


            SelectedFileTextbox.Text = "";

            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.ValidateNames = true;
                dialog.Title = "Please choose the corpus file that you would like to process";
                dialog.FileName = "Corpus File.txt";
                dialog.Filter = "Text File (*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFileTextbox.Text = dialog.FileName;

                }
            }
        }





        private void ChooseOutputLocationButton_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Please choose the output location for your trained Word2Vec model";
                dialog.FileName = "Word2Vec-Model.txt";
                dialog.Filter = "Text File (*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (File.Exists(dialog.FileName.ToString()))
                        {
                            if (DialogResult.Yes == MessageBox.Show("BUTTER is about to overwrite your selected file. Are you ABSOLUTELY sure that you want to do this? All data currently contained in the selected file will immediately be deleted if you select \"Yes\".", "Overwrite File?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                using (var myFile = File.Create(dialog.FileName.ToString())) { }
                                SelectOutputTextbox.Text = dialog.FileName.ToString();
                            }
                            else
                            {
                                SelectOutputTextbox.Text = "";
                            }
                        }
                        else
                        {
                            using (var myFile = File.Create(dialog.FileName.ToString())) { }
                            SelectOutputTextbox.Text = dialog.FileName.ToString();
                        }



                    }
                    catch
                    {
                        MessageBox.Show("BUTTER does not appear to be able to create this output file. Do you have write permissions for this file? Is the file already open in another program?", "Cannot Create File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SelectOutputTextbox.Text = "";
                    }
                }
            }
        }






        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.SelectedEncoding = EncodingDropdown.SelectedItem.ToString();
            this.IncomingTextLocation = SelectedFileTextbox.Text;
            this.OutgoingFileLocation = SelectOutputTextbox.Text;

            if (ModelTypeDropdown.Text == "CBOW")
            {
                CBow = 1;
            }
            else
            {
                CBow = 0;
            }

            if (HierarchicalSoftmaxDropdown.Text == "Yes")
            {
                HierarchicalSoftmax = 1;
            }
            else
            {
                HierarchicalSoftmax = 0;
            }


            try { VecSize = (int)SettingVector.Value; } catch { MessageBox.Show("Your Vector Size setting must be a positive integer.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { Alpha = (float)SettingAlpha.Value; } catch { MessageBox.Show("Your Alpha setting is not valid.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { Window = (int)SettingWindow.Value; } catch { MessageBox.Show("Your Word Window setting must be a positive integer.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //try { HierarchicalSoftmax = (int)SettingSoftmax.Value; } catch { MessageBox.Show("Your Softmax setting must be either 0 or 1.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { Iterations = (int)SettingIters.Value; } catch { MessageBox.Show("Your Iterations setting must be a positive integer.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { MinCount = (int)SettingMinWordThresh.Value; } catch { MessageBox.Show("Your Minimum Word Threshold setting must be a positive integer.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { SampleThreshold = (float)SettingSampleThresh.Value; } catch { MessageBox.Show("Your Sampling Threshold setting is not valid.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try { NegativeExamples = (int)SettingNegativeExamples.Value; } catch { MessageBox.Show("Your Negative Examples setting is not valid.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }



            this.DialogResult = DialogResult.OK;

        }

        private void SettingCBOW_ValueChanged(object sender, System.EventArgs e)
        {
            if (ModelTypeDropdown.Text == "Skipgram")
            {
                SettingAlpha.Value = (decimal)0.025;
            }
            else
            {
                SettingAlpha.Value = (decimal)0.05;
            }
        }
    }
}
