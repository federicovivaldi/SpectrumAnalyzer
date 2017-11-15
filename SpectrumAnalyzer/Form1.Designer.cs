namespace SpectrumAnalyzer
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.spectrumPlot = new ScottPlot.ScottPlotUC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(349, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(243, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Spectrum Analyzer";
            // 
            // FooterLabel
            // 
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.Location = new System.Drawing.Point(352, 436);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(224, 13);
            this.FooterLabel.TabIndex = 1;
            this.FooterLabel.Text = "Topics in Computer Science 2017-2018 - Federico Vivaldi";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(666, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(756, 12);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // spectrumPlot
            // 
            this.spectrumPlot.Location = new System.Drawing.Point(11, 47);
            this.spectrumPlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spectrumPlot.Name = "spectrumPlot";
            this.spectrumPlot.Size = new System.Drawing.Size(850, 402);
            this.spectrumPlot.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 458);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.spectrumPlot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private ScottPlot.ScottPlotUC spectrumPlot;
        private System.Windows.Forms.Timer timer1;
    }
}

