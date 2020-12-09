namespace Word2Vec
{
    partial class SettingsForm_Word2Vec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_Word2Vec));
            this.SetFileButton = new System.Windows.Forms.Button();
            this.SelectedFileTextbox = new System.Windows.Forms.TextBox();
            this.EncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectOutputTextbox = new System.Windows.Forms.TextBox();
            this.ChooseOutputLocationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SettingVector = new System.Windows.Forms.NumericUpDown();
            this.SettingAlpha = new System.Windows.Forms.NumericUpDown();
            this.SettingWindow = new System.Windows.Forms.NumericUpDown();
            this.SettingIters = new System.Windows.Forms.NumericUpDown();
            this.SettingMinWordThresh = new System.Windows.Forms.NumericUpDown();
            this.SettingSampleThresh = new System.Windows.Forms.NumericUpDown();
            this.SettingNegativeExamples = new System.Windows.Forms.NumericUpDown();
            this.TrainingSettingsGB = new System.Windows.Forms.GroupBox();
            this.ModelTypeDropdown = new System.Windows.Forms.ComboBox();
            this.HierarchicalSoftmaxDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SettingVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingMinWordThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingSampleThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingNegativeExamples)).BeginInit();
            this.TrainingSettingsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetFileButton
            // 
            this.SetFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetFileButton.Location = new System.Drawing.Point(12, 159);
            this.SetFileButton.Name = "SetFileButton";
            this.SetFileButton.Size = new System.Drawing.Size(118, 40);
            this.SetFileButton.TabIndex = 0;
            this.SetFileButton.Text = "Choose File";
            this.SetFileButton.UseVisualStyleBackColor = true;
            this.SetFileButton.Click += new System.EventHandler(this.SetFolderButton_Click);
            // 
            // SelectedFileTextbox
            // 
            this.SelectedFileTextbox.Enabled = false;
            this.SelectedFileTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileTextbox.Location = new System.Drawing.Point(12, 130);
            this.SelectedFileTextbox.MaxLength = 2147483647;
            this.SelectedFileTextbox.Name = "SelectedFileTextbox";
            this.SelectedFileTextbox.Size = new System.Drawing.Size(542, 23);
            this.SelectedFileTextbox.TabIndex = 1;
            // 
            // EncodingDropdown
            // 
            this.EncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingDropdown.FormattingEnabled = true;
            this.EncodingDropdown.Location = new System.Drawing.Point(12, 50);
            this.EncodingDropdown.Name = "EncodingDropdown";
            this.EncodingDropdown.Size = new System.Drawing.Size(268, 23);
            this.EncodingDropdown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Input Corpus File (.txt)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Corpus File Encoding";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(522, 561);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Word2Vec Model Output File";
            // 
            // SelectOutputTextbox
            // 
            this.SelectOutputTextbox.Enabled = false;
            this.SelectOutputTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectOutputTextbox.Location = new System.Drawing.Point(15, 263);
            this.SelectOutputTextbox.MaxLength = 2147483647;
            this.SelectOutputTextbox.Name = "SelectOutputTextbox";
            this.SelectOutputTextbox.Size = new System.Drawing.Size(542, 23);
            this.SelectOutputTextbox.TabIndex = 8;
            // 
            // ChooseOutputLocationButton
            // 
            this.ChooseOutputLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOutputLocationButton.Location = new System.Drawing.Point(15, 292);
            this.ChooseOutputLocationButton.Name = "ChooseOutputLocationButton";
            this.ChooseOutputLocationButton.Size = new System.Drawing.Size(118, 40);
            this.ChooseOutputLocationButton.TabIndex = 7;
            this.ChooseOutputLocationButton.Text = "Choose Model Output File";
            this.ChooseOutputLocationButton.UseVisualStyleBackColor = true;
            this.ChooseOutputLocationButton.Click += new System.EventHandler(this.ChooseOutputLocationButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vector Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alpha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Window Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Use Hierarchical Softmax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Iterations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Minimum Word Threshold";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Sample Threshold";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Negative Examples";
            // 
            // SettingVector
            // 
            this.SettingVector.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingVector.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SettingVector.Location = new System.Drawing.Point(335, 36);
            this.SettingVector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SettingVector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingVector.Name = "SettingVector";
            this.SettingVector.Size = new System.Drawing.Size(120, 23);
            this.SettingVector.TabIndex = 19;
            this.SettingVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingVector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingAlpha
            // 
            this.SettingAlpha.DecimalPlaces = 5;
            this.SettingAlpha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.SettingAlpha.Location = new System.Drawing.Point(335, 136);
            this.SettingAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingAlpha.Name = "SettingAlpha";
            this.SettingAlpha.Size = new System.Drawing.Size(120, 23);
            this.SettingAlpha.TabIndex = 21;
            this.SettingAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingWindow
            // 
            this.SettingWindow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingWindow.Location = new System.Drawing.Point(335, 188);
            this.SettingWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingWindow.Name = "SettingWindow";
            this.SettingWindow.Size = new System.Drawing.Size(120, 23);
            this.SettingWindow.TabIndex = 22;
            this.SettingWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingWindow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingIters
            // 
            this.SettingIters.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingIters.Location = new System.Drawing.Point(335, 298);
            this.SettingIters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SettingIters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingIters.Name = "SettingIters";
            this.SettingIters.Size = new System.Drawing.Size(120, 23);
            this.SettingIters.TabIndex = 24;
            this.SettingIters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingIters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingMinWordThresh
            // 
            this.SettingMinWordThresh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingMinWordThresh.Location = new System.Drawing.Point(335, 351);
            this.SettingMinWordThresh.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SettingMinWordThresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingMinWordThresh.Name = "SettingMinWordThresh";
            this.SettingMinWordThresh.Size = new System.Drawing.Size(120, 23);
            this.SettingMinWordThresh.TabIndex = 25;
            this.SettingMinWordThresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingMinWordThresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingSampleThresh
            // 
            this.SettingSampleThresh.DecimalPlaces = 5;
            this.SettingSampleThresh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingSampleThresh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.SettingSampleThresh.Location = new System.Drawing.Point(335, 407);
            this.SettingSampleThresh.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingSampleThresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.SettingSampleThresh.Name = "SettingSampleThresh";
            this.SettingSampleThresh.Size = new System.Drawing.Size(120, 23);
            this.SettingSampleThresh.TabIndex = 26;
            this.SettingSampleThresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingSampleThresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingNegativeExamples
            // 
            this.SettingNegativeExamples.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingNegativeExamples.Location = new System.Drawing.Point(335, 463);
            this.SettingNegativeExamples.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SettingNegativeExamples.Name = "SettingNegativeExamples";
            this.SettingNegativeExamples.Size = new System.Drawing.Size(120, 23);
            this.SettingNegativeExamples.TabIndex = 27;
            this.SettingNegativeExamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingNegativeExamples.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TrainingSettingsGB
            // 
            this.TrainingSettingsGB.Controls.Add(this.HierarchicalSoftmaxDropdown);
            this.TrainingSettingsGB.Controls.Add(this.ModelTypeDropdown);
            this.TrainingSettingsGB.Controls.Add(this.label4);
            this.TrainingSettingsGB.Controls.Add(this.SettingNegativeExamples);
            this.TrainingSettingsGB.Controls.Add(this.label5);
            this.TrainingSettingsGB.Controls.Add(this.SettingSampleThresh);
            this.TrainingSettingsGB.Controls.Add(this.label6);
            this.TrainingSettingsGB.Controls.Add(this.SettingMinWordThresh);
            this.TrainingSettingsGB.Controls.Add(this.label7);
            this.TrainingSettingsGB.Controls.Add(this.SettingIters);
            this.TrainingSettingsGB.Controls.Add(this.label8);
            this.TrainingSettingsGB.Controls.Add(this.label9);
            this.TrainingSettingsGB.Controls.Add(this.SettingWindow);
            this.TrainingSettingsGB.Controls.Add(this.label10);
            this.TrainingSettingsGB.Controls.Add(this.SettingAlpha);
            this.TrainingSettingsGB.Controls.Add(this.label11);
            this.TrainingSettingsGB.Controls.Add(this.label12);
            this.TrainingSettingsGB.Controls.Add(this.SettingVector);
            this.TrainingSettingsGB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainingSettingsGB.Location = new System.Drawing.Point(632, 31);
            this.TrainingSettingsGB.Name = "TrainingSettingsGB";
            this.TrainingSettingsGB.Size = new System.Drawing.Size(487, 503);
            this.TrainingSettingsGB.TabIndex = 28;
            this.TrainingSettingsGB.TabStop = false;
            this.TrainingSettingsGB.Text = "Training Settings";
            // 
            // ModelTypeDropdown
            // 
            this.ModelTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelTypeDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTypeDropdown.FormattingEnabled = true;
            this.ModelTypeDropdown.Items.AddRange(new object[] {
            "Skipgram",
            "CBOW"});
            this.ModelTypeDropdown.Location = new System.Drawing.Point(335, 85);
            this.ModelTypeDropdown.Name = "ModelTypeDropdown";
            this.ModelTypeDropdown.Size = new System.Drawing.Size(120, 23);
            this.ModelTypeDropdown.TabIndex = 29;
            this.ModelTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.SettingCBOW_ValueChanged);
            // 
            // HierarchicalSoftmaxDropdown
            // 
            this.HierarchicalSoftmaxDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HierarchicalSoftmaxDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HierarchicalSoftmaxDropdown.FormattingEnabled = true;
            this.HierarchicalSoftmaxDropdown.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.HierarchicalSoftmaxDropdown.Location = new System.Drawing.Point(335, 241);
            this.HierarchicalSoftmaxDropdown.Name = "HierarchicalSoftmaxDropdown";
            this.HierarchicalSoftmaxDropdown.Size = new System.Drawing.Size(120, 23);
            this.HierarchicalSoftmaxDropdown.TabIndex = 30;
            // 
            // SettingsForm_Word2Vec
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 613);
            this.Controls.Add(this.TrainingSettingsGB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectOutputTextbox);
            this.Controls.Add(this.ChooseOutputLocationButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncodingDropdown);
            this.Controls.Add(this.SelectedFileTextbox);
            this.Controls.Add(this.SetFileButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_Word2Vec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            ((System.ComponentModel.ISupportInitialize)(this.SettingVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingMinWordThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingSampleThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingNegativeExamples)).EndInit();
            this.TrainingSettingsGB.ResumeLayout(false);
            this.TrainingSettingsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetFileButton;
        private System.Windows.Forms.TextBox SelectedFileTextbox;
        private System.Windows.Forms.ComboBox EncodingDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectOutputTextbox;
        private System.Windows.Forms.Button ChooseOutputLocationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown SettingVector;
        private System.Windows.Forms.NumericUpDown SettingAlpha;
        private System.Windows.Forms.NumericUpDown SettingWindow;
        private System.Windows.Forms.NumericUpDown SettingIters;
        private System.Windows.Forms.NumericUpDown SettingMinWordThresh;
        private System.Windows.Forms.NumericUpDown SettingSampleThresh;
        private System.Windows.Forms.NumericUpDown SettingNegativeExamples;
        private System.Windows.Forms.GroupBox TrainingSettingsGB;
        private System.Windows.Forms.ComboBox ModelTypeDropdown;
        private System.Windows.Forms.ComboBox HierarchicalSoftmaxDropdown;
    }
}