namespace Lab_3
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.btnCheat = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.lblLoserAnswer = new System.Windows.Forms.Label();
            this.lblWinAnswer = new System.Windows.Forms.Label();
            this.lblGuessAnswer = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDisplay.Location = new System.Drawing.Point(142, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(205, 17);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Guess a number from 1 to 100.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(189, 181);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(121, 54);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.Location = new System.Drawing.Point(181, 114);
            this.txtUserEntry.Multiline = true;
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(129, 23);
            this.txtUserEntry.TabIndex = 2;
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(62, 181);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(112, 54);
            this.btnCheat.TabIndex = 5;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.lblLoserAnswer);
            this.gbxInfo.Controls.Add(this.lblWinAnswer);
            this.gbxInfo.Controls.Add(this.lblGuessAnswer);
            this.gbxInfo.Controls.Add(this.lblLose);
            this.gbxInfo.Controls.Add(this.lblWin);
            this.gbxInfo.Controls.Add(this.lblGuess);
            this.gbxInfo.Location = new System.Drawing.Point(160, 280);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(176, 119);
            this.gbxInfo.TabIndex = 6;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Info";
            // 
            // lblLoserAnswer
            // 
            this.lblLoserAnswer.AutoSize = true;
            this.lblLoserAnswer.Location = new System.Drawing.Point(85, 89);
            this.lblLoserAnswer.Name = "lblLoserAnswer";
            this.lblLoserAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblLoserAnswer.TabIndex = 5;
            // 
            // lblWinAnswer
            // 
            this.lblWinAnswer.AutoSize = true;
            this.lblWinAnswer.Location = new System.Drawing.Point(85, 57);
            this.lblWinAnswer.Name = "lblWinAnswer";
            this.lblWinAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblWinAnswer.TabIndex = 4;
            // 
            // lblGuessAnswer
            // 
            this.lblGuessAnswer.AutoSize = true;
            this.lblGuessAnswer.Location = new System.Drawing.Point(85, 24);
            this.lblGuessAnswer.Name = "lblGuessAnswer";
            this.lblGuessAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblGuessAnswer.TabIndex = 3;
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Location = new System.Drawing.Point(21, 89);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(33, 13);
            this.lblLose.TabIndex = 2;
            this.lblLose.Text = "Lose:";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(21, 57);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(29, 13);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "Win:";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(21, 24);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(40, 13);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(328, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 54);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 429);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.txtUserEntry);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label lblLoserAnswer;
        private System.Windows.Forms.Label lblWinAnswer;
        private System.Windows.Forms.Label lblGuessAnswer;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnReset;
    }
}

