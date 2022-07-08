namespace JakubHaraf_InternetBookstore
{
    partial class FormOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperator));
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.labelDemonstration = new System.Windows.Forms.Label();
            this.groupBoxUseOfOperators = new System.Windows.Forms.GroupBox();
            this.numericUpDownBookA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBookB = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonPerform = new System.Windows.Forms.Button();
            this.labelEnterBookA = new System.Windows.Forms.Label();
            this.labelSelectOperator = new System.Windows.Forms.Label();
            this.labelEnterBookB = new System.Windows.Forms.Label();
            this.groupBoxDescOfOpera = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOperator1Description = new System.Windows.Forms.Label();
            this.labelOperator4Descript = new System.Windows.Forms.Label();
            this.labelOperator2Descript = new System.Windows.Forms.Label();
            this.labelOperator3Descript = new System.Windows.Forms.Label();
            this.groupBoxUseOfOperators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookB)).BeginInit();
            this.groupBoxDescOfOpera.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(12, 521);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 30);
            this.buttonExit.TabIndex = 209;
            this.buttonExit.Text = "GO BACK";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 210);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(776, 303);
            this.listBoxDisplay.TabIndex = 214;
            // 
            // labelDemonstration
            // 
            this.labelDemonstration.AutoSize = true;
            this.labelDemonstration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDemonstration.Location = new System.Drawing.Point(8, 22);
            this.labelDemonstration.Name = "labelDemonstration";
            this.labelDemonstration.Size = new System.Drawing.Size(330, 24);
            this.labelDemonstration.TabIndex = 218;
            this.labelDemonstration.Text = "Demonstration of operator overloading";
            // 
            // groupBoxUseOfOperators
            // 
            this.groupBoxUseOfOperators.Controls.Add(this.numericUpDownBookA);
            this.groupBoxUseOfOperators.Controls.Add(this.numericUpDownBookB);
            this.groupBoxUseOfOperators.Controls.Add(this.comboBoxOperator);
            this.groupBoxUseOfOperators.Controls.Add(this.buttonPerform);
            this.groupBoxUseOfOperators.Controls.Add(this.labelEnterBookA);
            this.groupBoxUseOfOperators.Controls.Add(this.labelSelectOperator);
            this.groupBoxUseOfOperators.Controls.Add(this.labelEnterBookB);
            this.groupBoxUseOfOperators.Location = new System.Drawing.Point(12, 69);
            this.groupBoxUseOfOperators.Name = "groupBoxUseOfOperators";
            this.groupBoxUseOfOperators.Size = new System.Drawing.Size(288, 135);
            this.groupBoxUseOfOperators.TabIndex = 229;
            this.groupBoxUseOfOperators.TabStop = false;
            this.groupBoxUseOfOperators.Text = "Use of operators";
            // 
            // numericUpDownBookA
            // 
            this.numericUpDownBookA.Location = new System.Drawing.Point(145, 19);
            this.numericUpDownBookA.Name = "numericUpDownBookA";
            this.numericUpDownBookA.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownBookA.TabIndex = 219;
            // 
            // numericUpDownBookB
            // 
            this.numericUpDownBookB.Location = new System.Drawing.Point(145, 45);
            this.numericUpDownBookB.Name = "numericUpDownBookB";
            this.numericUpDownBookB.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownBookB.TabIndex = 220;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "==",
            "!=",
            "+",
            "+="});
            this.comboBoxOperator.Location = new System.Drawing.Point(145, 70);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOperator.TabIndex = 212;
            // 
            // buttonPerform
            // 
            this.buttonPerform.Location = new System.Drawing.Point(14, 99);
            this.buttonPerform.Name = "buttonPerform";
            this.buttonPerform.Size = new System.Drawing.Size(75, 23);
            this.buttonPerform.TabIndex = 213;
            this.buttonPerform.Text = "Perform";
            this.buttonPerform.UseVisualStyleBackColor = true;
            // 
            // labelEnterBookA
            // 
            this.labelEnterBookA.AutoSize = true;
            this.labelEnterBookA.Location = new System.Drawing.Point(11, 21);
            this.labelEnterBookA.Name = "labelEnterBookA";
            this.labelEnterBookA.Size = new System.Drawing.Size(128, 13);
            this.labelEnterBookA.TabIndex = 215;
            this.labelEnterBookA.Text = "Enter book A (product id):";
            // 
            // labelSelectOperator
            // 
            this.labelSelectOperator.AutoSize = true;
            this.labelSelectOperator.Location = new System.Drawing.Point(11, 73);
            this.labelSelectOperator.Name = "labelSelectOperator";
            this.labelSelectOperator.Size = new System.Drawing.Size(97, 13);
            this.labelSelectOperator.TabIndex = 217;
            this.labelSelectOperator.Text = "Select an operator:";
            // 
            // labelEnterBookB
            // 
            this.labelEnterBookB.AutoSize = true;
            this.labelEnterBookB.Location = new System.Drawing.Point(11, 47);
            this.labelEnterBookB.Name = "labelEnterBookB";
            this.labelEnterBookB.Size = new System.Drawing.Size(128, 13);
            this.labelEnterBookB.TabIndex = 216;
            this.labelEnterBookB.Text = "Enter book B (product id):";
            // 
            // groupBoxDescOfOpera
            // 
            this.groupBoxDescOfOpera.Controls.Add(this.label2);
            this.groupBoxDescOfOpera.Controls.Add(this.label1);
            this.groupBoxDescOfOpera.Controls.Add(this.labelOperator1Description);
            this.groupBoxDescOfOpera.Controls.Add(this.labelOperator4Descript);
            this.groupBoxDescOfOpera.Controls.Add(this.labelOperator2Descript);
            this.groupBoxDescOfOpera.Controls.Add(this.labelOperator3Descript);
            this.groupBoxDescOfOpera.Location = new System.Drawing.Point(306, 69);
            this.groupBoxDescOfOpera.Name = "groupBoxDescOfOpera";
            this.groupBoxDescOfOpera.Size = new System.Drawing.Size(479, 135);
            this.groupBoxDescOfOpera.TabIndex = 228;
            this.groupBoxDescOfOpera.TabStop = false;
            this.groupBoxDescOfOpera.Text = "Description of operators";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 13);
            this.label2.TabIndex = 228;
            this.label2.Text = " if the authors are different, the author of book A will be assigned to the new s" +
    "et of books, etc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 13);
            this.label1.TabIndex = 227;
            this.label1.Text = "* The \"+\" and \"+ =\" operators are designed with books of the same author and seri" +
    "es in mind,";
            // 
            // labelOperator1Description
            // 
            this.labelOperator1Description.AutoSize = true;
            this.labelOperator1Description.Location = new System.Drawing.Point(8, 19);
            this.labelOperator1Description.Name = "labelOperator1Description";
            this.labelOperator1Description.Size = new System.Drawing.Size(315, 13);
            this.labelOperator1Description.TabIndex = 221;
            this.labelOperator1Description.Text = "The \" == \" operator checks if the books are from the same author";
            // 
            // labelOperator4Descript
            // 
            this.labelOperator4Descript.AutoSize = true;
            this.labelOperator4Descript.Location = new System.Drawing.Point(8, 77);
            this.labelOperator4Descript.Name = "labelOperator4Descript";
            this.labelOperator4Descript.Size = new System.Drawing.Size(345, 13);
            this.labelOperator4Descript.TabIndex = 224;
            this.labelOperator4Descript.Text = "The \" += \" operator, in place of book A, saves the set of books A and B";
            // 
            // labelOperator2Descript
            // 
            this.labelOperator2Descript.AutoSize = true;
            this.labelOperator2Descript.Location = new System.Drawing.Point(8, 38);
            this.labelOperator2Descript.Name = "labelOperator2Descript";
            this.labelOperator2Descript.Size = new System.Drawing.Size(343, 13);
            this.labelOperator2Descript.TabIndex = 222;
            this.labelOperator2Descript.Text = "The \" != \" operator checks that the books are not from the same author";
            // 
            // labelOperator3Descript
            // 
            this.labelOperator3Descript.AutoSize = true;
            this.labelOperator3Descript.Location = new System.Drawing.Point(8, 56);
            this.labelOperator3Descript.Name = "labelOperator3Descript";
            this.labelOperator3Descript.Size = new System.Drawing.Size(449, 13);
            this.labelOperator3Descript.TabIndex = 223;
            this.labelOperator3Descript.Text = "The \" + \" operator creates a new product from two books (A, B), which is a set of" +
    " these books";
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.groupBoxUseOfOperators);
            this.Controls.Add(this.groupBoxDescOfOpera);
            this.Controls.Add(this.labelDemonstration);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator overloading";
            this.groupBoxUseOfOperators.ResumeLayout(false);
            this.groupBoxUseOfOperators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookB)).EndInit();
            this.groupBoxDescOfOpera.ResumeLayout(false);
            this.groupBoxDescOfOpera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label labelDemonstration;
        private System.Windows.Forms.GroupBox groupBoxUseOfOperators;
        private System.Windows.Forms.NumericUpDown numericUpDownBookA;
        private System.Windows.Forms.NumericUpDown numericUpDownBookB;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonPerform;
        private System.Windows.Forms.Label labelEnterBookA;
        private System.Windows.Forms.Label labelSelectOperator;
        private System.Windows.Forms.Label labelEnterBookB;
        private System.Windows.Forms.GroupBox groupBoxDescOfOpera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOperator1Description;
        private System.Windows.Forms.Label labelOperator4Descript;
        private System.Windows.Forms.Label labelOperator2Descript;
        private System.Windows.Forms.Label labelOperator3Descript;
    }
}