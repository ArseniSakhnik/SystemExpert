
namespace SystemExpert.MainForms
{
    partial class MainForm
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
            this.pop_button = new System.Windows.Forms.Button();
            this.rap_button = new System.Windows.Forms.Button();
            this.rock_button = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pop_button
            // 
            this.pop_button.Location = new System.Drawing.Point(645, 250);
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(94, 29);
            this.pop_button.TabIndex = 8;
            this.pop_button.Text = "поп";
            this.pop_button.UseVisualStyleBackColor = true;
            this.pop_button.Click += new System.EventHandler(this.pop_button_Click);
            // 
            // rap_button
            // 
            this.rap_button.Location = new System.Drawing.Point(397, 250);
            this.rap_button.Name = "rap_button";
            this.rap_button.Size = new System.Drawing.Size(94, 29);
            this.rap_button.TabIndex = 7;
            this.rap_button.Text = "рэп";
            this.rap_button.UseVisualStyleBackColor = true;
            this.rap_button.Click += new System.EventHandler(this.rap_button_Click);
            // 
            // rock_button
            // 
            this.rock_button.Location = new System.Drawing.Point(130, 250);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(94, 29);
            this.rock_button.TabIndex = 6;
            this.rock_button.Text = "рок";
            this.rock_button.UseVisualStyleBackColor = true;
            this.rock_button.Click += new System.EventHandler(this.rock_button_Click);
            // 
            // Question
            // 
            this.Question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(259, 167);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(370, 54);
            this.Question.TabIndex = 5;
            this.Question.Text = "Проверка на хохла";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 446);
            this.Controls.Add(this.pop_button);
            this.Controls.Add(this.rap_button);
            this.Controls.Add(this.rock_button);
            this.Controls.Add(this.Question);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pop_button;
        private System.Windows.Forms.Button rap_button;
        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Label Question;
    }
}