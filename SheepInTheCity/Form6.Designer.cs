namespace SheepInTheCity
{
    partial class FormLoser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoser));
            this.btnLoseNewGame = new System.Windows.Forms.Button();
            this.btnLoseExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoseNewGame
            // 
            this.btnLoseNewGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoseNewGame.Location = new System.Drawing.Point(107, 209);
            this.btnLoseNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoseNewGame.Name = "btnLoseNewGame";
            this.btnLoseNewGame.Size = new System.Drawing.Size(108, 50);
            this.btnLoseNewGame.TabIndex = 0;
            this.btnLoseNewGame.Text = "YES!";
            this.btnLoseNewGame.UseVisualStyleBackColor = true;
            this.btnLoseNewGame.Click += new System.EventHandler(this.btnLoseNewGame_Click);
            // 
            // btnLoseExit
            // 
            this.btnLoseExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoseExit.Location = new System.Drawing.Point(268, 210);
            this.btnLoseExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoseExit.Name = "btnLoseExit";
            this.btnLoseExit.Size = new System.Drawing.Size(108, 50);
            this.btnLoseExit.TabIndex = 1;
            this.btnLoseExit.Text = "EXIT";
            this.btnLoseExit.UseVisualStyleBackColor = true;
            this.btnLoseExit.Click += new System.EventHandler(this.btnLoseExit_Click);
            // 
            // FormLoser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.btnLoseExit);
            this.Controls.Add(this.btnLoseNewGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoser";
            this.Text = "Try again";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoseNewGame;
        private System.Windows.Forms.Button btnLoseExit;
    }
}