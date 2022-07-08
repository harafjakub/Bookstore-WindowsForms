namespace JakubHaraf_InternetBookstore
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonAutofill = new System.Windows.Forms.Button();
            this.textBoxSubtitleLanguage = new System.Windows.Forms.TextBox();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelPegi = new System.Windows.Forms.Label();
            this.labelSubtitleLanguages = new System.Windows.Forms.Label();
            this.labelDubbingLanguages = new System.Windows.Forms.Label();
            this.textBoxDubbingLanguage = new System.Windows.Forms.TextBox();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.numericUpDownPegi = new System.Windows.Forms.NumericUpDown();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelAutoGen = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.labelComma1 = new System.Windows.Forms.Label();
            this.labelComma2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSeries = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUploadingCover = new System.Windows.Forms.Label();
            this.buttonUploadCover = new System.Windows.Forms.Button();
            this.pictureBoxUploadingCover = new System.Windows.Forms.PictureBox();
            this.labelMultiPlayer = new System.Windows.Forms.Label();
            this.labelSinglePlayer = new System.Windows.Forms.Label();
            this.checkBoxMultiPlayer = new System.Windows.Forms.CheckBox();
            this.checkBoxSinglePlayer = new System.Windows.Forms.CheckBox();
            this.groupBoxAddingGame = new System.Windows.Forms.GroupBox();
            this.labelAddedDate = new System.Windows.Forms.Label();
            this.dateTimePickerAddedDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSoldTitles = new System.Windows.Forms.NumericUpDown();
            this.labelSoldTitles = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBoxInfoAboutGame = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPegi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadingCover)).BeginInit();
            this.groupBoxAddingGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldTitles)).BeginInit();
            this.groupBoxInfoAboutGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(11, 28);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(761, 420);
            this.listBoxDisplay.TabIndex = 172;
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Location = new System.Drawing.Point(25, 214);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(80, 28);
            this.buttonAddGame.TabIndex = 17;
            this.buttonAddGame.Text = "Add game";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // buttonAutofill
            // 
            this.buttonAutofill.Location = new System.Drawing.Point(111, 214);
            this.buttonAutofill.Name = "buttonAutofill";
            this.buttonAutofill.Size = new System.Drawing.Size(80, 28);
            this.buttonAutofill.TabIndex = 18;
            this.buttonAutofill.Text = "Autofill";
            this.buttonAutofill.UseVisualStyleBackColor = true;
            this.buttonAutofill.Click += new System.EventHandler(this.buttonAutofill_Click);
            // 
            // textBoxSubtitleLanguage
            // 
            this.textBoxSubtitleLanguage.Location = new System.Drawing.Point(702, 37);
            this.textBoxSubtitleLanguage.Name = "textBoxSubtitleLanguage";
            this.textBoxSubtitleLanguage.Size = new System.Drawing.Size(150, 20);
            this.textBoxSubtitleLanguage.TabIndex = 13;
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Location = new System.Drawing.Point(597, 93);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(48, 13);
            this.labelPlatform.TabIndex = 68;
            this.labelPlatform.Text = "Platform:";
            // 
            // labelPegi
            // 
            this.labelPegi.AutoSize = true;
            this.labelPegi.Location = new System.Drawing.Point(597, 67);
            this.labelPegi.Name = "labelPegi";
            this.labelPegi.Size = new System.Drawing.Size(35, 13);
            this.labelPegi.TabIndex = 67;
            this.labelPegi.Text = "PEGI:";
            // 
            // labelSubtitleLanguages
            // 
            this.labelSubtitleLanguages.AutoSize = true;
            this.labelSubtitleLanguages.Location = new System.Drawing.Point(597, 37);
            this.labelSubtitleLanguages.Name = "labelSubtitleLanguages";
            this.labelSubtitleLanguages.Size = new System.Drawing.Size(103, 13);
            this.labelSubtitleLanguages.TabIndex = 66;
            this.labelSubtitleLanguages.Text = "Subtitle language(s):";
            // 
            // labelDubbingLanguages
            // 
            this.labelDubbingLanguages.AutoSize = true;
            this.labelDubbingLanguages.Location = new System.Drawing.Point(298, 170);
            this.labelDubbingLanguages.Name = "labelDubbingLanguages";
            this.labelDubbingLanguages.Size = new System.Drawing.Size(108, 13);
            this.labelDubbingLanguages.TabIndex = 65;
            this.labelDubbingLanguages.Text = "Dubbing language(s):";
            // 
            // textBoxDubbingLanguage
            // 
            this.textBoxDubbingLanguage.Location = new System.Drawing.Point(410, 170);
            this.textBoxDubbingLanguage.Name = "textBoxDubbingLanguage";
            this.textBoxDubbingLanguage.Size = new System.Drawing.Size(150, 20);
            this.textBoxDubbingLanguage.TabIndex = 12;
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Location = new System.Drawing.Point(197, 214);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(80, 28);
            this.buttonClearForm.TabIndex = 19;
            this.buttonClearForm.Text = "Clear the form";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.DecimalPlaces = 1;
            this.numericUpDownRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRating.Location = new System.Drawing.Point(410, 88);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownRating.TabIndex = 9;
            this.numericUpDownRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrice.Location = new System.Drawing.Point(410, 62);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownPrice.TabIndex = 8;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(115, 174);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerReleaseDate.TabIndex = 6;
            this.dateTimePickerReleaseDate.Value = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(702, 170);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAvailable.TabIndex = 171;
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(410, 140);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(150, 20);
            this.textBoxDescription.TabIndex = 11;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(115, 147);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(150, 20);
            this.textBoxSeries.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(115, 118);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(150, 20);
            this.textBoxGenre.TabIndex = 4;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(115, 88);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(150, 20);
            this.textBoxPublisher.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(115, 62);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(150, 20);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(115, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(150, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // numericUpDownPegi
            // 
            this.numericUpDownPegi.Location = new System.Drawing.Point(702, 65);
            this.numericUpDownPegi.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownPegi.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPegi.Name = "numericUpDownPegi";
            this.numericUpDownPegi.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownPegi.TabIndex = 14;
            this.numericUpDownPegi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(597, 122);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 158;
            this.labelKey.Text = "Key:";
            // 
            // labelAutoGen
            // 
            this.labelAutoGen.AutoSize = true;
            this.labelAutoGen.BackColor = System.Drawing.SystemColors.Window;
            this.labelAutoGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAutoGen.Location = new System.Drawing.Point(702, 119);
            this.labelAutoGen.MinimumSize = new System.Drawing.Size(150, 20);
            this.labelAutoGen.Name = "labelAutoGen";
            this.labelAutoGen.Size = new System.Drawing.Size(150, 20);
            this.labelAutoGen.TabIndex = 159;
            this.labelAutoGen.Text = "Auto-generated";
            this.labelAutoGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(791, 28);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(305, 420);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 160;
            this.pictureBoxCover.TabStop = false;
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Items.AddRange(new object[] {
            "PC",
            "PS5",
            "PS4",
            "PS3",
            "Xbox One",
            "Xbox 360",
            "Switch"});
            this.comboBoxPlatform.Location = new System.Drawing.Point(702, 90);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPlatform.TabIndex = 15;
            // 
            // labelComma1
            // 
            this.labelComma1.AutoSize = true;
            this.labelComma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComma1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelComma1.Location = new System.Drawing.Point(298, 183);
            this.labelComma1.Name = "labelComma1";
            this.labelComma1.Size = new System.Drawing.Size(86, 13);
            this.labelComma1.TabIndex = 163;
            this.labelComma1.Text = "separate with \",\"";
            // 
            // labelComma2
            // 
            this.labelComma2.AutoSize = true;
            this.labelComma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComma2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelComma2.Location = new System.Drawing.Point(597, 50);
            this.labelComma2.Name = "labelComma2";
            this.labelComma2.Size = new System.Drawing.Size(86, 13);
            this.labelComma2.TabIndex = 164;
            this.labelComma2.Text = "separate with \",\"";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(298, 64);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 13);
            this.labelPrice.TabIndex = 175;
            this.labelPrice.Text = "Price (zł):";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(298, 90);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(71, 13);
            this.labelRating.TabIndex = 174;
            this.labelRating.Text = "Rating (1-10):";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(597, 169);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(53, 13);
            this.labelAvailable.TabIndex = 173;
            this.labelAvailable.Text = "Available:";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Location = new System.Drawing.Point(22, 177);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(73, 13);
            this.labelReleaseDate.TabIndex = 171;
            this.labelReleaseDate.Text = "Release date:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(298, 143);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 170;
            this.labelDescription.Text = "Description:";
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(22, 150);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(39, 13);
            this.labelSeries.TabIndex = 169;
            this.labelSeries.Text = "Series:";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Location = new System.Drawing.Point(22, 118);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(50, 13);
            this.labelGenres.TabIndex = 168;
            this.labelGenres.Text = "Genre(s):";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(22, 91);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(53, 13);
            this.labelPublisher.TabIndex = 167;
            this.labelPublisher.Text = "Publisher:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(22, 65);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 166;
            this.labelAuthor.Text = "Author:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(22, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 165;
            this.labelTitle.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "separate with \",\"";
            // 
            // labelUploadingCover
            // 
            this.labelUploadingCover.AutoSize = true;
            this.labelUploadingCover.Location = new System.Drawing.Point(889, 36);
            this.labelUploadingCover.Name = "labelUploadingCover";
            this.labelUploadingCover.Size = new System.Drawing.Size(97, 13);
            this.labelUploadingCover.TabIndex = 177;
            this.labelUploadingCover.Text = "Uploading a cover:";
            // 
            // buttonUploadCover
            // 
            this.buttonUploadCover.Location = new System.Drawing.Point(892, 161);
            this.buttonUploadCover.Name = "buttonUploadCover";
            this.buttonUploadCover.Size = new System.Drawing.Size(108, 21);
            this.buttonUploadCover.TabIndex = 16;
            this.buttonUploadCover.Text = "Upload from device";
            this.buttonUploadCover.UseVisualStyleBackColor = true;
            this.buttonUploadCover.Click += new System.EventHandler(this.buttonUploadCover_Click);
            // 
            // pictureBoxUploadingCover
            // 
            this.pictureBoxUploadingCover.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxUploadingCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUploadingCover.Location = new System.Drawing.Point(892, 52);
            this.pictureBoxUploadingCover.Name = "pictureBoxUploadingCover";
            this.pictureBoxUploadingCover.Size = new System.Drawing.Size(79, 103);
            this.pictureBoxUploadingCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUploadingCover.TabIndex = 180;
            this.pictureBoxUploadingCover.TabStop = false;
            // 
            // labelMultiPlayer
            // 
            this.labelMultiPlayer.AutoSize = true;
            this.labelMultiPlayer.Location = new System.Drawing.Point(732, 148);
            this.labelMultiPlayer.Name = "labelMultiPlayer";
            this.labelMultiPlayer.Size = new System.Drawing.Size(92, 13);
            this.labelMultiPlayer.TabIndex = 184;
            this.labelMultiPlayer.Text = "Multi-player mode:";
            // 
            // labelSinglePlayer
            // 
            this.labelSinglePlayer.AutoSize = true;
            this.labelSinglePlayer.Location = new System.Drawing.Point(597, 148);
            this.labelSinglePlayer.Name = "labelSinglePlayer";
            this.labelSinglePlayer.Size = new System.Drawing.Size(99, 13);
            this.labelSinglePlayer.TabIndex = 183;
            this.labelSinglePlayer.Text = "Single-player mode:";
            // 
            // checkBoxMultiPlayer
            // 
            this.checkBoxMultiPlayer.AutoSize = true;
            this.checkBoxMultiPlayer.Location = new System.Drawing.Point(837, 148);
            this.checkBoxMultiPlayer.Name = "checkBoxMultiPlayer";
            this.checkBoxMultiPlayer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMultiPlayer.TabIndex = 161;
            this.checkBoxMultiPlayer.UseVisualStyleBackColor = true;
            // 
            // checkBoxSinglePlayer
            // 
            this.checkBoxSinglePlayer.AutoSize = true;
            this.checkBoxSinglePlayer.Location = new System.Drawing.Point(702, 148);
            this.checkBoxSinglePlayer.Name = "checkBoxSinglePlayer";
            this.checkBoxSinglePlayer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSinglePlayer.TabIndex = 151;
            this.checkBoxSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddingGame
            // 
            this.groupBoxAddingGame.Controls.Add(this.labelAddedDate);
            this.groupBoxAddingGame.Controls.Add(this.dateTimePickerAddedDate);
            this.groupBoxAddingGame.Controls.Add(this.numericUpDownSoldTitles);
            this.groupBoxAddingGame.Controls.Add(this.labelSoldTitles);
            this.groupBoxAddingGame.Controls.Add(this.pictureBoxUploadingCover);
            this.groupBoxAddingGame.Controls.Add(this.labelPath);
            this.groupBoxAddingGame.Controls.Add(this.buttonClearForm);
            this.groupBoxAddingGame.Controls.Add(this.buttonUploadCover);
            this.groupBoxAddingGame.Controls.Add(this.buttonAddGame);
            this.groupBoxAddingGame.Controls.Add(this.labelMultiPlayer);
            this.groupBoxAddingGame.Controls.Add(this.buttonAutofill);
            this.groupBoxAddingGame.Controls.Add(this.labelSinglePlayer);
            this.groupBoxAddingGame.Controls.Add(this.checkBoxMultiPlayer);
            this.groupBoxAddingGame.Controls.Add(this.textBoxDubbingLanguage);
            this.groupBoxAddingGame.Controls.Add(this.checkBoxSinglePlayer);
            this.groupBoxAddingGame.Controls.Add(this.labelDubbingLanguages);
            this.groupBoxAddingGame.Controls.Add(this.labelSubtitleLanguages);
            this.groupBoxAddingGame.Controls.Add(this.labelPegi);
            this.groupBoxAddingGame.Controls.Add(this.labelPlatform);
            this.groupBoxAddingGame.Controls.Add(this.labelUploadingCover);
            this.groupBoxAddingGame.Controls.Add(this.textBoxSubtitleLanguage);
            this.groupBoxAddingGame.Controls.Add(this.label1);
            this.groupBoxAddingGame.Controls.Add(this.textBoxTitle);
            this.groupBoxAddingGame.Controls.Add(this.labelPrice);
            this.groupBoxAddingGame.Controls.Add(this.textBoxAuthor);
            this.groupBoxAddingGame.Controls.Add(this.labelRating);
            this.groupBoxAddingGame.Controls.Add(this.textBoxPublisher);
            this.groupBoxAddingGame.Controls.Add(this.labelAvailable);
            this.groupBoxAddingGame.Controls.Add(this.textBoxGenre);
            this.groupBoxAddingGame.Controls.Add(this.textBoxSeries);
            this.groupBoxAddingGame.Controls.Add(this.labelReleaseDate);
            this.groupBoxAddingGame.Controls.Add(this.textBoxDescription);
            this.groupBoxAddingGame.Controls.Add(this.labelDescription);
            this.groupBoxAddingGame.Controls.Add(this.labelSeries);
            this.groupBoxAddingGame.Controls.Add(this.checkBoxAvailable);
            this.groupBoxAddingGame.Controls.Add(this.labelGenres);
            this.groupBoxAddingGame.Controls.Add(this.dateTimePickerReleaseDate);
            this.groupBoxAddingGame.Controls.Add(this.labelPublisher);
            this.groupBoxAddingGame.Controls.Add(this.numericUpDownPrice);
            this.groupBoxAddingGame.Controls.Add(this.labelAuthor);
            this.groupBoxAddingGame.Controls.Add(this.numericUpDownRating);
            this.groupBoxAddingGame.Controls.Add(this.labelTitle);
            this.groupBoxAddingGame.Controls.Add(this.numericUpDownPegi);
            this.groupBoxAddingGame.Controls.Add(this.labelComma2);
            this.groupBoxAddingGame.Controls.Add(this.labelKey);
            this.groupBoxAddingGame.Controls.Add(this.labelComma1);
            this.groupBoxAddingGame.Controls.Add(this.labelAutoGen);
            this.groupBoxAddingGame.Controls.Add(this.comboBoxPlatform);
            this.groupBoxAddingGame.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddingGame.Name = "groupBoxAddingGame";
            this.groupBoxAddingGame.Size = new System.Drawing.Size(1115, 257);
            this.groupBoxAddingGame.TabIndex = 185;
            this.groupBoxAddingGame.TabStop = false;
            this.groupBoxAddingGame.Text = "Form for adding a new game";
            // 
            // labelAddedDate
            // 
            this.labelAddedDate.AutoSize = true;
            this.labelAddedDate.Location = new System.Drawing.Point(298, 40);
            this.labelAddedDate.Name = "labelAddedDate";
            this.labelAddedDate.Size = new System.Drawing.Size(65, 13);
            this.labelAddedDate.TabIndex = 228;
            this.labelAddedDate.Text = "Added date:";
            // 
            // dateTimePickerAddedDate
            // 
            this.dateTimePickerAddedDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerAddedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAddedDate.Location = new System.Drawing.Point(410, 36);
            this.dateTimePickerAddedDate.Name = "dateTimePickerAddedDate";
            this.dateTimePickerAddedDate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerAddedDate.TabIndex = 7;
            this.dateTimePickerAddedDate.Value = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            // 
            // numericUpDownSoldTitles
            // 
            this.numericUpDownSoldTitles.Location = new System.Drawing.Point(410, 114);
            this.numericUpDownSoldTitles.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownSoldTitles.Name = "numericUpDownSoldTitles";
            this.numericUpDownSoldTitles.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownSoldTitles.TabIndex = 10;
            // 
            // labelSoldTitles
            // 
            this.labelSoldTitles.AutoSize = true;
            this.labelSoldTitles.Location = new System.Drawing.Point(298, 116);
            this.labelSoldTitles.Name = "labelSoldTitles";
            this.labelSoldTitles.Size = new System.Drawing.Size(55, 13);
            this.labelSoldTitles.TabIndex = 226;
            this.labelSoldTitles.Text = "Sold titles:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelPath.Location = new System.Drawing.Point(894, 185);
            this.labelPath.MaximumSize = new System.Drawing.Size(210, 12);
            this.labelPath.MinimumSize = new System.Drawing.Size(210, 12);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(210, 12);
            this.labelPath.TabIndex = 181;
            this.labelPath.Text = "No file selected";
            // 
            // groupBoxInfoAboutGame
            // 
            this.groupBoxInfoAboutGame.Controls.Add(this.pictureBoxCover);
            this.groupBoxInfoAboutGame.Controls.Add(this.listBoxDisplay);
            this.groupBoxInfoAboutGame.Location = new System.Drawing.Point(12, 284);
            this.groupBoxInfoAboutGame.Name = "groupBoxInfoAboutGame";
            this.groupBoxInfoAboutGame.Size = new System.Drawing.Size(1115, 462);
            this.groupBoxInfoAboutGame.TabIndex = 186;
            this.groupBoxInfoAboutGame.TabStop = false;
            this.groupBoxInfoAboutGame.Text = "Information about added game";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(23, 752);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "GO BACK";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 790);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxInfoAboutGame);
            this.Controls.Add(this.groupBoxAddingGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding games";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPegi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadingCover)).EndInit();
            this.groupBoxAddingGame.ResumeLayout(false);
            this.groupBoxAddingGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoldTitles)).EndInit();
            this.groupBoxInfoAboutGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonAutofill;
        private System.Windows.Forms.TextBox textBoxSubtitleLanguage;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelPegi;
        private System.Windows.Forms.Label labelSubtitleLanguages;
        private System.Windows.Forms.Label labelDubbingLanguages;
        private System.Windows.Forms.TextBox textBoxDubbingLanguage;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownPegi;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelAutoGen;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.Label labelComma1;
        private System.Windows.Forms.Label labelComma2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUploadingCover;
        private System.Windows.Forms.Button buttonUploadCover;
        private System.Windows.Forms.PictureBox pictureBoxUploadingCover;
        private System.Windows.Forms.Label labelMultiPlayer;
        private System.Windows.Forms.Label labelSinglePlayer;
        private System.Windows.Forms.CheckBox checkBoxMultiPlayer;
        private System.Windows.Forms.CheckBox checkBoxSinglePlayer;
        private System.Windows.Forms.GroupBox groupBoxAddingGame;
        private System.Windows.Forms.GroupBox groupBoxInfoAboutGame;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.NumericUpDown numericUpDownSoldTitles;
        private System.Windows.Forms.Label labelSoldTitles;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAddedDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddedDate;
    }
}