
namespace SystemExpert.MainForms
{
    partial class PopForm
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
            this.Question = new System.Windows.Forms.Label();
            this.question2_groupBox = new System.Windows.Forms.GroupBox();
            this.question2_NO = new System.Windows.Forms.Button();
            this.question2_YES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.question1_groupBox = new System.Windows.Forms.GroupBox();
            this.question1_NO = new System.Windows.Forms.Button();
            this.question1_YES = new System.Windows.Forms.Button();
            this.question1 = new System.Windows.Forms.Label();
            this.question2_groupBox.SuspendLayout();
            this.question1_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(257, 55);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(370, 54);
            this.Question.TabIndex = 7;
            this.Question.Text = "Проверка на хохла";
            // 
            // question2_groupBox
            // 
            this.question2_groupBox.Controls.Add(this.question2_NO);
            this.question2_groupBox.Controls.Add(this.question2_YES);
            this.question2_groupBox.Controls.Add(this.label1);
            this.question2_groupBox.Location = new System.Drawing.Point(36, 162);
            this.question2_groupBox.Name = "question2_groupBox";
            this.question2_groupBox.Size = new System.Drawing.Size(896, 219);
            this.question2_groupBox.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Любите повторяющиеся биты?";
            // 
            // question1_groupBox
            // 
            this.question1_groupBox.Controls.Add(this.question1_NO);
            this.question1_groupBox.Controls.Add(this.question1_YES);
            this.question1_groupBox.Controls.Add(this.question1);
            this.question1_groupBox.Location = new System.Drawing.Point(36, 162);
            this.question1_groupBox.Name = "question1_groupBox";
            this.question1_groupBox.Size = new System.Drawing.Size(896, 219);
            this.question1_groupBox.TabIndex = 9;
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
            this.question1.Size = new System.Drawing.Size(134, 20);
            this.question1.TabIndex = 1;
            this.question1.Text = "Как насчет диско?";
            // 
            // PopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.question1_groupBox);
            this.Controls.Add(this.question2_groupBox);
            this.Name = "PopForm";
            this.Text = "PopForm";
            this.question2_groupBox.ResumeLayout(false);
            this.question2_groupBox.PerformLayout();
            this.question1_groupBox.ResumeLayout(false);
            this.question1_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.GroupBox question2_groupBox;
        private System.Windows.Forms.Button question2_NO;
        private System.Windows.Forms.Button question2_YES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox question1_groupBox;
        private System.Windows.Forms.Button question1_NO;
        private System.Windows.Forms.Button question1_YES;
        private System.Windows.Forms.Label question1;
    }
}