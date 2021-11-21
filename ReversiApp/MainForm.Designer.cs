namespace ReversiApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.pictureCurrentPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelWhiteScore = new System.Windows.Forms.Label();
            this.LabelBlackScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrentPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(510, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(197, 43);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ReversiApp";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(518, 406);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 25);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.TabStop = false;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(631, 406);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 25);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Font = new System.Drawing.Font("Open Sans", 15F);
            this.labelCurrentPlayer.Location = new System.Drawing.Point(537, 93);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(88, 27);
            this.labelCurrentPlayer.TabIndex = 3;
            this.labelCurrentPlayer.Text = "Current:";
            // 
            // pictureCurrentPlayer
            // 
            this.pictureCurrentPlayer.Location = new System.Drawing.Point(631, 93);
            this.pictureCurrentPlayer.Name = "pictureCurrentPlayer";
            this.pictureCurrentPlayer.Size = new System.Drawing.Size(30, 30);
            this.pictureCurrentPlayer.TabIndex = 4;
            this.pictureCurrentPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15F);
            this.label1.Location = new System.Drawing.Point(537, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "White:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15F);
            this.label2.Location = new System.Drawing.Point(537, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Black:";
            // 
            // LabelWhiteScore
            // 
            this.LabelWhiteScore.AutoSize = true;
            this.LabelWhiteScore.Font = new System.Drawing.Font("Open Sans", 15F);
            this.LabelWhiteScore.Location = new System.Drawing.Point(626, 140);
            this.LabelWhiteScore.Name = "LabelWhiteScore";
            this.LabelWhiteScore.Size = new System.Drawing.Size(23, 27);
            this.LabelWhiteScore.TabIndex = 7;
            this.LabelWhiteScore.Text = "0";
            // 
            // LabelBlackScore
            // 
            this.LabelBlackScore.AutoSize = true;
            this.LabelBlackScore.Font = new System.Drawing.Font("Open Sans", 15F);
            this.LabelBlackScore.Location = new System.Drawing.Point(626, 181);
            this.LabelBlackScore.Name = "LabelBlackScore";
            this.LabelBlackScore.Size = new System.Drawing.Size(23, 27);
            this.LabelBlackScore.TabIndex = 8;
            this.LabelBlackScore.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LabelBlackScore);
            this.Controls.Add(this.LabelWhiteScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCurrentPlayer);
            this.Controls.Add(this.labelCurrentPlayer);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrentPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.PictureBox pictureCurrentPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelWhiteScore;
        private System.Windows.Forms.Label LabelBlackScore;
    }
}

