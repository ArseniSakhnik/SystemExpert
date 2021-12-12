namespace SystemExpert
{
    partial class RockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question = new System.Windows.Forms.Label();
            this.retry_button = new System.Windows.Forms.Button();
            this.question1_groupBox = new System.Windows.Forms.GroupBox();
            this.question1_NO = new System.Windows.Forms.Button();
            this.question1_YES = new System.Windows.Forms.Button();
            this.question1 = new System.Windows.Forms.Label();
            this.question2_groupBox = new System.Windows.Forms.GroupBox();
            this.question2_NO = new System.Windows.Forms.Button();
            this.question2_YES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.question1_groupBox.SuspendLayout();
            this.question2_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(267, 12);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(370, 54);
            this.Question.TabIndex = 0;
            this.Question.Text = "Проверка на хохла";
            // 
            // retry_button
            // 
            this.retry_button.Location = new System.Drawing.Point(698, 33);
            this.retry_button.Name = "retry_button";
            this.retry_button.Size = new System.Drawing.Size(159, 29);
            this.retry_button.TabIndex = 4;
            this.retry_button.Text = "начать сначала";
            this.retry_button.UseVisualStyleBackColor = true;
            this.retry_button.Click += new System.EventHandler(this.retry_button_Click);
            // 
            // question1_groupBox
            // 
            this.question1_groupBox.Controls.Add(this.question1_NO);
            this.question1_groupBox.Controls.Add(this.question1_YES);
            this.question1_groupBox.Controls.Add(this.question1);
            this.question1_groupBox.Location = new System.Drawing.Point(6, 130);
            this.question1_groupBox.Name = "question1_groupBox";
            this.question1_groupBox.Size = new System.Drawing.Size(896, 219);
            this.question1_groupBox.TabIndex = 5;
            this.question1_groupBox.TabStop = false;
            this.question1_groupBox.Text = "Вопросы";
            // 
            // question1_NO
            // 
            this.question1_NO.Location = new System.Drawing.Point(613, 114);
            this.question1_NO.Name = "question1_NO";
            this.question1_NO.Size = new System.Drawing.Size(94, 29);
            this.question1_NO.TabIndex = 3;
            this.question1_NO.Text = "Нет";
            this.question1_NO.UseVisualStyleBackColor = true;
            this.question1_NO.Click += new System.EventHandler(this.question1_NO_Click);
            // 
            // question1_YES
            // 
            this.question1_YES.Location = new System.Drawing.Point(159, 114);
            this.question1_YES.Name = "question1_YES";
            this.question1_YES.Size = new System.Drawing.Size(94, 29);
            this.question1_YES.TabIndex = 2;
            this.question1_YES.Text = "Да";
            this.question1_YES.UseVisualStyleBackColor = true;
            this.question1_YES.Click += new System.EventHandler(this.question1_YES_Click);
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Location = new System.Drawing.Point(297, 37);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(285, 20);
            this.question1.TabIndex = 1;
            this.question1.Text = "Вы обожаете адские гитарные запилы?";
            // 
            // question2_groupBox
            // 
            this.question2_groupBox.Controls.Add(this.question2_NO);
            this.question2_groupBox.Controls.Add(this.question2_YES);
            this.question2_groupBox.Controls.Add(this.label1);
            this.question2_groupBox.Location = new System.Drawing.Point(6, 130);
            this.question2_groupBox.Name = "question2_groupBox";
            this.question2_groupBox.Size = new System.Drawing.Size(896, 219);
            this.question2_groupBox.TabIndex = 6;
            this.question2_groupBox.TabStop = false;
            this.question2_groupBox.Text = "Вопросы";
            // 
            // question2_NO
            // 
            this.question2_NO.Location = new System.Drawing.Point(613, 114);
            this.question2_NO.Name = "question2_NO";
            this.question2_NO.Size = new System.Drawing.Size(94, 29);
            this.question2_NO.TabIndex = 3;
            this.question2_NO.Text = "Нет";
            this.question2_NO.UseVisualStyleBackColor = true;
            this.question2_NO.Click += new System.EventHandler(this.question2_NO_Click);
            // 
            // question2_YES
            // 
            this.question2_YES.Location = new System.Drawing.Point(159, 114);
            this.question2_YES.Name = "question2_YES";
            this.question2_YES.Size = new System.Drawing.Size(94, 29);
            this.question2_YES.TabIndex = 2;
            this.question2_YES.Text = "Да";
            this.question2_YES.UseVisualStyleBackColor = true;
            this.question2_YES.Click += new System.EventHandler(this.question2_YES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Любите андерграунд?";
            // 
            // RockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 367);
            this.Controls.Add(this.retry_button);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.question2_groupBox);
            this.Controls.Add(this.question1_groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RockForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RockForm_FormClosed);
            this.question1_groupBox.ResumeLayout(false);
            this.question1_groupBox.PerformLayout();
            this.question2_groupBox.ResumeLayout(false);
            this.question2_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button retry_button;
        private System.Windows.Forms.GroupBox question1_groupBox;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.Button question1_NO;
        private System.Windows.Forms.Button question1_YES;
        private System.Windows.Forms.GroupBox question2_groupBox;
        private System.Windows.Forms.Button question2_NO;
        private System.Windows.Forms.Button question2_YES;
        private System.Windows.Forms.Label label1;
    }
}