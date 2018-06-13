namespace SheepInTheCity
{
    partial class FormStartingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartingWindow));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHow = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(192, 129);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(130, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHow
            // 
            this.btnHow.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHow.Location = new System.Drawing.Point(192, 187);
            this.btnHow.Margin = new System.Windows.Forms.Padding(4);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(130, 40);
            this.btnHow.TabIndex = 1;
            this.btnHow.Text = "How to play?";
            this.btnHow.UseVisualStyleBackColor = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnScores
            // 
            this.btnScores.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.Location = new System.Drawing.Point(192, 245);
            this.btnScores.Margin = new System.Windows.Forms.Padding(4);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(130, 40);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // FormStartingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStartingWindow";
            this.Text = "Sheep In The City";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Button btnScores;
    }
}

