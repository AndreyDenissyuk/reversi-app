namespace ReversiApp
{
    partial class GameResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelWhite = new System.Windows.Forms.Label();
            this.LabelBlack = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Location = new System.Drawing.Point(30, 190);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(100, 30);
            this.ButtonRestart.TabIndex = 1;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.UseVisualStyleBackColor = true;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(170, 190);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(100, 30);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ReversiApp.Properties.Resources.DiskWhite_small;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(100, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ReversiApp.Properties.Resources.DiskBlack_small;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(100, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LabelWhite
            // 
            this.LabelWhite.AutoSize = true;
            this.LabelWhite.Font = new System.Drawing.Font("Open Sans Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWhite.Location = new System.Drawing.Point(165, 49);
            this.LabelWhite.Name = "LabelWhite";
            this.LabelWhite.Size = new System.Drawing.Size(26, 30);
            this.LabelWhite.TabIndex = 5;
            this.LabelWhite.Text = "0";
            // 
            // LabelBlack
            // 
            this.LabelBlack.AutoSize = true;
            this.LabelBlack.Font = new System.Drawing.Font("Open Sans Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBlack.Location = new System.Drawing.Point(165, 85);
            this.LabelBlack.Name = "LabelBlack";
            this.LabelBlack.Size = new System.Drawing.Size(26, 30);
            this.LabelBlack.TabIndex = 6;
            this.LabelBlack.Text = "0";
            // 
            // LabelResult
            // 
            this.LabelResult.Font = new System.Drawing.Font("Open Sans Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult.Location = new System.Drawing.Point(30, 136);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(240, 30);
            this.LabelResult.TabIndex = 7;
            this.LabelResult.Text = "Result";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelBlack);
            this.Controls.Add(this.LabelWhite);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameResultForm";
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonRestart;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelWhite;
        private System.Windows.Forms.Label LabelBlack;
        private System.Windows.Forms.Label LabelResult;
    }
}