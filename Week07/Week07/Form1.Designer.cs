namespace Week07
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelZaro = new System.Windows.Forms.Label();
            this.numericUpDownZaroEv = new System.Windows.Forms.NumericUpDown();
            this.labelFajl = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroEv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(713, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelZaro
            // 
            this.labelZaro.AutoSize = true;
            this.labelZaro.Location = new System.Drawing.Point(35, 42);
            this.labelZaro.Name = "labelZaro";
            this.labelZaro.Size = new System.Drawing.Size(41, 13);
            this.labelZaro.TabIndex = 1;
            this.labelZaro.Text = "Záróév";
            // 
            // numericUpDownZaroEv
            // 
            this.numericUpDownZaroEv.Location = new System.Drawing.Point(82, 40);
            this.numericUpDownZaroEv.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownZaroEv.Minimum = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            this.numericUpDownZaroEv.Name = "numericUpDownZaroEv";
            this.numericUpDownZaroEv.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownZaroEv.TabIndex = 2;
            this.numericUpDownZaroEv.Value = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            // 
            // labelFajl
            // 
            this.labelFajl.AutoSize = true;
            this.labelFajl.Location = new System.Drawing.Point(262, 42);
            this.labelFajl.Name = "labelFajl";
            this.labelFajl.Size = new System.Drawing.Size(71, 13);
            this.labelFajl.TabIndex = 3;
            this.labelFajl.Text = "Népesség fájl";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(339, 42);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(258, 20);
            this.textBoxFile.TabIndex = 4;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(620, 42);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 335);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFajl);
            this.Controls.Add(this.numericUpDownZaroEv);
            this.Controls.Add(this.labelZaro);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroEv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelZaro;
        private System.Windows.Forms.NumericUpDown numericUpDownZaroEv;
        private System.Windows.Forms.Label labelFajl;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

