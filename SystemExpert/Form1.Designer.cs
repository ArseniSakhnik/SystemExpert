namespace SystemExpert
{
    partial class Form1
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
            this.rock_button = new System.Windows.Forms.Button();
            this.rap_button = new System.Windows.Forms.Button();
            this.pop_button = new System.Windows.Forms.Button();
            this.retry_button = new System.Windows.Forms.Button();
            this.rock_groupBox = new System.Windows.Forms.GroupBox();
            this.question2 = new System.Windows.Forms.Label();
            this.metal_groupBox = new System.Windows.Forms.GroupBox();
            this.question1_False = new System.Windows.Forms.RadioButton();
            this.question1_True = new System.Windows.Forms.RadioButton();
            this.question1 = new System.Windows.Forms.Label();
            this.rap_groupBox = new System.Windows.Forms.GroupBox();
            this.pop_groupBox = new System.Windows.Forms.GroupBox();
            this.question2_True = new System.Windows.Forms.RadioButton();
            this.question2_False = new System.Windows.Forms.RadioButton();
            this.rock_groupBox.SuspendLayout();
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
            // rock_button
            // 
            this.rock_button.Location = new System.Drawing.Point(138, 95);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(94, 29);
            this.rock_button.TabIndex = 1;
            this.rock_button.Text = "рок";
            this.rock_button.UseVisualStyleBackColor = true;
            this.rock_button.Click += new System.EventHandler(this.rock_button_Click);
            // 
            // rap_button
            // 
            this.rap_button.Location = new System.Drawing.Point(405, 95);
            this.rap_button.Name = "rap_button";
            this.rap_button.Size = new System.Drawing.Size(94, 29);
            this.rap_button.TabIndex = 2;
            this.rap_button.Text = "рэп";
            this.rap_button.UseVisualStyleBackColor = true;
            this.rap_button.Click += new System.EventHandler(this.rap_button_Click);
            // 
            // pop_button
            // 
            this.pop_button.Location = new System.Drawing.Point(653, 95);
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(94, 29);
            this.pop_button.TabIndex = 3;
            this.pop_button.Text = "поп";
            this.pop_button.UseVisualStyleBackColor = true;
            this.pop_button.Click += new System.EventHandler(this.pop_button_Click);
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
            // rock_groupBox
            // 
            this.rock_groupBox.Controls.Add(this.question2_False);
            this.rock_groupBox.Controls.Add(this.question2_True);
            this.rock_groupBox.Controls.Add(this.question2);
            this.rock_groupBox.Controls.Add(this.metal_groupBox);
            this.rock_groupBox.Controls.Add(this.question1_False);
            this.rock_groupBox.Controls.Add(this.question1_True);
            this.rock_groupBox.Controls.Add(this.question1);
            this.rock_groupBox.Location = new System.Drawing.Point(12, 130);
            this.rock_groupBox.Name = "rock_groupBox";
            this.rock_groupBox.Size = new System.Drawing.Size(890, 458);
            this.rock_groupBox.TabIndex = 5;
            this.rock_groupBox.TabStop = false;
            this.rock_groupBox.Text = "Вопросы";
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Location = new System.Drawing.Point(81, 46);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(163, 20);
            this.question2.TabIndex = 5;
            this.question2.Text = "Любите андерграунд?";
            this.question2.Visible = false;
            // 
            // metal_groupBox
            // 
            this.metal_groupBox.Location = new System.Drawing.Point(7, 144);
            this.metal_groupBox.Name = "metal_groupBox";
            this.metal_groupBox.Size = new System.Drawing.Size(871, 299);
            this.metal_groupBox.TabIndex = 4;
            this.metal_groupBox.TabStop = false;
            this.metal_groupBox.Text = "Метал";
            this.metal_groupBox.Visible = false;
            // 
            // question1_False
            // 
            this.question1_False.AutoSize = true;
            this.question1_False.Location = new System.Drawing.Point(348, 111);
            this.question1_False.Name = "question1_False";
            this.question1_False.Size = new System.Drawing.Size(55, 24);
            this.question1_False.TabIndex = 3;
            this.question1_False.TabStop = true;
            this.question1_False.Text = "Нет";
            this.question1_False.UseVisualStyleBackColor = true;
            this.question1_False.CheckedChanged += new System.EventHandler(this.question1False_CheckedChanged);
            // 
            // question1_True
            // 
            this.question1_True.AutoSize = true;
            this.question1_True.Location = new System.Drawing.Point(97, 111);
            this.question1_True.Name = "question1_True";
            this.question1_True.Size = new System.Drawing.Size(48, 24);
            this.question1_True.TabIndex = 2;
            this.question1_True.TabStop = true;
            this.question1_True.Text = "Да";
            this.question1_True.UseVisualStyleBackColor = true;
            this.question1_True.CheckedChanged += new System.EventHandler(this.question1True_CheckedChanged);
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Location = new System.Drawing.Point(81, 46);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(285, 20);
            this.question1.TabIndex = 1;
            this.question1.Text = "Вы обожаете адские гитарные запилы?";
            // 
            // rap_groupBox
            // 
            this.rap_groupBox.Location = new System.Drawing.Point(6, 130);
            this.rap_groupBox.Name = "rap_groupBox";
            this.rap_groupBox.Size = new System.Drawing.Size(890, 458);
            this.rap_groupBox.TabIndex = 6;
            this.rap_groupBox.TabStop = false;
            this.rap_groupBox.Text = "Вопросы2";
            // 
            // pop_groupBox
            // 
            this.pop_groupBox.Location = new System.Drawing.Point(6, 130);
            this.pop_groupBox.Name = "pop_groupBox";
            this.pop_groupBox.Size = new System.Drawing.Size(896, 458);
            this.pop_groupBox.TabIndex = 0;
            this.pop_groupBox.TabStop = false;
            this.pop_groupBox.Text = "Вопросы3";
            // 
            // question2_True
            // 
            this.question2_True.AutoSize = true;
            this.question2_True.Location = new System.Drawing.Point(97, 111);
            this.question2_True.Name = "question2_True";
            this.question2_True.Size = new System.Drawing.Size(48, 24);
            this.question2_True.TabIndex = 6;
            this.question2_True.TabStop = true;
            this.question2_True.Text = "Да";
            this.question2_True.UseVisualStyleBackColor = true;
            this.question2_True.Visible = false;
            // 
            // question2_False
            // 
            this.question2_False.AutoSize = true;
            this.question2_False.Location = new System.Drawing.Point(348, 111);
            this.question2_False.Name = "question2_False";
            this.question2_False.Size = new System.Drawing.Size(55, 24);
            this.question2_False.TabIndex = 7;
            this.question2_False.TabStop = true;
            this.question2_False.Text = "Нет";
            this.question2_False.UseVisualStyleBackColor = true;
            this.question2_False.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.rock_groupBox);
            this.Controls.Add(this.retry_button);
            this.Controls.Add(this.pop_button);
            this.Controls.Add(this.rap_button);
            this.Controls.Add(this.rock_button);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.pop_groupBox);
            this.Controls.Add(this.rap_groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rock_groupBox.ResumeLayout(false);
            this.rock_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Button rap_button;
        private System.Windows.Forms.Button pop_button;
        private System.Windows.Forms.Button retry_button;
        private System.Windows.Forms.GroupBox rock_groupBox;
        private System.Windows.Forms.GroupBox rap_groupBox;
        private System.Windows.Forms.GroupBox pop_groupBox;
        private System.Windows.Forms.RadioButton question1_True;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.RadioButton question1_False;
        private System.Windows.Forms.GroupBox metal_groupBox;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.RadioButton question2_False;
        private System.Windows.Forms.RadioButton question2_True;
    }
}