namespace Quick_Quiz
{
    partial class QuizForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.checkQuestion1 = new System.Windows.Forms.CheckBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.checkQuestion2 = new System.Windows.Forms.CheckBox();
            this.checkQuestion4 = new System.Windows.Forms.CheckBox();
            this.checkQuestion3 = new System.Windows.Forms.CheckBox();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(12, 235);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(76, 24);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Previous";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(297, 235);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 24);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // checkQuestion1
            // 
            this.checkQuestion1.AutoSize = true;
            this.checkQuestion1.Location = new System.Drawing.Point(318, 82);
            this.checkQuestion1.Name = "checkQuestion1";
            this.checkQuestion1.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion1.TabIndex = 2;
            this.checkQuestion1.UseVisualStyleBackColor = true;
            this.checkQuestion1.Click += new System.EventHandler(this.checkQuestion1_Click);
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Location = new System.Drawing.Point(12, 83);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(48, 13);
            this.labelAnswer1.TabIndex = 6;
            this.labelAnswer1.Text = "Answer1";
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Location = new System.Drawing.Point(12, 163);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer3.TabIndex = 7;
            this.labelAnswer3.Text = "Answer 3";
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Location = new System.Drawing.Point(12, 123);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer2.TabIndex = 8;
            this.labelAnswer2.Text = "Answer 2";
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Location = new System.Drawing.Point(10, 10);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(78, 13);
            this.labelQuestionNumber.TabIndex = 9;
            this.labelQuestionNumber.Text = "Quesion X of Y";
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Location = new System.Drawing.Point(12, 203);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer4.TabIndex = 10;
            this.labelAnswer4.Text = "Answer 4";
            // 
            // checkQuestion2
            // 
            this.checkQuestion2.AutoSize = true;
            this.checkQuestion2.Location = new System.Drawing.Point(318, 122);
            this.checkQuestion2.Name = "checkQuestion2";
            this.checkQuestion2.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion2.TabIndex = 11;
            this.checkQuestion2.UseVisualStyleBackColor = true;
            this.checkQuestion2.Click += new System.EventHandler(this.checkQuestion2_Click);
            // 
            // checkQuestion4
            // 
            this.checkQuestion4.AutoSize = true;
            this.checkQuestion4.Location = new System.Drawing.Point(318, 202);
            this.checkQuestion4.Name = "checkQuestion4";
            this.checkQuestion4.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion4.TabIndex = 12;
            this.checkQuestion4.UseVisualStyleBackColor = true;
            this.checkQuestion4.Click += new System.EventHandler(this.checkQuestion4_Click);
            // 
            // checkQuestion3
            // 
            this.checkQuestion3.AutoSize = true;
            this.checkQuestion3.Location = new System.Drawing.Point(318, 162);
            this.checkQuestion3.Name = "checkQuestion3";
            this.checkQuestion3.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion3.TabIndex = 13;
            this.checkQuestion3.UseVisualStyleBackColor = true;
            this.checkQuestion3.Click += new System.EventHandler(this.checkQuestion3_Click);
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(12, 37);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(49, 13);
            this.labelQuestionText.TabIndex = 14;
            this.labelQuestionText.Text = "Question";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.checkQuestion3);
            this.Controls.Add(this.checkQuestion4);
            this.Controls.Add(this.checkQuestion2);
            this.Controls.Add(this.labelAnswer4);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer3);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.checkQuestion1);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.buttonBack);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.CheckBox checkQuestion1;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelAnswer4;
        private System.Windows.Forms.CheckBox checkQuestion2;
        private System.Windows.Forms.CheckBox checkQuestion4;
        private System.Windows.Forms.CheckBox checkQuestion3;
        private System.Windows.Forms.Label labelQuestionText;
    }
}