namespace JakubHaraf_InternetBookstore
{
    partial class FormImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.labelImportRaport = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSuccessAdded = new System.Windows.Forms.Label();
            this.labelNumOfAddedProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 57);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(550, 498);
            this.listBoxDisplay.TabIndex = 0;
            // 
            // labelImportRaport
            // 
            this.labelImportRaport.AutoSize = true;
            this.labelImportRaport.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImportRaport.Location = new System.Drawing.Point(184, 9);
            this.labelImportRaport.Name = "labelImportRaport";
            this.labelImportRaport.Size = new System.Drawing.Size(187, 28);
            this.labelImportRaport.TabIndex = 216;
            this.labelImportRaport.Text = "IMPORT RAPORT";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(12, 561);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.TabIndex = 223;
            this.buttonExit.Text = "GO BACK";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSuccessAdded
            // 
            this.labelSuccessAdded.AutoSize = true;
            this.labelSuccessAdded.Location = new System.Drawing.Point(197, 37);
            this.labelSuccessAdded.Name = "labelSuccessAdded";
            this.labelSuccessAdded.Size = new System.Drawing.Size(102, 13);
            this.labelSuccessAdded.TabIndex = 224;
            this.labelSuccessAdded.Text = "Successfully added ";
            // 
            // labelNumOfAddedProducts
            // 
            this.labelNumOfAddedProducts.AutoSize = true;
            this.labelNumOfAddedProducts.Location = new System.Drawing.Point(293, 37);
            this.labelNumOfAddedProducts.MinimumSize = new System.Drawing.Size(30, 13);
            this.labelNumOfAddedProducts.Name = "labelNumOfAddedProducts";
            this.labelNumOfAddedProducts.Size = new System.Drawing.Size(57, 13);
            this.labelNumOfAddedProducts.TabIndex = 226;
            this.labelNumOfAddedProducts.Text = "0 products";
            this.labelNumOfAddedProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 603);
            this.Controls.Add(this.labelNumOfAddedProducts);
            this.Controls.Add(this.labelSuccessAdded);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelImportRaport);
            this.Controls.Add(this.listBoxDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label labelImportRaport;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSuccessAdded;
        private System.Windows.Forms.Label labelNumOfAddedProducts;
    }
}