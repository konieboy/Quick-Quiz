namespace Quick_Quiz
{
    partial class ResultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsScreen));
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelCorrectly = new System.Windows.Forms.Label();
            this.labelIncorrectly = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalA = new System.Windows.Forms.Label();
            this.labelCorrectA = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(100, 227);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCorrectly
            // 
            this.labelCorrectly.AutoSize = true;
            this.labelCorrectly.Location = new System.Drawing.Point(23, 80);
            this.labelCorrectly.Name = "labelCorrectly";
            this.labelCorrectly.Size = new System.Drawing.Size(151, 13);
            this.labelCorrectly.TabIndex = 1;
            this.labelCorrectly.Text = "Questions Answered Correctly:";
            // 
            // labelIncorrectly
            // 
            this.labelIncorrectly.AutoSize = true;
            this.labelIncorrectly.Location = new System.Drawing.Point(15, 120);
            this.labelIncorrectly.Name = "labelIncorrectly";
            this.labelIncorrectly.Size = new System.Drawing.Size(159, 13);
            this.labelIncorrectly.TabIndex = 2;
            this.labelIncorrectly.Text = "Questions Answered Incorrectly:";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(133, 160);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(41, 13);
            this.labelSummary.TabIndex = 3;
            this.labelSummary.Text = "Score: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(40, 40);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(134, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total Questions Answered:";
            // 
            // labelTotalA
            // 
            this.labelTotalA.AutoSize = true;
            this.labelTotalA.ForeColor = System.Drawing.Color.Black;
            this.labelTotalA.Location = new System.Drawing.Point(180, 40);
            this.labelTotalA.Name = "labelTotalA";
            this.labelTotalA.Size = new System.Drawing.Size(31, 13);
            this.labelTotalA.TabIndex = 5;
            this.labelTotalA.Text = "Total";
            // 
            // labelCorrectA
            // 
            this.labelCorrectA.AutoSize = true;
            this.labelCorrectA.ForeColor = System.Drawing.Color.Green;
            this.labelCorrectA.Location = new System.Drawing.Point(180, 80);
            this.labelCorrectA.Name = "labelCorrectA";
            this.labelCorrectA.Size = new System.Drawing.Size(41, 13);
            this.labelCorrectA.TabIndex = 6;
            this.labelCorrectA.Text = "Correct";
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.ForeColor = System.Drawing.Color.Crimson;
            this.labelIncorrect.Location = new System.Drawing.Point(180, 120);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(49, 13);
            this.labelIncorrect.TabIndex = 7;
            this.labelIncorrect.Text = "Incorrect";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(180, 160);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelCorrectA);
            this.Controls.Add(this.labelTotalA);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelIncorrectly);
            this.Controls.Add(this.labelCorrectly);
            this.Controls.Add(this.buttonFinish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelCorrectly;
        private System.Windows.Forms.Label labelIncorrectly;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalA;
        private System.Windows.Forms.Label labelCorrectA;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label labelScore;
    }
}