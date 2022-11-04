namespace LT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ShowAnswerButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewEntryButton = new System.Windows.Forms.Button();
            this.CheckAnswerButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.ManageEntriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Location = new System.Drawing.Point(12, 33);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(315, 100);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "label1";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Location = new System.Drawing.Point(12, 157);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(315, 78);
            this.AnswerLabel.TabIndex = 1;
            this.AnswerLabel.Text = "?";
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowAnswerButton
            // 
            this.ShowAnswerButton.Location = new System.Drawing.Point(252, 301);
            this.ShowAnswerButton.Name = "ShowAnswerButton";
            this.ShowAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.ShowAnswerButton.TabIndex = 2;
            this.ShowAnswerButton.Text = "Show";
            this.ShowAnswerButton.UseVisualStyleBackColor = true;
            this.ShowAnswerButton.Click += new System.EventHandler(this.ShowAnswerButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(12, 301);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.NextQuestionButton.TabIndex = 3;
            this.NextQuestionButton.Text = "Next Card";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewEntryButton
            // 
            this.NewEntryButton.Location = new System.Drawing.Point(174, 271);
            this.NewEntryButton.Name = "NewEntryButton";
            this.NewEntryButton.Size = new System.Drawing.Size(75, 23);
            this.NewEntryButton.TabIndex = 8;
            this.NewEntryButton.Text = "Add Entry";
            this.NewEntryButton.UseVisualStyleBackColor = true;
            this.NewEntryButton.Click += new System.EventHandler(this.NewEntryButton_Click);
            // 
            // CheckAnswerButton
            // 
            this.CheckAnswerButton.Location = new System.Drawing.Point(252, 242);
            this.CheckAnswerButton.Name = "CheckAnswerButton";
            this.CheckAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.CheckAnswerButton.TabIndex = 9;
            this.CheckAnswerButton.Text = "Check";
            this.CheckAnswerButton.UseVisualStyleBackColor = true;
            this.CheckAnswerButton.Click += new System.EventHandler(this.CheckAnswerButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(18, 244);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(231, 20);
            this.AnswerTextBox.TabIndex = 10;
            // 
            // ManageEntriesButton
            // 
            this.ManageEntriesButton.Location = new System.Drawing.Point(93, 271);
            this.ManageEntriesButton.Name = "ManageEntriesButton";
            this.ManageEntriesButton.Size = new System.Drawing.Size(75, 23);
            this.ManageEntriesButton.TabIndex = 11;
            this.ManageEntriesButton.Text = "Manage";
            this.ManageEntriesButton.UseVisualStyleBackColor = true;
            this.ManageEntriesButton.Click += new System.EventHandler(this.ManageEntriesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 336);
            this.Controls.Add(this.ManageEntriesButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.CheckAnswerButton);
            this.Controls.Add(this.NewEntryButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.ShowAnswerButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label QuestionLabel;
        public System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ShowAnswerButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewEntryButton;
        private System.Windows.Forms.Button CheckAnswerButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button ManageEntriesButton;
    }
}

