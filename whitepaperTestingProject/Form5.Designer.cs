namespace whitepaperTestingProject
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.QueryView = new System.Windows.Forms.DataGridView();
            this.runComButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query;";
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(15, 25);
            this.queryBox.Multiline = true;
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(301, 68);
            this.queryBox.TabIndex = 1;
            // 
            // QueryView
            // 
            this.QueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryView.Location = new System.Drawing.Point(15, 129);
            this.QueryView.Name = "QueryView";
            this.QueryView.Size = new System.Drawing.Size(301, 210);
            this.QueryView.TabIndex = 2;
            // 
            // runComButton
            // 
            this.runComButton.Location = new System.Drawing.Point(15, 100);
            this.runComButton.Name = "runComButton";
            this.runComButton.Size = new System.Drawing.Size(75, 23);
            this.runComButton.TabIndex = 3;
            this.runComButton.Text = "Run command";
            this.runComButton.UseVisualStyleBackColor = true;
            this.runComButton.Click += new System.EventHandler(this.runComButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(96, 100);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 355);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.runComButton);
            this.Controls.Add(this.QueryView);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Update/Select";
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.DataGridView QueryView;
        private System.Windows.Forms.Button runComButton;
        private System.Windows.Forms.Label errorLabel;
    }
}