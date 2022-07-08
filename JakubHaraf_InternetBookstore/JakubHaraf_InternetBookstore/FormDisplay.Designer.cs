namespace JakubHaraf_InternetBookstore
{
    partial class FormDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplay));
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soldQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.checkBoxActiveRange = new System.Windows.Forms.CheckBox();
            this.checkBoxActiveText = new System.Windows.Forms.CheckBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxTextPhrase = new System.Windows.Forms.TextBox();
            this.numericUpDownPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPriceTo = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelPriceRange = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.groupBoxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.labelTextPhrase = new System.Windows.Forms.Label();
            this.buttonResetSort = new System.Windows.Forms.Button();
            this.groupBoxSorting = new System.Windows.Forms.GroupBox();
            this.labelSortDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceTo)).BeginInit();
            this.groupBoxSearchCriteria.SuspendLayout();
            this.groupBoxSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.author,
            this.publisher,
            this.genre,
            this.series,
            this.releaseDate,
            this.addedDate,
            this.price,
            this.rating,
            this.soldQuantity,
            this.available});
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(12, 210);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(1343, 594);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 33;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 81;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.Width = 118;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher";
            this.publisher.Width = 99;
            // 
            // genre
            // 
            this.genre.Text = "Genre(s)";
            this.genre.Width = 114;
            // 
            // series
            // 
            this.series.Text = "Series";
            this.series.Width = 123;
            // 
            // releaseDate
            // 
            this.releaseDate.Text = "Release date";
            this.releaseDate.Width = 110;
            // 
            // addedDate
            // 
            this.addedDate.Text = "Added date";
            this.addedDate.Width = 118;
            // 
            // price
            // 
            this.price.Text = "Price";
            // 
            // rating
            // 
            this.rating.Text = "Rating";
            this.rating.Width = 127;
            // 
            // soldQuantity
            // 
            this.soldQuantity.Text = "Sold quantity";
            this.soldQuantity.Width = 74;
            // 
            // available
            // 
            this.available.Text = "Available";
            this.available.Width = 76;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(12, 810);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.TabIndex = 210;
            this.buttonExit.Text = "GO BACK";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(9, 60);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(170, 28);
            this.buttonSort.TabIndex = 231;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // checkBoxActiveRange
            // 
            this.checkBoxActiveRange.AutoSize = true;
            this.checkBoxActiveRange.Location = new System.Drawing.Point(376, 52);
            this.checkBoxActiveRange.Name = "checkBoxActiveRange";
            this.checkBoxActiveRange.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveRange.TabIndex = 232;
            this.checkBoxActiveRange.Text = "Active";
            this.checkBoxActiveRange.UseVisualStyleBackColor = true;
            // 
            // checkBoxActiveText
            // 
            this.checkBoxActiveText.AutoSize = true;
            this.checkBoxActiveText.Location = new System.Drawing.Point(376, 27);
            this.checkBoxActiveText.Name = "checkBoxActiveText";
            this.checkBoxActiveText.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveText.TabIndex = 233;
            this.checkBoxActiveText.Text = "Active";
            this.checkBoxActiveText.UseVisualStyleBackColor = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeader.Location = new System.Drawing.Point(12, 22);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(343, 24);
            this.labelHeader.TabIndex = 234;
            this.labelHeader.Text = "Searching and sorting objects on the list";
            // 
            // textBoxTextPhrase
            // 
            this.textBoxTextPhrase.Location = new System.Drawing.Point(130, 25);
            this.textBoxTextPhrase.Name = "textBoxTextPhrase";
            this.textBoxTextPhrase.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextPhrase.TabIndex = 235;
            // 
            // numericUpDownPriceFrom
            // 
            this.numericUpDownPriceFrom.DecimalPlaces = 2;
            this.numericUpDownPriceFrom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPriceFrom.Location = new System.Drawing.Point(130, 49);
            this.numericUpDownPriceFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPriceFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriceFrom.Name = "numericUpDownPriceFrom";
            this.numericUpDownPriceFrom.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPriceFrom.TabIndex = 236;
            this.numericUpDownPriceFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPriceTo
            // 
            this.numericUpDownPriceTo.DecimalPlaces = 2;
            this.numericUpDownPriceTo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPriceTo.Location = new System.Drawing.Point(258, 49);
            this.numericUpDownPriceTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPriceTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriceTo.Name = "numericUpDownPriceTo";
            this.numericUpDownPriceTo.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPriceTo.TabIndex = 237;
            this.numericUpDownPriceTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(17, 75);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(170, 28);
            this.buttonFind.TabIndex = 238;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelPriceRange
            // 
            this.labelPriceRange.AutoSize = true;
            this.labelPriceRange.Location = new System.Drawing.Point(14, 51);
            this.labelPriceRange.Name = "labelPriceRange";
            this.labelPriceRange.Size = new System.Drawing.Size(84, 13);
            this.labelPriceRange.TabIndex = 239;
            this.labelPriceRange.Text = "Price range from";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(236, 53);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(16, 13);
            this.labelTo.TabIndex = 240;
            this.labelTo.Text = "to";
            // 
            // groupBoxSearchCriteria
            // 
            this.groupBoxSearchCriteria.Controls.Add(this.checkBoxActiveText);
            this.groupBoxSearchCriteria.Controls.Add(this.buttonFind);
            this.groupBoxSearchCriteria.Controls.Add(this.checkBoxActiveRange);
            this.groupBoxSearchCriteria.Controls.Add(this.textBoxTextPhrase);
            this.groupBoxSearchCriteria.Controls.Add(this.labelTextPhrase);
            this.groupBoxSearchCriteria.Controls.Add(this.numericUpDownPriceFrom);
            this.groupBoxSearchCriteria.Controls.Add(this.numericUpDownPriceTo);
            this.groupBoxSearchCriteria.Controls.Add(this.labelTo);
            this.groupBoxSearchCriteria.Controls.Add(this.labelPriceRange);
            this.groupBoxSearchCriteria.Location = new System.Drawing.Point(16, 68);
            this.groupBoxSearchCriteria.Name = "groupBoxSearchCriteria";
            this.groupBoxSearchCriteria.Size = new System.Drawing.Size(473, 112);
            this.groupBoxSearchCriteria.TabIndex = 241;
            this.groupBoxSearchCriteria.TabStop = false;
            this.groupBoxSearchCriteria.Text = "Product search criteria";
            // 
            // labelTextPhrase
            // 
            this.labelTextPhrase.AutoSize = true;
            this.labelTextPhrase.Location = new System.Drawing.Point(13, 28);
            this.labelTextPhrase.Name = "labelTextPhrase";
            this.labelTextPhrase.Size = new System.Drawing.Size(111, 13);
            this.labelTextPhrase.TabIndex = 242;
            this.labelTextPhrase.Text = "Text phrase in the title";
            // 
            // buttonResetSort
            // 
            this.buttonResetSort.Location = new System.Drawing.Point(182, 60);
            this.buttonResetSort.Name = "buttonResetSort";
            this.buttonResetSort.Size = new System.Drawing.Size(170, 28);
            this.buttonResetSort.TabIndex = 242;
            this.buttonResetSort.Text = "Reset sort";
            this.buttonResetSort.UseVisualStyleBackColor = true;
            this.buttonResetSort.Click += new System.EventHandler(this.buttonResetSort_Click);
            // 
            // groupBoxSorting
            // 
            this.groupBoxSorting.Controls.Add(this.labelSortDescription);
            this.groupBoxSorting.Controls.Add(this.buttonSort);
            this.groupBoxSorting.Controls.Add(this.buttonResetSort);
            this.groupBoxSorting.Location = new System.Drawing.Point(495, 68);
            this.groupBoxSorting.Name = "groupBoxSorting";
            this.groupBoxSorting.Size = new System.Drawing.Size(369, 112);
            this.groupBoxSorting.TabIndex = 243;
            this.groupBoxSorting.TabStop = false;
            this.groupBoxSorting.Text = "Sorting products";
            // 
            // labelSortDescription
            // 
            this.labelSortDescription.AutoSize = true;
            this.labelSortDescription.Location = new System.Drawing.Point(6, 32);
            this.labelSortDescription.Name = "labelSortDescription";
            this.labelSortDescription.Size = new System.Drawing.Size(314, 13);
            this.labelSortDescription.TabIndex = 243;
            this.labelSortDescription.Text = "Sorting products by author, if the same, then by price, next by title";
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 852);
            this.Controls.Add(this.groupBoxSorting);
            this.Controls.Add(this.groupBoxSearchCriteria);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listViewProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display products";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceTo)).EndInit();
            this.groupBoxSearchCriteria.ResumeLayout(false);
            this.groupBoxSearchCriteria.PerformLayout();
            this.groupBoxSorting.ResumeLayout(false);
            this.groupBoxSorting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.ColumnHeader series;
        private System.Windows.Forms.ColumnHeader releaseDate;
        private System.Windows.Forms.ColumnHeader addedDate;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader rating;
        private System.Windows.Forms.ColumnHeader soldQuantity;
        private System.Windows.Forms.ColumnHeader available;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.CheckBox checkBoxActiveRange;
        private System.Windows.Forms.CheckBox checkBoxActiveText;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxTextPhrase;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceTo;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelPriceRange;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.GroupBox groupBoxSearchCriteria;
        private System.Windows.Forms.Label labelTextPhrase;
        private System.Windows.Forms.Button buttonResetSort;
        private System.Windows.Forms.GroupBox groupBoxSorting;
        private System.Windows.Forms.Label labelSortDescription;
    }
}