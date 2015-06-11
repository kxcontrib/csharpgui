namespace whitepaperTestingProject
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.colCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colsSelected = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.arguments = new System.Windows.Forms.Label();
            this.argInput1 = new System.Windows.Forms.TextBox();
            this.signComboBox1 = new System.Windows.Forms.ComboBox();
            this.argComboBox1 = new System.Windows.Forms.ComboBox();
            this.argInput2 = new System.Windows.Forms.TextBox();
            this.signComboBox2 = new System.Windows.Forms.ComboBox();
            this.argComboBox2 = new System.Windows.Forms.ComboBox();
            this.argInput3 = new System.Windows.Forms.TextBox();
            this.signComboBox3 = new System.Windows.Forms.ComboBox();
            this.argComboBox3 = new System.Windows.Forms.ComboBox();
            this.andor1 = new System.Windows.Forms.ComboBox();
            this.andor2 = new System.Windows.Forms.ComboBox();
            this.removeCols = new System.Windows.Forms.Button();
            this.selectedCols = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query output:";
            // 
            // QueryView
            // 
            this.QueryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryView.DefaultCellStyle = dataGridViewCellStyle2;
            this.QueryView.Location = new System.Drawing.Point(15, 222);
            this.QueryView.Name = "QueryView";
            this.QueryView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.QueryView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QueryView.Size = new System.Drawing.Size(412, 171);
            this.QueryView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Build query:";
            // 
            // colCombo
            // 
            this.colCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "*",
            "symbol",
            "price",
            "size"});
            this.colCombo.FormattingEnabled = true;
            this.colCombo.Items.AddRange(new object[] {
            "*",
            "sym",
            "price",
            "size"});
            this.colCombo.Location = new System.Drawing.Point(101, 35);
            this.colCombo.Name = "colCombo";
            this.colCombo.Size = new System.Drawing.Size(121, 21);
            this.colCombo.TabIndex = 4;
            this.colCombo.SelectedIndexChanged += new System.EventHandler(this.colCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Columns:";
            // 
            // colsSelected
            // 
            this.colsSelected.AutoSize = true;
            this.colsSelected.Location = new System.Drawing.Point(229, 38);
            this.colsSelected.Name = "colsSelected";
            this.colsSelected.Size = new System.Drawing.Size(93, 13);
            this.colsSelected.TabIndex = 6;
            this.colsSelected.Text = "Columns selected:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Table:";
            // 
            // tableComboBox
            // 
            this.tableComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "trade"});
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(101, 67);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(121, 21);
            this.tableComboBox.TabIndex = 8;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // arguments
            // 
            this.arguments.AutoSize = true;
            this.arguments.Location = new System.Drawing.Point(13, 100);
            this.arguments.Name = "arguments";
            this.arguments.Size = new System.Drawing.Size(60, 13);
            this.arguments.TabIndex = 9;
            this.arguments.Text = "Arguments:";
            // 
            // argInput1
            // 
            this.argInput1.Location = new System.Drawing.Point(281, 97);
            this.argInput1.Name = "argInput1";
            this.argInput1.Size = new System.Drawing.Size(100, 20);
            this.argInput1.TabIndex = 12;
            // 
            // signComboBox1
            // 
            this.signComboBox1.FormattingEnabled = true;
            this.signComboBox1.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.signComboBox1.Location = new System.Drawing.Point(228, 97);
            this.signComboBox1.Name = "signComboBox1";
            this.signComboBox1.Size = new System.Drawing.Size(46, 21);
            this.signComboBox1.TabIndex = 11;
            // 
            // argComboBox1
            // 
            this.argComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "*",
            "symbol",
            "price",
            "size"});
            this.argComboBox1.FormattingEnabled = true;
            this.argComboBox1.Location = new System.Drawing.Point(101, 97);
            this.argComboBox1.Name = "argComboBox1";
            this.argComboBox1.Size = new System.Drawing.Size(121, 21);
            this.argComboBox1.TabIndex = 10;
            // 
            // argInput2
            // 
            this.argInput2.Location = new System.Drawing.Point(281, 132);
            this.argInput2.Name = "argInput2";
            this.argInput2.Size = new System.Drawing.Size(100, 20);
            this.argInput2.TabIndex = 15;
            // 
            // signComboBox2
            // 
            this.signComboBox2.FormattingEnabled = true;
            this.signComboBox2.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.signComboBox2.Location = new System.Drawing.Point(228, 132);
            this.signComboBox2.Name = "signComboBox2";
            this.signComboBox2.Size = new System.Drawing.Size(46, 21);
            this.signComboBox2.TabIndex = 14;
            // 
            // argComboBox2
            // 
            this.argComboBox2.FormattingEnabled = true;
            this.argComboBox2.Location = new System.Drawing.Point(101, 132);
            this.argComboBox2.Name = "argComboBox2";
            this.argComboBox2.Size = new System.Drawing.Size(121, 21);
            this.argComboBox2.TabIndex = 13;
            // 
            // argInput3
            // 
            this.argInput3.Location = new System.Drawing.Point(281, 168);
            this.argInput3.Name = "argInput3";
            this.argInput3.Size = new System.Drawing.Size(100, 20);
            this.argInput3.TabIndex = 18;
            // 
            // signComboBox3
            // 
            this.signComboBox3.FormattingEnabled = true;
            this.signComboBox3.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.signComboBox3.Location = new System.Drawing.Point(228, 168);
            this.signComboBox3.Name = "signComboBox3";
            this.signComboBox3.Size = new System.Drawing.Size(46, 21);
            this.signComboBox3.TabIndex = 17;
            // 
            // argComboBox3
            // 
            this.argComboBox3.FormattingEnabled = true;
            this.argComboBox3.Location = new System.Drawing.Point(101, 168);
            this.argComboBox3.Name = "argComboBox3";
            this.argComboBox3.Size = new System.Drawing.Size(121, 21);
            this.argComboBox3.TabIndex = 16;
            // 
            // andor1
            // 
            this.andor1.FormattingEnabled = true;
            this.andor1.Items.AddRange(new object[] {
            "none",
            "and",
            "or"});
            this.andor1.Location = new System.Drawing.Point(36, 132);
            this.andor1.Name = "andor1";
            this.andor1.Size = new System.Drawing.Size(46, 21);
            this.andor1.TabIndex = 19;
            // 
            // andor2
            // 
            this.andor2.FormattingEnabled = true;
            this.andor2.Items.AddRange(new object[] {
            "none",
            "and",
            "or"});
            this.andor2.Location = new System.Drawing.Point(37, 167);
            this.andor2.Name = "andor2";
            this.andor2.Size = new System.Drawing.Size(46, 21);
            this.andor2.TabIndex = 20;
            // 
            // removeCols
            // 
            this.removeCols.Location = new System.Drawing.Point(229, 66);
            this.removeCols.Name = "removeCols";
            this.removeCols.Size = new System.Drawing.Size(93, 23);
            this.removeCols.TabIndex = 21;
            this.removeCols.Text = "Remove Cols";
            this.removeCols.UseVisualStyleBackColor = true;
            this.removeCols.Click += new System.EventHandler(this.removeCols_Click);
            // 
            // selectedCols
            // 
            this.selectedCols.AutoSize = true;
            this.selectedCols.Location = new System.Drawing.Point(321, 38);
            this.selectedCols.Name = "selectedCols";
            this.selectedCols.Size = new System.Drawing.Size(0, 13);
            this.selectedCols.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(388, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "not";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(387, 136);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(41, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "not";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(387, 172);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(41, 17);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.Text = "not";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(185, 399);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 26;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 434);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.selectedCols);
            this.Controls.Add(this.removeCols);
            this.Controls.Add(this.andor2);
            this.Controls.Add(this.andor1);
            this.Controls.Add(this.argInput3);
            this.Controls.Add(this.signComboBox3);
            this.Controls.Add(this.argComboBox3);
            this.Controls.Add(this.argInput2);
            this.Controls.Add(this.signComboBox2);
            this.Controls.Add(this.argComboBox2);
            this.Controls.Add(this.argInput1);
            this.Controls.Add(this.signComboBox1);
            this.Controls.Add(this.argComboBox1);
            this.Controls.Add(this.arguments);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colsSelected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QueryView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Run query";
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView QueryView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox colCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label colsSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Label arguments;
        private System.Windows.Forms.TextBox argInput1;
        private System.Windows.Forms.ComboBox signComboBox1;
        private System.Windows.Forms.ComboBox argComboBox1;
        private System.Windows.Forms.TextBox argInput2;
        private System.Windows.Forms.ComboBox signComboBox2;
        private System.Windows.Forms.ComboBox argComboBox2;
        private System.Windows.Forms.TextBox argInput3;
        private System.Windows.Forms.ComboBox signComboBox3;
        private System.Windows.Forms.ComboBox argComboBox3;
        private System.Windows.Forms.ComboBox andor1;
        private System.Windows.Forms.ComboBox andor2;
        private System.Windows.Forms.Button removeCols;
        private System.Windows.Forms.Label selectedCols;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label errorLabel;
    }
}

