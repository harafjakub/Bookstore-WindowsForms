namespace JakubHaraf_InternetBookstore
{
    partial class FormBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowse));
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelBrowseProducts = new System.Windows.Forms.Label();
            this.labelNumOfProducts = new System.Windows.Forms.Label();
            this.labelNumOfBooks = new System.Windows.Forms.Label();
            this.labelNumOfGames = new System.Windows.Forms.Label();
            this.labelNumOfProductsValue = new System.Windows.Forms.Label();
            this.labelNumOfBooksValue = new System.Windows.Forms.Label();
            this.labelNumOfGamesValue = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelProductNumber = new System.Windows.Forms.Label();
            this.labelNumberFromValue = new System.Windows.Forms.Label();
            this.labelOf = new System.Windows.Forms.Label();
            this.labelNumberToValue = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.checkBoxGames = new System.Windows.Forms.CheckBox();
            this.checkBoxBooks = new System.Windows.Forms.CheckBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupBoxSummary.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(16, 644);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.TabIndex = 209;
            this.buttonExit.Text = "GO BACK";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(796, 218);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(305, 420);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 211;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCover_MouseDoubleClick);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(16, 184);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(170, 28);
            this.buttonPrevious.TabIndex = 212;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(192, 184);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(170, 28);
            this.buttonNext.TabIndex = 213;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelBrowseProducts
            // 
            this.labelBrowseProducts.AutoSize = true;
            this.labelBrowseProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrowseProducts.Location = new System.Drawing.Point(12, 20);
            this.labelBrowseProducts.Name = "labelBrowseProducts";
            this.labelBrowseProducts.Size = new System.Drawing.Size(248, 24);
            this.labelBrowseProducts.TabIndex = 214;
            this.labelBrowseProducts.Text = "Browse products in the store";
            // 
            // labelNumOfProducts
            // 
            this.labelNumOfProducts.AutoSize = true;
            this.labelNumOfProducts.Location = new System.Drawing.Point(11, 21);
            this.labelNumOfProducts.Name = "labelNumOfProducts";
            this.labelNumOfProducts.Size = new System.Drawing.Size(103, 13);
            this.labelNumOfProducts.TabIndex = 215;
            this.labelNumOfProducts.Text = "Number of products:";
            // 
            // labelNumOfBooks
            // 
            this.labelNumOfBooks.AutoSize = true;
            this.labelNumOfBooks.Location = new System.Drawing.Point(11, 44);
            this.labelNumOfBooks.Name = "labelNumOfBooks";
            this.labelNumOfBooks.Size = new System.Drawing.Size(91, 13);
            this.labelNumOfBooks.TabIndex = 216;
            this.labelNumOfBooks.Text = "Number of books:";
            // 
            // labelNumOfGames
            // 
            this.labelNumOfGames.AutoSize = true;
            this.labelNumOfGames.Location = new System.Drawing.Point(11, 67);
            this.labelNumOfGames.Name = "labelNumOfGames";
            this.labelNumOfGames.Size = new System.Drawing.Size(93, 13);
            this.labelNumOfGames.TabIndex = 217;
            this.labelNumOfGames.Text = "Number of games:";
            // 
            // labelNumOfProductsValue
            // 
            this.labelNumOfProductsValue.AutoSize = true;
            this.labelNumOfProductsValue.Location = new System.Drawing.Point(120, 21);
            this.labelNumOfProductsValue.Name = "labelNumOfProductsValue";
            this.labelNumOfProductsValue.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfProductsValue.TabIndex = 218;
            this.labelNumOfProductsValue.Text = "0";
            // 
            // labelNumOfBooksValue
            // 
            this.labelNumOfBooksValue.AutoSize = true;
            this.labelNumOfBooksValue.Location = new System.Drawing.Point(120, 44);
            this.labelNumOfBooksValue.Name = "labelNumOfBooksValue";
            this.labelNumOfBooksValue.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfBooksValue.TabIndex = 219;
            this.labelNumOfBooksValue.Text = "0";
            // 
            // labelNumOfGamesValue
            // 
            this.labelNumOfGamesValue.AutoSize = true;
            this.labelNumOfGamesValue.Location = new System.Drawing.Point(120, 67);
            this.labelNumOfGamesValue.Name = "labelNumOfGamesValue";
            this.labelNumOfGamesValue.Size = new System.Drawing.Size(13, 13);
            this.labelNumOfGamesValue.TabIndex = 220;
            this.labelNumOfGamesValue.Text = "0";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelNumOfProducts);
            this.groupBoxSummary.Controls.Add(this.labelNumOfGamesValue);
            this.groupBoxSummary.Controls.Add(this.labelNumOfBooks);
            this.groupBoxSummary.Controls.Add(this.labelNumOfBooksValue);
            this.groupBoxSummary.Controls.Add(this.labelNumOfGames);
            this.groupBoxSummary.Controls.Add(this.labelNumOfProductsValue);
            this.groupBoxSummary.Location = new System.Drawing.Point(955, 59);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(146, 92);
            this.groupBoxSummary.TabIndex = 221;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary of the number";
            this.groupBoxSummary.MouseHover += new System.EventHandler(this.groupBoxSummary_MouseHover);
            // 
            // labelProductNumber
            // 
            this.labelProductNumber.AutoSize = true;
            this.labelProductNumber.Location = new System.Drawing.Point(599, 199);
            this.labelProductNumber.Name = "labelProductNumber";
            this.labelProductNumber.Size = new System.Drawing.Size(82, 13);
            this.labelProductNumber.TabIndex = 222;
            this.labelProductNumber.Text = "Product number";
            // 
            // labelNumberFromValue
            // 
            this.labelNumberFromValue.AutoSize = true;
            this.labelNumberFromValue.Location = new System.Drawing.Point(687, 199);
            this.labelNumberFromValue.MaximumSize = new System.Drawing.Size(31, 13);
            this.labelNumberFromValue.MinimumSize = new System.Drawing.Size(31, 13);
            this.labelNumberFromValue.Name = "labelNumberFromValue";
            this.labelNumberFromValue.Size = new System.Drawing.Size(31, 13);
            this.labelNumberFromValue.TabIndex = 223;
            this.labelNumberFromValue.Text = "0";
            this.labelNumberFromValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.Location = new System.Drawing.Point(724, 199);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(16, 13);
            this.labelOf.TabIndex = 224;
            this.labelOf.Text = "of";
            // 
            // labelNumberToValue
            // 
            this.labelNumberToValue.AutoSize = true;
            this.labelNumberToValue.Location = new System.Drawing.Point(746, 199);
            this.labelNumberToValue.MaximumSize = new System.Drawing.Size(31, 13);
            this.labelNumberToValue.MinimumSize = new System.Drawing.Size(31, 13);
            this.labelNumberToValue.Name = "labelNumberToValue";
            this.labelNumberToValue.Size = new System.Drawing.Size(31, 13);
            this.labelNumberToValue.TabIndex = 226;
            this.labelNumberToValue.Text = "0";
            this.labelNumberToValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(16, 218);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(761, 420);
            this.listBoxDisplay.TabIndex = 210;
            // 
            // checkBoxGames
            // 
            this.checkBoxGames.AutoSize = true;
            this.checkBoxGames.Checked = true;
            this.checkBoxGames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGames.Location = new System.Drawing.Point(69, 27);
            this.checkBoxGames.Name = "checkBoxGames";
            this.checkBoxGames.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGames.TabIndex = 227;
            this.checkBoxGames.Text = "Games";
            this.checkBoxGames.UseVisualStyleBackColor = true;
            // 
            // checkBoxBooks
            // 
            this.checkBoxBooks.AutoSize = true;
            this.checkBoxBooks.Checked = true;
            this.checkBoxBooks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBooks.Location = new System.Drawing.Point(7, 27);
            this.checkBoxBooks.Name = "checkBoxBooks";
            this.checkBoxBooks.Size = new System.Drawing.Size(56, 17);
            this.checkBoxBooks.TabIndex = 228;
            this.checkBoxBooks.Text = "Books";
            this.checkBoxBooks.UseVisualStyleBackColor = true;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(7, 51);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(170, 28);
            this.buttonApplyFilters.TabIndex = 229;
            this.buttonApplyFilters.Text = "Apply filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.checkBoxBooks);
            this.groupBoxFilters.Controls.Add(this.checkBoxGames);
            this.groupBoxFilters.Controls.Add(this.buttonApplyFilters);
            this.groupBoxFilters.Location = new System.Drawing.Point(16, 59);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(183, 95);
            this.groupBoxFilters.TabIndex = 234;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 28);
            this.buttonDelete.TabIndex = 230;
            this.buttonDelete.Text = "Delete product";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelProductId);
            this.groupBox2.Controls.Add(this.numericUpDownId);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Location = new System.Drawing.Point(205, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 95);
            this.groupBox2.TabIndex = 236;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(9, 27);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(58, 13);
            this.labelProductId.TabIndex = 232;
            this.labelProductId.Text = "Product id:";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(73, 24);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownId.TabIndex = 231;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.labelNumberToValue);
            this.Controls.Add(this.labelOf);
            this.Controls.Add(this.labelNumberFromValue);
            this.Controls.Add(this.labelProductNumber);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.labelBrowseProducts);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete products";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelBrowseProducts;
        private System.Windows.Forms.Label labelNumOfProducts;
        private System.Windows.Forms.Label labelNumOfBooks;
        private System.Windows.Forms.Label labelNumOfGames;
        private System.Windows.Forms.Label labelNumOfProductsValue;
        private System.Windows.Forms.Label labelNumOfBooksValue;
        private System.Windows.Forms.Label labelNumOfGamesValue;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelProductNumber;
        private System.Windows.Forms.Label labelNumberFromValue;
        private System.Windows.Forms.Label labelOf;
        private System.Windows.Forms.Label labelNumberToValue;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxGames;
        private System.Windows.Forms.CheckBox checkBoxBooks;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}