namespace SheepInTheCity
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnLoseNewGame = new System.Windows.Forms.Button();
            this.btnLoseExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoseNewGame
            // 
            this.btnLoseNewGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoseNewGame.Location = new System.Drawing.Point(80, 170);
            this.btnLoseNewGame.Name = "btnLoseNewGame";
            this.btnLoseNewGame.Size = new System.Drawing.Size(81, 41);
            this.btnLoseNewGame.TabIndex = 0;
            this.btnLoseNewGame.Text = "YES!";
            this.btnLoseNewGame.UseVisualStyleBackColor = true;
            // 
            // btnLoseExit
            // 
            this.btnLoseExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoseExit.Location = new System.Drawing.Point(201, 171);
            this.btnLoseExit.Name = "btnLoseExit";
            this.btnLoseExit.Size = new System.Drawing.Size(81, 41);
            this.btnLoseExit.TabIndex = 1;
            this.btnLoseExit.Text = "EXIT";
            this.btnLoseExit.UseVisualStyleBackColor = true;
            this.btnLoseExit.Click += new System.EventHandler(this.btnLoseExit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 355);
            this.Controls.Add(this.btnLoseExit);
            this.Controls.Add(this.btnLoseNewGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoseNewGame;
        private System.Windows.Forms.Button btnLoseExit;
    }
}