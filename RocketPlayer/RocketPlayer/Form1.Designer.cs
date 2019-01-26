namespace RocketPlayer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerW = new System.Windows.Forms.Timer(this.components);
            this.timerAD = new System.Windows.Forms.Timer(this.components);
            this.timerLMB = new System.Windows.Forms.Timer(this.components);
            this.timerRBM = new System.Windows.Forms.Timer(this.components);
            this.timerEnter = new System.Windows.Forms.Timer(this.components);
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Drive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerW
            // 
            this.timerW.Tick += new System.EventHandler(this.timerW_Tick);
            // 
            // timerAD
            // 
            this.timerAD.Interval = 5000;
            this.timerAD.Tick += new System.EventHandler(this.timerAD_Tick);
            // 
            // timerLMB
            // 
            this.timerLMB.Interval = 9000;
            this.timerLMB.Tick += new System.EventHandler(this.timerLMB_Tick);
            // 
            // timerRBM
            // 
            this.timerRBM.Interval = 7000;
            this.timerRBM.Tick += new System.EventHandler(this.timerRBM_Tick);
            // 
            // timerEnter
            // 
            this.timerEnter.Interval = 1000;
            this.timerEnter.Tick += new System.EventHandler(this.timerEnter_Tick);
            // 
            // timerR
            // 
            this.timerR.Interval = 1000;
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerW;
        private System.Windows.Forms.Timer timerAD;
        private System.Windows.Forms.Timer timerLMB;
        private System.Windows.Forms.Timer timerRBM;
        private System.Windows.Forms.Timer timerEnter;
        private System.Windows.Forms.Timer timerR;
    }
}

