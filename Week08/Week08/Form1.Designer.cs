namespace Week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Ball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ColorPicker = new System.Windows.Forms.Button();
            this.btn_Present = new System.Windows.Forms.Button();
            this.btn_RibbonColor = new System.Windows.Forms.Button();
            this.btn_BoxColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 169);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 169);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_Car
            // 
            this.btn_Car.Location = new System.Drawing.Point(92, 23);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(75, 23);
            this.btn_Car.TabIndex = 1;
            this.btn_Car.Text = "Car";
            this.btn_Car.UseVisualStyleBackColor = true;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click);
            // 
            // btn_Ball
            // 
            this.btn_Ball.Location = new System.Drawing.Point(228, 23);
            this.btn_Ball.Name = "btn_Ball";
            this.btn_Ball.Size = new System.Drawing.Size(75, 23);
            this.btn_Ball.TabIndex = 2;
            this.btn_Ball.Text = "Ball";
            this.btn_Ball.UseVisualStyleBackColor = true;
            this.btn_Ball.Click += new System.EventHandler(this.btn_Ball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next";
            // 
            // btn_ColorPicker
            // 
            this.btn_ColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ColorPicker.Location = new System.Drawing.Point(228, 66);
            this.btn_ColorPicker.Name = "btn_ColorPicker";
            this.btn_ColorPicker.Size = new System.Drawing.Size(75, 23);
            this.btn_ColorPicker.TabIndex = 4;
            this.btn_ColorPicker.UseVisualStyleBackColor = false;
            this.btn_ColorPicker.Click += new System.EventHandler(this.btn_ColorPicker_Click);
            // 
            // btn_Present
            // 
            this.btn_Present.Location = new System.Drawing.Point(338, 23);
            this.btn_Present.Name = "btn_Present";
            this.btn_Present.Size = new System.Drawing.Size(75, 23);
            this.btn_Present.TabIndex = 5;
            this.btn_Present.Text = "Present";
            this.btn_Present.UseVisualStyleBackColor = true;
            this.btn_Present.Click += new System.EventHandler(this.btn_Present_Click);
            // 
            // btn_RibbonColor
            // 
            this.btn_RibbonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_RibbonColor.Location = new System.Drawing.Point(338, 95);
            this.btn_RibbonColor.Name = "btn_RibbonColor";
            this.btn_RibbonColor.Size = new System.Drawing.Size(75, 23);
            this.btn_RibbonColor.TabIndex = 6;
            this.btn_RibbonColor.UseVisualStyleBackColor = false;
            this.btn_RibbonColor.Click += new System.EventHandler(this.btn_ColorPicker_Click);
            // 
            // btn_BoxColor
            // 
            this.btn_BoxColor.BackColor = System.Drawing.Color.Red;
            this.btn_BoxColor.Location = new System.Drawing.Point(338, 66);
            this.btn_BoxColor.Name = "btn_BoxColor";
            this.btn_BoxColor.Size = new System.Drawing.Size(75, 23);
            this.btn_BoxColor.TabIndex = 7;
            this.btn_BoxColor.UseVisualStyleBackColor = false;
            this.btn_BoxColor.Click += new System.EventHandler(this.btn_ColorPicker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_BoxColor);
            this.Controls.Add(this.btn_RibbonColor);
            this.Controls.Add(this.btn_Present);
            this.Controls.Add(this.btn_ColorPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ball);
            this.Controls.Add(this.btn_Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_Car;
        private System.Windows.Forms.Button btn_Ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ColorPicker;
        private System.Windows.Forms.Button btn_Present;
        private System.Windows.Forms.Button btn_RibbonColor;
        private System.Windows.Forms.Button btn_BoxColor;
    }
}

